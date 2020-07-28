using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace BLL
{
    public class PROCESO
    {
        DAL.PROCESO mp_proceso = new DAL.PROCESO();
        public List<BE.PROCESO> LISTAR() {
            return mp_proceso.Listar();
        }

        public string exportarXML(List<BE.PROCESO> listaProcesos) {
            int fa = 0;
            string resultado = "";
            DAL.PROCESO mapper_proceso = new DAL.PROCESO();
            List<BE.PROCESO> procesos = new List<BE.PROCESO>();
            foreach (BE.PROCESO p in listaProcesos) {
                BE.PROCESO proc = new BE.PROCESO();
                proc.proceso = p.detalle.ToString();
                proc.id_proceso = p.id_proceso;
                procesos.Add(proc);
            }
            
            fa = mapper_proceso.ExportarXML(procesos);
            if (fa != 0)
            {
                resultado = "OK";
            }
            else {
                resultado = "MAL";
            }
            return resultado;
        }

    }
}
