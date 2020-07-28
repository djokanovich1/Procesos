using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class DETALLE
    {
        private int ID_DETALLE;
        public int id_detalle {
            get { return ID_DETALLE; }
            set { ID_DETALLE = value; }
        }

        private DateTime TIEMPO_EJECUCION;
        public DateTime tiempo_ejecucion {
            get { return TIEMPO_EJECUCION; }
            set { TIEMPO_EJECUCION = value;  }
        }

        private PROCESO ID_PROCESO;
        public PROCESO id_proceso {
            get { return ID_PROCESO; }
            set { ID_PROCESO = value;    }
        }

        private ESTADO ID_ESTADO; 
        public ESTADO id_estado {
            get { return ID_ESTADO; }
            set { ID_ESTADO = value; }
        }

    }
}
