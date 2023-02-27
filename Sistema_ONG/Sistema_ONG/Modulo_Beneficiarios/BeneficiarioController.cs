using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_ONG.Modulo_Beneficiarios{
    class BeneficiarioController{

        //Devolver todos los beneficiarios
        public static List<Beneficiario> ListaBeneficiarios(){
            List<Beneficiario> beneficiarioList = new List<Beneficiario>();

            using (SqlConnection conexion = Conexion.Conectar()){
                SqlCommand cmd = new SqlCommand(String.Format("Select Nombre, Apellido, Numero_DUI, Fecha_Nacimiento, Sexo_Beneficiario, Direccion_Beneficiario from Tabla_Beneficiarios "), conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    Beneficiario beneficiario = new Beneficiario();
                    beneficiario.Nombre = reader.GetString(0);
                    beneficiario.Apellido = reader.GetString(1);
                    beneficiario.Dui = reader.GetInt32(2);
                    beneficiario.FechaNacimiento = reader.GetDateTime(3);
                    beneficiario.Sexo = reader.GetString(4);
                    beneficiario.Direccion = reader.GetString(5);
                    beneficiarioList.Add(beneficiario);
                }
                conexion.Close();
                return beneficiarioList;
            }
        }

        //Buscar un beneficiario
        public static List<Beneficiario> Buscar(int dui){
            List<Beneficiario> beneficiarioList = new List<Beneficiario>();

            using (SqlConnection conexion = Conexion.Conectar()){
                SqlCommand cmd = new SqlCommand(String.Format(
                "Select Nombre, Apellido, Numero_DUI, Fecha_Nacimiento, Sexo_Beneficiario, Direccion_Beneficiario from Tabla_Beneficiarios where Numero_DUI like '%{0}%'", dui), conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    Beneficiario beneficiario = new Beneficiario();
                    beneficiario.Nombre = reader.GetString(0);
                    beneficiario.Apellido = reader.GetString(1);
                    beneficiario.Dui = reader.GetInt32(2);
                    beneficiario.FechaNacimiento = reader.GetDateTime(3);
                    beneficiario.Sexo = reader.GetString(4);
                    beneficiario.Direccion = reader.GetString(5);
                    beneficiarioList.Add(beneficiario);
                }
                conexion.Close();
                return beneficiarioList;
            }
        }

        //Consultar un beneficiario
        public static Beneficiario consultarBeneficiario(Int64 dui){
            using (SqlConnection conexion = Conexion.Conectar()){
                Beneficiario beneficiario = new Beneficiario();
                SqlCommand cmd = new SqlCommand(String.Format(
                "Select Id_Beneficiario, Nombre, Apellido, Numero_DUI, Fecha_Nacimiento, Sexo_Beneficiario, Direccion_Beneficiario from Tabla_Beneficiarios where Numero_DUI={0}", dui), conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    beneficiario.Id = reader.GetInt32(0);
                    beneficiario.Nombre = reader.GetString(1);
                    beneficiario.Apellido = reader.GetString(2);
                    beneficiario.Dui = reader.GetInt32(3);
                    beneficiario.FechaNacimiento = reader.GetDateTime(4);
                    beneficiario.Sexo = reader.GetString(5);
                    beneficiario.Direccion = reader.GetString(6);
                }
                conexion.Close();
                return beneficiario;
            }
        }

        //Funcion para agregar un beneficiario a la base de datos
        public static int AgregarBeneficiario(Beneficiario beneficiario){
            int retorno = 0;
            int idUsuario = 1;
            try{
                using (SqlConnection con = Conexion.Conectar()){
                 //Establecer conexion con la base de datos
                 //Insertar un nuevo objeto en la base de datos
                    SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Tabla_Beneficiarios (Nombre, Apellido, " +
                        "Numero_DUI, Fecha_Nacimiento, Sexo_Beneficiario, Direccion_Beneficiario," +
                        "Id_Usuario) values ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                        beneficiario.Nombre, beneficiario.Apellido, beneficiario.Dui, beneficiario.FechaNacimiento,
                        beneficiario.Sexo, beneficiario.Direccion, idUsuario), con);

                    retorno = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }catch (SqlException){
                retorno = 2;
            }

            return retorno;
        }

        //Funcion para modificar
        public static int Modificar(Beneficiario beneficiario){
            int retorno = 0;

            using (SqlConnection con = Conexion.Conectar()){
                SqlCommand cmd = new SqlCommand(String.Format("Update Tabla_Beneficiarios set Nombre='{0}', Apellido='{1}', Numero_DUI='{2}', " +
                    "Fecha_Nacimiento='{3}', Sexo_Beneficiario='{4}', Direccion_Beneficiario='{5}' where Id_Beneficiario={6}", beneficiario.Nombre, beneficiario.Apellido, beneficiario.Dui,
                    beneficiario.FechaNacimiento, beneficiario.Sexo, beneficiario.Direccion, beneficiario.Id), con);
                retorno = cmd.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        //Funcion para elimiar 
        public static int Eliminar(Int64 id){
            int retorno = 0;
            using (SqlConnection con = Conexion.Conectar()){
                SqlCommand cmd = new SqlCommand(string.Format("Delete from Tabla_Beneficiarios where Id_Beneficiario={0}", id), con);
                retorno = cmd.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

    }
}
