using Fac.Db;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public class MainDb
    {
      
        //USER
        public static List<User> getUsers() {
            return MongoDBController.Usuarios.FindAs<User>(Query<User>.NE(c => c.username, "")).ToList();
        }
        public static void deleteUsers() {
            MongoDBController.Usuarios.RemoveAll();
        }
        public static void saveUser(string username, string password) {
            User entity = new User();
            var user = entity.AddLike<IUser>();        
            user.username = username;
            user.password = password;
            MongoDBController.Usuarios.Save(user);
        }
        public static void saveUser(User user)
        {
            var obj = user.AddLike<IUser>();
            MongoDBController.Empresas.Save(obj);
        }

        //DOC
        public static List<Doc> getDocumentos(Emp emp)
        {
            return MongoDBController.Documentos.FindAs<Doc>(Query<Doc>.EQ(c =>c.empId, emp._id)).ToList();
        }
        public static void deleteDocumento(Doc doc)
        {
            MongoDBController.Documentos.Remove(Query<Emp>.EQ(c => c._id, doc._id));
        }

        public static void deleteDocumentos()
        {
            MongoDBController.Documentos.RemoveAll();
        }

        public static void SaveDocumento(Doc doc)
        {
            var obj = doc.AddLike<IDoc>();
            MongoDBController.Documentos.Save(obj);
        }
        public static void SaveDocumentos(List<Doc> docs)
        {
            foreach (Doc doc in docs) {
                SaveDocumento(doc);
            }
        }

        //EMP
        public static List<Emp> getEmpresas()
        {
            return MongoDBController.Empresas.FindAllAs<Emp>().ToList();
        }
        public static void deleteEmpresa(Emp emp)
        {
            MongoDBController.Empresas.Remove(Query<Emp>.EQ(c => c._id, emp._id));
        }

        public static void deleteEmpresas()
        {
            MongoDBController.Empresas.RemoveAll();
        }
        public static void SaveEmpresa(Emp emp) {
            MongoDBController.Empresas.Save(emp);
        }
        
        public static void SyncEmpresa(Emp emp) {
            SaveEmpresa(emp);
            SaveDocumentos(emp.docs);
            foreach(Doc d in emp.docs){
                SaveDocumentos(d.aplicaciones); 
            }
            //
            long docsCount = MongoDBController.Documentos.Count(Query<Doc>.EQ(c => c.empId,emp._id));
            if (emp.docs.Count() != docsCount) {
                emp.docs = MongoDBController.Documentos.FindAs<Doc>(Query<Doc>.EQ(c => c.empId, emp._id)).ToList();
            }

            //cargamos las aplicaciones de un recibo
            foreach (Doc doc in emp.docs) {
                doc.aplicaciones = MongoDBController.Documentos.FindAs<Doc>(Query<Doc>.EQ(c => c.pagoId, doc._id)).ToList();
            }
        }
    }
}
