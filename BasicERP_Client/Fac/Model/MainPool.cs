using Fac.Db;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public class MainPool
    {
        private List<Emp> empresasList;
        //
        private static MainPool instance = new MainPool();
        public static List<Emp> empresas { get { return instance.empresasList; } set { instance.empresasList = value; } }
        private MainPool()
        {
            empresasList = new List<Emp>();


        }

        public static void Sync()
        {
            foreach (Emp e in instance.empresasList)
            {
                MainDb.SyncEmpresa(e);
            }
        }

        public static void DummyData()
        {
            if (!MainPool.hayEmpresas())
            {
                MainPool.empresas.AddRange(new Emp[]{
            new Emp(){
            name = "Juan Jose Garcia Hermnos",
            type = EmpType.Cliente
            },new Emp(){
            name = "Clarity S.A",
            type = EmpType.Cliente
            },new Emp(){
            name = "Petersen",
            type = EmpType.Cliente
            },new Emp(){
            name = "R & G Graficos",
            type = EmpType.Cliente
            },new Emp(){
            name = "Los hermanos",
            type = EmpType.Cliente
            },new Emp(){
            name = "Quadramma",
            type = EmpType.Cliente
            },new Emp(){
            name = "Los Nocheros",
            type = EmpType.Cliente
            },new Emp(){
            name = "Sprite S.A",
            type = EmpType.Cliente
            },new Emp(){
            name = "Mac Donals",
            type = EmpType.Cliente
            },new Emp(){
            name = "River Plate Sociedad Anonima",
            type = EmpType.Cliente
            },new Emp(){
            name = "Mar del Plata Churros S.A",
            type = EmpType.Cliente
            },new Emp(){
            name = "Los Caballos Restobar",
            type = EmpType.Cliente
            },new Emp(){
            name = "El Acantilado Fierros S.A",
            type = EmpType.Cliente
            },new Emp(){
            name = "Formula Dos Repuestos S.A",
            type = EmpType.Cliente
            },new Emp(){
            name = "Rutamar Transportes",
            type = EmpType.Cliente
            },new Emp(){
            name = "Rapido del Norte S.A",
            type = EmpType.Cliente
            },new Emp(){
            name = "Dos mil S.A",
            type = EmpType.Cliente
            }
            });

                /*
                MainPool.empresas[0].addDoc(new Doc()
                {
                    type = DocType.Factura,
                    observacion = "Factura de ejemplo",
                    importe = 1500,
                    fecha = DateTime.Now
                });

                MainPool.empresas[0].addDoc(new Doc()
                {
                    type = DocType.Factura,
                    observacion = "Factura de ejemplo 2",
                    importe = 1300,
                    fecha = DateTime.Now
                });
                */

                MainPool.Sync();

            }
        }

        public static void onMatch(List<Emp> lista, string keyword, int filtro, Action<object> onMatchHandler)
        {
            keyword = keyword.ToLower();
            foreach (object o in lista)
            {
                Emp em = (Emp)o;
                if (em != null)
                {
                    string val = "";
                    switch (filtro)
                    {
                        case (int)EmpFiltro.name: val = em.name.ToLower(); break;
                        case (int)EmpFiltro.apellido: val = em.name.ToLower(); break;
                        case (int)EmpFiltro.cuit: val = em.name.ToLower(); break;
                        default:
                            val = em.name.ToLower(); break;
                    }

                    for (int x = 0; x < val.Length; x++)
                    {
                        string valPart = val.Substring(x, (x + keyword.Length < val.Length) ? keyword.Length : val.Length - x);
                        if (valPart.Equals(keyword))
                        {
                            onMatchHandler(o);
                            return;
                        }
                    }
                }
            }
        }


        public static void Initialize()
        {
            instance.empresasList = MainDb.getEmpresas();
        }

        public static bool hayEmpresas()
        {
            //List<Emp> emps
            bool has = MongoDBController.Empresas.FindOneAs<Emp>() != null;
            return has;
        }


    }
}
