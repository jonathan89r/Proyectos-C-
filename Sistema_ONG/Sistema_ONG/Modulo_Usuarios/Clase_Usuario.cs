using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Sistema_ONG.Modulo_Usuarios{

    internal class Clase_Usuario:UtilidadesClases{

        private string nombre_usuario = "", password_usuario = "";

        public DataTable loguear(){
            string sql1 = "SELECT * FROM TABLA_USUARIO WHERE NOMBRE_USUARIO='" + nombreusuario + "' AND PASSWORD_USUARIO='" + passwordusuario + "'";
            return obtenerDatos(CadenaConexion, sql1);
        }

        public DataTable Mostrarusuarios(){
            //string sql = "Select * from TABLA_USUARIOS";
            string sql = "select ID_USUARIO as \"ID USUARIO\", NOMBRE_EMPLEADO as \"NOMBRE EMPLEADO\", APELLIDO_EMPLEADO as \"APELLIDO EMPLEADO\", FECHA_NACIMIENTO as \"FECHA DE NACIMIENTO\", SEXO_EMPLEADO as \"SEXO EMPLEADO\", DIRECCION_EMPLEADO as \"DIRECCION EMPLEADO\", NOMBRE_USUARIO as \"USUARIO\", PASSWORD_USUARIO as \"CONTRASEÑA\", tipo.ID_TIPO_USUARIO, tipos.TIPO_USUARIO as \"TIPO USUARIO\" from TABLA_USUARIO tipo inner join TABLA_TIPO_USUARIO tipos on tipo.ID_TIPO_USUARIO = tipos.ID_TIPO_USUARIO";
            return obtenerDatos(CadenaConexion, sql);
        }


        public DataTable mostrarDatostipousuario(){
            string sql = "select ID_TIPO_USUARIO, TIPO_USUARIO from TABLA_TIPO_USUARIO";
            return obtenerDatos(CadenaConexion, sql);
        }

        public bool ActualizarUsuarios(int id_usuario, string nombre_empleado, string apellido_empleado, DateTime fecha_nacimiento, string sexo, string direccion_empleado, string nombre_usuario, string password_usuario, int id_tipo_usuario){
            bool flag = false;
            try{

                Console.WriteLine("[ActualizarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("ActualizarUsuarios", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@nombre_empleado", nombre_empleado);
                    cmd.Parameters.AddWithValue("@apellido_empleado", apellido_empleado);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                    cmd.Parameters.AddWithValue("@sexo_empleado", sexo);
                    cmd.Parameters.AddWithValue("@direccion_empleado", direccion_empleado);
                    cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    cmd.Parameters.AddWithValue("@password_usuario", password_usuario);
                    cmd.Parameters.AddWithValue("@id_tipo_usuario", id_tipo_usuario);
                    if (cmd.ExecuteNonQuery() > 0){
                        flag = true;
                        MessageBox.Show("[ActualizarDatos] actualizacion exitosa..");
                    }
                }
            }catch (SqlException ex){
                MessageBox.Show("[ActualizarDatos] Error: " + ex.Message);
            }
            return flag;
        }

        //AGREGAR NUEVO USUARIO 
        public bool insertarDatosUsuarios(string nombre_empleado, string apellido_empleado, DateTime fecha_nacimiento, string sexo, string direccion_empleado, string nombre_usuario, string password_usuario, int id_tipo_usuario){
            bool flag = false;
            // try
            //{

            Console.WriteLine("[insertarDatosUsuarios] url conexion: " + CadenaConexion);
            using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                sqlConnection.Open();

                if (sqlConnection.State != ConnectionState.Open){
                    MessageBox.Show("Problemas al obtener conexion");
                    return flag;
                }
                SqlCommand cmd = new SqlCommand("guardarusuarios", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_empleado", nombre_empleado);
                cmd.Parameters.AddWithValue("@apellido_empleado", apellido_empleado);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                cmd.Parameters.AddWithValue("@sexo_empleado", sexo);
                cmd.Parameters.AddWithValue("@direccion_empleado", direccion_empleado);
                cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                cmd.Parameters.AddWithValue("@password_usuario", password_usuario);
                cmd.Parameters.AddWithValue("@id_tipo_usuario", id_tipo_usuario);

                if (cmd.ExecuteNonQuery() > 0){
                    flag = true;
                    Console.WriteLine("[insertarDatos] inserccion exitosa..");
                }
            }

            // }
            //catch (SqlException ex)
            //{
            //  Console.WriteLine("[insertarDatos] Error: " + ex.Message);
            // }
            return flag;
        }

        public bool EliminarUsuario(int idusuario){
            bool flag = false;
            try{

                Console.WriteLine("[EliminarUsuario] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("EliminarUsuario", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", idusuario);

                    if (cmd.ExecuteNonQuery() > 0){
                        flag = true;
                        Console.WriteLine("[eliminarDatos] eliminacion exitosa..");
                    }
                }

            }catch (SqlException ex){
                Console.WriteLine("[eliminarDatos] Error: " + ex.Message);
            }
            return flag;
        }
        public string nombreusuario{
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        public string passwordusuario{
            get{ return password_usuario; }
            set { password_usuario = value; }
        }

    }
}
