using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PARAMETRO
    {

        private int ID_PARAMETRO;
        public int id_parametro {
            get { return ID_PARAMETRO; }
            set { ID_PARAMETRO = value; }
        }

        private string NOMBRE_PARAMETRO;
        public string nombre_parametro {
            get { return NOMBRE_PARAMETRO; }
            set { NOMBRE_PARAMETRO = value; }
        }

        private PROCESO ID_PROCESO;
        public PROCESO id_proceso {
            get { return ID_PROCESO; }
            set { ID_PROCESO = value; }
        }
    }
}
