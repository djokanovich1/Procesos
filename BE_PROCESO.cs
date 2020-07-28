using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PROCESO
    {
        private int ID_PROCESO;
        public int id_proceso {
            get { return ID_PROCESO; }
            set { ID_PROCESO = value; }
        }

        public override string ToString()
        {
            return PROCESO_NOMBRE;
        }

        private string PROCESO_NOMBRE;
        public string proceso {
            get { return PROCESO_NOMBRE; }
            set { PROCESO_NOMBRE = value; }
        }

        public PROCESO(int id, string pNombre) {
            PROCESO_NOMBRE = pNombre;
            ID_PROCESO = id;
        }
        public PROCESO() { }

        private DETALLE DETALLE;
        public DETALLE detalle {
            get { return DETALLE; }
            set { DETALLE = value; }
        }


    }
}
