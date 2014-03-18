using Fac.Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Db
{
    public class MongoDBController
    {
        private string connectionString;
        private MongoClient client;
        private MongoServer server;
        Process mongod;
        //
        private MongoCollection empresasCollection;
        private MongoCollection documentosCollection;
        private MongoCollection usuariosCollection;
        //
        private static MongoDBController instance = new MongoDBController();

        private void init() {
            string mongoBINpath = @"C:\Users\Javier\Downloads\mongodb-win32-x86_64-2008plus-2.4.9\bin";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = mongoBINpath + @"\mongod.exe";
            start.WindowStyle = ProcessWindowStyle.Normal;
            start.UseShellExecute = false;
            start.Arguments = "--dbpath c:\\data3";
            mongod = Process.Start(start);
            System.Threading.Thread.Sleep(3000);
        }

        public static void shutdown() {
            instance.server.Shutdown();
            //instance.mongod.Kill();
        }

        private MongoDBController()
        {
            init();
            //
            BsonClassMap.RegisterClassMap<DocType>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<Doc>(cm =>
            {
                cm.AutoMap();
                //cm.MapProperty(c => c.empId);
                //cm.MapIdProperty(c => c.Id);
                
                
                //cm.UnmapProperty(c => c.Id);
                //cm.IdMemberMap.SetIdGenerator(ObjectIdGenerator.Instance);
                
            });
            BsonClassMap.RegisterClassMap<EmpType>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<Emp>(cm =>
            {
                cm.AutoMap();
                /*
                cm.MapIdField(c => c.i);
                cm.IdMemberMap.SetIdGenerator(ObjectIdGenerator.Instance);
                cm.MapProperty<string>(c => c.name);
                cm.MapProperty<List<Doc>>(c => c.docs);
                 */
                //
                cm.UnmapProperty(c => c.docs);
            });

            connectionString = "mongodb://localhost";
            client = new MongoClient(connectionString);
            server = client.GetServer();
            var database = server.GetDatabase("test");
            empresasCollection = database.GetCollection<IEmp>("empresas");
            documentosCollection = database.GetCollection<IDoc>("documentos");
            usuariosCollection = database.GetCollection<IUser>("usuarios");
        }
        //
        public static MongoCollection Empresas { get { return instance.empresasCollection; } private set { } }
        public static MongoCollection Documentos { get { return instance.documentosCollection; } private set { } }
        public static MongoCollection Usuarios { get { return instance.usuariosCollection; } private set { } }
    }
}
