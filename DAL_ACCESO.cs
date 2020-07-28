using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class ACCESO
    {
        SqlConnection cn = new SqlConnection(@"integrated security = SSPI; data source=DESKTOP-BU7TQ17; Initial catalog= PROCESOS");
        SqlTransaction tx;

        public void Abrir() {
            cn.Open();
        }

        public void Cerrar() {
            cn.Close();
            cn.Dispose();
        }
        public void iniciarTX() {
            tx = cn.BeginTransaction();
        }

        public void confirmarTX() {
            tx.Commit();
            tx = null;
        }

        public void deshacerTX() {
            tx.Rollback();
            tx = null;
        }

        public DataTable Leer(string consulta, SqlParameter[] parametros) {
            Abrir();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandText = consulta;
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Connection = cn;

            if (parametros != null) {
                adaptador.SelectCommand.Parameters.AddRange(parametros);
            }
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            
            Cerrar();
            return tabla;
        }

        public int Escribir(string consulta, SqlParameter[] parametros) {
            int fa = 0;
            Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            if (parametros != null) {
                cmd.Parameters.AddRange(parametros);
            }
            try
            {
                fa = cmd.ExecuteNonQuery();
            }
            catch {
                fa = -1;
            }

            Cerrar();
            cmd.Dispose();
            cmd = null;
            return fa;
        }
       
    }
}
