using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Sistema_ONG.Modulo_EntregaIncentivos{

    class Clase_Incentivos:UtilidadesClases{

        //Consulta para llenar datagrid
        public DataTable mostrarDatosIncentivos(){
            string sql = "select Id_Incentivo,Nombre_Incentivo as \"Nombre\",Descripcion_Incentivo as \"Descripcion\",incent.Id_Fondo_Incentivo, fincent.Fondo_Incentivo as \"Fondo de origen\" from Tabla_Incentivos incent inner join Tabla_Fondo_Incentivo fincent on incent.Id_Fondo_Incentivo = fincent.Id_Fondo_Incentivo";
            return obtenerDatos(CadenaConexion,sql);
        }

        //Consulta para llenar combobox de fondos de origen por un id
        public DataTable mostrarDatosFondosById(int id){
            string sql = "select Id_Fondo_Incentivo, Fondo_Incentivo as \"Nombre\" from Tabla_Fondo_Incentivo where Id_Fondo_Incentivo = '"+id+"' union  select Id_Fondo_Incentivo, Fondo_Incentivo as \"Nombre\" from Tabla_Fondo_Incentivo where Id_Fondo_Incentivo not in ('"+id+"')";
            return obtenerDatos(CadenaConexion, sql);
        }

        //Consulta para llenar combobox de todos los fondos de origen
        public DataTable mostrarDatosFondos(){
            string sql = "select Id_Fondo_Incentivo, Fondo_Incentivo as \"Nombre\" from Tabla_Fondo_Incentivo";
            return obtenerDatos(CadenaConexion, sql);
        }

        /*
         Ejecucion de procedimientos almacenados: 
            - Insercion
            - Eliminacion
            - Actualizacion
         */
        public bool insertarDatos(string nombreIncentivo, string descripcionIncentivo, int idFondo){
            bool flag = false;
            try{

                Console.WriteLine("[insertarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("guardarIncentivo", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre_Incentivo", nombreIncentivo);
                    cmd.Parameters.AddWithValue("@Descripcion_Incentivo", descripcionIncentivo);
                    cmd.Parameters.AddWithValue("@Id_Fondo_Incentivo", idFondo);

                    if (cmd.ExecuteNonQuery() > 0) {
                        flag = true;
                        Console.WriteLine("[insertarDatos] inserccion exitosa..");
                    }
                }

            }catch (SqlException ex){
                Console.WriteLine("[insertarDatos] Error: " + ex.Message);
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

                    SqlCommand cmd = new SqlCommand("eliminarIncentivo", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

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

        public bool ActualizarDatos(int idIncentivo, string nombreIncentivo, string descripcionIncentivo, int idFondo){
            bool flag = false;
            try{

                Console.WriteLine("[ActualizarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("actualizarIncentivo", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Incentivo", idIncentivo);
                    cmd.Parameters.AddWithValue("@Nombre_Incentivo", nombreIncentivo);
                    cmd.Parameters.AddWithValue("@Descripcion_Incentivo", descripcionIncentivo);
                    cmd.Parameters.AddWithValue("@Id_Fondo_Incentivo", idFondo);

                    if (cmd.ExecuteNonQuery() > 0){
                        flag = true;
                        Console.WriteLine("[ActualizarDatos] actualizacion exitosa..");
                    }
                }

            }catch (SqlException ex){
                Console.WriteLine("[ActualizarDatos] Error: " + ex.Message);
            }
            return flag;
        }

    }
}
