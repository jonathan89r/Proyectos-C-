using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ONG.Modulo_EntregaIncentivos{
    public class Objeto_Incentivos{

        private int idIncentivo, idFondoIncentivo;
        private string nombreIncentivo, descripcionIncentivo;

        //Propiedades
        public int IdIncentivo{
            get{ return idIncentivo; }
            set{ idIncentivo = value; }
        }

        public int IdFondoIncentivo{
            get{ return idFondoIncentivo; }
            set{ idFondoIncentivo = value; }
        }

        public string NombreIncentivo{
            get{ return nombreIncentivo; }
            set{ nombreIncentivo = value; }
        }

        public string DescripcionIncentivo{
            get{ return descripcionIncentivo; }
            set{ descripcionIncentivo = value; }
        }

    }
}
