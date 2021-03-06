﻿using ImpromptuInterface;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Db
{
    public class MongoDynamicBsonSerializer : BsonBaseSerializer
    {
        private static MongoDynamicBsonSerializer instance = new MongoDynamicBsonSerializer();

        public static MongoDynamicBsonSerializer Instance
        {
            get { return instance; }
        }

        public override object Deserialize(BsonReader bsonReader, Type nominalType, IBsonSerializationOptions options)
        {
            var bsonType = bsonReader.CurrentBsonType;
            if (bsonType == BsonType.Null)
            {
                bsonReader.ReadNull();
                return null;
            }
            else if (bsonType == BsonType.Document)
            {
                var os = new ObjectSerializer();
                MongoDynamic md = new MongoDynamic();
                bsonReader.ReadStartDocument();

                Dictionary<string, Type> typeMap = null;

                // scan document first to find interfaces
                {
                    var bookMark = bsonReader.GetBookmark();
                    if (bsonReader.FindElement(MongoDynamic.InterfacesField))
                    {
                        md[MongoDynamic.InterfacesField] = BsonSerializer.Deserialize<BsonValue>(bsonReader).AsBsonArray.Select(x => x.AsString);
                        typeMap = md.GetTypeMap();
                    }
                    else
                    {
                        throw new FormatException("No interfaces defined for this dynamic object - can't deserialize it");
                    }
                    bsonReader.ReturnToBookmark(bookMark);
                }

                while (bsonReader.ReadBsonType() != BsonType.EndOfDocument)
                {
                    var name = bsonReader.ReadName();

                    if (name == "_id")
                    {
                        //md[name] = BsonValue.ReadFrom(bsonReader).AsObjectId;
                        md[name] =  BsonSerializer.Deserialize<ObjectId>(bsonReader);
                    }
                    else if (name == MongoDynamic.InterfacesField)
                    {
                        // Read it and ignore it, we already have it
                        //BsonValue.ReadFrom(bsonReader);
                        BsonSerializer.Deserialize<ObjectId>(bsonReader);
                    }
                    else
                    {
                        if (typeMap == null) throw new FormatException("No interfaces define for this dynamic object - can't deserialize");
                        // lookup the type for this element according to the interfaces
                        Type elementType;
                        if (typeMap.TryGetValue(name, out elementType))
                        {
                            var value = BsonSerializer.Deserialize(bsonReader, elementType);
                            md[name] = value;
                        }
                        else
                        {
                            // This is a value that is no longer in the interface, maybe a column you removed
                            // not really much we can do with it ... but we need to read it and move on
                            var value = BsonSerializer.Deserialize(bsonReader, typeof(object));
                            md[name] = value;

                            // As with all databases, removing elements from the schema is always going to cause problems ... 
                        }
                    }
                }
                bsonReader.ReadEndDocument();
                return md;
            }
            else
            {
                var message = string.Format("Can't deserialize a {0} from BsonType {1}.", nominalType.FullName, bsonType);
                throw new FormatException(message);
            }
        }


        public bool GetDocumentId(object document, out object id, out Type idNominalType, out IIdGenerator idGenerator)
        {
            MongoDynamic x = (MongoDynamic)document;
            id = x._id;
            idNominalType = typeof(ObjectId);
            idGenerator = new ObjectIdGenerator();
            return true;
        }

        public void SetDocumentId(object document, object id)
        {
            MongoDynamic x = (MongoDynamic)document;
            x._id = (ObjectId)id;
        }

        public override void Serialize(BsonWriter bsonWriter, Type nominalType, object value, IBsonSerializationOptions options)
        {
            if (value == null)
            {
                bsonWriter.WriteNull();
                return;
            }
            var metaObject = ((System.Dynamic.IDynamicMetaObjectProvider)value).GetMetaObject(Expression.Constant(value));
            var memberNames = metaObject.GetDynamicMemberNames().ToList();
            if (memberNames.Count == 0)
            {
                bsonWriter.WriteNull();
                return;
            }

            bsonWriter.WriteStartDocument();
            foreach (var memberName in memberNames)
            {
                // ToDo: handle all those _id Id id variants?
                bsonWriter.WriteName(memberName);

                object memberValue;
                if (memberName == "_id") memberValue = ((MongoDynamic)value)._id;
                else if (memberName == "int") memberValue = ((MongoDynamic)value).@int;
                else memberValue = Impromptu.InvokeGet(value, memberName);

                if (memberValue == null)
                    bsonWriter.WriteNull();
                else
                {
                    var memberType = memberValue.GetType();
                    var serializer = BsonSerializer.LookupSerializer(memberType);
                    serializer.Serialize(bsonWriter, memberType, memberValue, null);
                }
            }
            bsonWriter.WriteEndDocument();
        }
    }
}
