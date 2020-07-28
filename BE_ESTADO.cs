using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class ESTADO
    {
        private int ID_ESTADO;
        public int id_estado {
            get { return ID_ESTADO; }
            set { ID_ESTADO = value;  }
        }

        private string ESTADO_NOMBRE;
        public string estado_nombre {
            get { return ESTADO_NOMBRE; }
            set { ESTADO_NOMBRE = value; }
        }
    }
}
