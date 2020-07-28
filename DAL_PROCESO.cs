using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DAL
{
   public  class PROCESO
    {
        ACCESO ACC = new ACCESO();
        DataSet ds = new DataSet();

        public List<BE.PROCESO> Listar() {

            List<BE.PROCESO> PROCESOS = new List<BE.PROCESO>();
            DataTable dt = new DataTable();
            dt = ACC.Leer("Listar_procesos", null);
            foreach (DataRow r in dt.Rows) {
                PROCESOS.Add(new BE.PROCESO((int)r[0], r[1].ToString()));
            }
            return PROCESOS;
        }

        public void CrearEsquema() {
            ds = null;
            ds = new DataSet("PROCESOS");

            if (File.Exists(@"D:\Florencia\Documents\xml\Procesos.xml"))
            {
                ds.ReadXmlSchema(@"D:\Florencia\Documents\xml\Procesos_estructura.xml");
                ds.ReadXml(@"D:\Florencia\Documents\Procesos.xml");
            }
            else {
                DataTable tabla = new DataTable("PROCESO");
                tabla.Columns.Add(new DataColumn("NOMBRE"));
                ds.Tables.Add(tabla);
                ds.WriteXmlSchema(@"D:\Florencia\Documents\xml\Procesos_estructura.xml");
            }
        }

        public int ExportarXML(List<BE.PROCESO> listaProcesos) {
            int fa = 0;
            CrearEsquema();
            if (listaProcesos != null)
            {
                foreach (BE.PROCESO p in listaProcesos)
                {
                    DataRow reg = ds.Tables[0].NewRow();
                    reg["NOMBRE"] = p.proceso.ToString();
                    ds.Tables[0].Rows.Add(reg);
                }
                ds.WriteXml("D:\\Florencia\\Documents\\xml\\Procesos.xml");
               
                fa = 1;
            }
            else {
                fa = -1;
            }
            return fa; 
        }


    }
}
