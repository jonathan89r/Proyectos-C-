using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ONG.Modulo_EntregaIncentivos{
    public class Objeto_EntregaIncentivos{

        private int id_incentivos_entregados,id_beneficiario,id_incentivo,id_usuario;
        private DateTime fecha_entrega;

        //Propiedades 
        public int Id_incentivos_entregados{
            get{ return id_incentivos_entregados; }
            set{ id_incentivos_entregados = value; }
        }

        public int Id_beneficiario{
            get{ return id_beneficiario; }
            set{ id_beneficiario = value; }
        }

        public int Id_incentivo {
            get{ return id_incentivo; }
            set{ id_incentivo = value; }
        }

        public int Id_usuario{
            get{ return id_usuario; }
            set{ id_usuario = value; }
        }

        public DateTime Fecha_entrega{
            get { return fecha_entrega; }
            set{ fecha_entrega = value; }
        }

    }
}
