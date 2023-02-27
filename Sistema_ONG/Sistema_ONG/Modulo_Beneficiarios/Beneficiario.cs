using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ONG.Modulo_Beneficiarios{
    class Beneficiario{

        //Variables
        string nombre, apellido, sexo, direccion;
        int dui, id;
        DateTime fechaNacimiento;

        public Beneficiario(){//Constructor

        }
        //Constructor con parametros
        public Beneficiario(string nombre, string apellido, string sexo, string direccion, int dui, DateTime date){
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechaNacimiento = date;
            this.direccion = direccion;
            this.dui = dui;
        }
        public string Nombre{ 
            get{ return nombre; }
            set{
                nombre = value;
            }
        }

        public int Id { 
            get{ return id;}
            set{ id = value; }
        }

        public string Apellido{
            get{ return apellido; }
            set{ apellido = value; }
        }

        public string Sexo{
            get{ return sexo; }
            set{ sexo = value; }
        }

        public string Direccion{
            get{ return direccion; }
            set{ direccion = value; }
        }

        public int Dui{
            get{ return dui; }
            set{ dui = value; }
        }

        public DateTime FechaNacimiento{
            get{ return fechaNacimiento; }
            set{ fechaNacimiento = value; }
        }

    }
}
