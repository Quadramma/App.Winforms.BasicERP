using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Db
{
    public class MongoDynamicSerializationProvider : IBsonSerializationProvider
    {
        public IBsonSerializer GetSerializer(Type type)
        {
            if (typeof(MongoDynamic).IsAssignableFrom(type))
                return MongoDynamicBsonSerializer.Instance;
            return null;
        }
    }
}
