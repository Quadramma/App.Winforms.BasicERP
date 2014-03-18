using ImpromptuInterface;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Db
{
    /// <summary>
    /// All MongoDynamic objects support this interface because every object needs an _id in MongoDB
    /// </summary>
    public interface IId
    {
        ObjectId _id { get; set; }
    }

    /// <summary>
    /// MongoDynamic is like an ExpandoObject that also understands document Ids and uses Improptu interface
    /// to act like any other collection of interfaces ...
    /// It can be serialized and deserialized from BSon and thus stored in a MongoDB database.
    /// </summary>
    /// <remarks>
    /// This simple class gives you the ability to define database objects using only .NET interfaces - no classes!
    /// Those objects can be dynamically extended to support any interface you want to add to them - polymorphism!
    /// When loaded back from the database the object will support all of the interfaces that were ever applied to it.
    /// Adding a new field is easy.  Removing one works too.
    /// All fields must be nullable since they may not be present on earlier instances of an object type.
    /// </remarks>
    public class MongoDynamic : DynamicObject, IId
    {
        [BsonId(Order = 1)]
        public ObjectId _id { get; set; }

        // Dumb name for a property - which is why I chose it - very unlikely it will ever conflict with a real property name
        public const string InterfacesField = "int";

        /// <summary>
        /// Interfaces that have been added to this object
        /// </summary>
        /// <remarks>
        /// We always begin by supporting the _id interface
        /// Order is important, we need to see this field before we can deserialize any others
        /// </remarks>
        [BsonElement(InterfacesField, Order = 2)]
        internal HashSet<string> @int = new HashSet<string>() { typeof(IId).FullName };

        /// <summary>
        /// A text version of all interfaces - mostly for debugging purposes, stored in alphabetical order
        /// </summary>
        [BsonIgnore]
        public string InterfacesAsText
        {
            get { return string.Join(",", this.@int.OrderBy(i => i)); }
        }

        /// <summary>
        /// Add support for an interface to this document if it doesn't already have it
        /// </summary>
        public T AddLike<T>()
            where T : class
        {
            @int.Add(typeof(T).FullName);
            // And also act like any interfaces that interface implements (which will include ones they represent too)
            foreach (var @interface in typeof(T).GetInterfaces())
                @int.Add(@interface.FullName);
            return Impromptu.ActLike<T>(this, this.GetAllInterfaces());
        }

        /// <summary>
        /// Add support for multiple interfaces
        /// </summary>
        public T AddLike<T>(Type[] otherInterfaces)
            where T : class
        {
            var allInterfaces = otherInterfaces.Concat(new[] { typeof(T) });
            var allInterfacesAndDescendants = allInterfaces.Concat(allInterfaces.SelectMany(x => x.GetInterfaces()));
            foreach (var @interface in allInterfacesAndDescendants)
                @int.Add(@interface.FullName);
            return Impromptu.ActLike<T>(this, this.GetAllInterfaces());
        }

        /// <summary>
        /// Cast this object to an interface only if it has previously been created as one of that kind
        /// </summary>
        public T AsLike<T>()
            where T : class
        {
            if (!this.@int.Contains(typeof(T).FullName)) return null;
            else return Impromptu.ActLike<T>(this, this.GetAllInterfaces());
        }

        // A rather large cache of all interface types loaded into the App Domain
        private static List<Type> cacheOfTypes = null;

        // A cache of the interface types corresponding to a given 'key' of interface names
        private static Dictionary<string, Type[]> cacheOfInterfaces = new Dictionary<string, Type[]>();

        public Type[] GetAllInterfaces()
        {
            // We always behave like an object with an Id plus any other interfaces we have
            var key = string.Join(",", this.@int.OrderBy(i => i));
            if (!cacheOfInterfaces.ContainsKey(key))
            {
                if (cacheOfTypes == null)
                {
                    var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                    cacheOfTypes = assemblies.SelectMany(ass => ass.GetTypes()).Where(t => t.IsInterface).ToList();
                }
                var interfaces = cacheOfTypes.Where(t => this.@int.Any(i => i == t.FullName));

                // Could trim the interfaces to remove any that are inherited from others ...
                cacheOfInterfaces.Add(key, interfaces.ToArray());
            }
            return cacheOfInterfaces[key];
        }

        /// <summary>
        /// Get a mapping from a field name to a type according to the interfaces on this object
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Type> GetTypeMap()
        {
            Dictionary<string, Type> typeMap = new Dictionary<string, Type>();
            var interfaces = this.GetAllInterfaces();
            foreach (var mi in interfaces.SelectMany(intf => intf.GetProperties()))
            {
                typeMap[mi.Name] = mi.PropertyType;
            }
            return typeMap;
        }


        /// <summary>
        /// Becomes a Proxy object that acts like it implements all of the interfaces listed as being supported by this Entity
        /// </summary>
        /// <remarks>
        /// Because the returned object supports ALL of the interfaces that have ever been added to this object
        /// you can cast it to any of them.  This enables a type of polymorphism.
        /// </remarks>
        public object ActLikeAllInterfacesPresent()
        {
            return Impromptu.DynamicActLike(this, this.GetAllInterfaces());
        }

        [BsonIgnore]
        // BsonIgnore because Bson serialization will happen on the dynamic interface this class exposes not on this dictionary
        private Dictionary<string, object> children = new Dictionary<string, object>();

        /// <summary>
        /// Fetch a property by name
        /// </summary>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (binder.Name == "_id") { result = this._id; return true; }
            else if (binder.Name == InterfacesField) { result = this.@int; return true; }
            else
            {
                children.TryGetValue(binder.Name, out result);
                result = null;                         // we hope that it's nullable!  If not you have an issue 
                return true;                           // when you do a database migration or query a nullable field it won't be in 'children'
            }
        }

        /// <summary>
        /// Set a property (e.g. person1.Name = "Smith")
        /// </summary>     
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (binder.Name == "_id") { this._id = (ObjectId)value; return true; }      // you shouldn't need to use this
            if (binder.Name == InterfacesField) throw new AccessViolationException("You cannot set the interfaces directly, use AddLike() instead");
            if (!this.GetTypeMap().ContainsKey(binder.Name)) throw new ArgumentException("Property '" + binder.Name + "' not found.  You need to call AddLike to specify the interfaces you want to support.");
            children[binder.Name] = value;
            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return new[] { "_id", InterfacesField }.Concat(children.Keys);
        }

        /// <summary>
        /// An indexer for use by serialization code
        /// </summary>
        internal object this[string key]
        {
            get
            {
                if (key == "_id") return this._id;
                else if (key == InterfacesField) return this.@int;
                else return children[key];
            }

            set
            {
                if (key == "_id" && value is BsonObjectId) this._id = ((BsonObjectId)value).Value;
                else if (key == "_id") this._id = (ObjectId)value;
                else if (key == InterfacesField) this.@int = new HashSet<string>((IEnumerable<string>)value);
                else children[key] = value;
            }
        }
    }
}
