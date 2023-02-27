using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using Sistema_ONG.Modulo_Beneficiarios;
using System.Drawing;

namespace Sistema_ONG.Modulo_FondosIncentivos{
    class Clase_FondosIncentivos:UtilidadesClases{

        //Consulta para llenar datagrid
        public DataTable mostrarDatosFondos(){
            string sql = "select Id_Fondo_Incentivo as \"Id\", Fondo_Incentivo as \"Nombre del fondo\" from Tabla_Fondo_Incentivo";
            return obtenerDatos(CadenaConexion,sql);
        }

        /*
            - Insercion
            - Eliminacion
            - Actualizacion
         */
        public bool insertarDatos(string fondo){
            bool flag = false;
            try{

                Console.WriteLine("[insertarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Tabla_Fondo_Incentivo (Fondo_Incentivo) values ( '"+fondo+"')", sqlConnection);

                    if (cmd.ExecuteNonQuery() > 0) {
                        flag = true;
                        Console.WriteLine("[insertarDatos] inserccion exitosa..");
                    }
                }

            }catch (SqlException ex){
                Console.WriteLine("[insertarDatos] Error: " + ex.Message);
                MessageBox.Show("Error al conectarse a la base de datos.. ");
            }
            return flag;
        }

        public bool eliminarDatos(int id) {
            bool flag = false;
            try{

                Console.WriteLine("[eliminarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("delete from Tabla_Fondo_Incentivo where Id_Fondo_Incentivo='"+id+"'", sqlConnection);

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

        public bool ActualizarDatos(int id, string fondo){
            bool flag = false;
            try{

                Console.WriteLine("[ActualizarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("update Tabla_Fondo_Incentivo set Fondo_Incentivo='"+fondo+"' where Id_Fondo_Incentivo='"+id+"'", sqlConnection);

                    if (cmd.ExecuteNonQuery() > 0){
                        flag = true;
                        Console.WriteLine("[ActualizarDatos] actualizacion exitosa..");
                    }
                }

            }catch (SqlException ex){
                Console.WriteLine("[ActualizarDatos] Error: " + ex.Message);
                MessageBox.Show("Error al conectarse a la base de datos.. ");
            }
            return flag;
        }

    }
}
