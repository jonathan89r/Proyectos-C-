using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_ONG
{
    class UtilidadesClases {

        private string cadenaConexion = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public UtilidadesClases(){
            
        }

        public string CadenaConexion{
            get { return cadenaConexion; }
        }

        public DataTable obtenerDatos(string cadenaConexion, string query){
            DataTable dt = new DataTable();
            try{

                Console.WriteLine("\n[obtenerDatos] url conexion: " + cadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                    }

                    Console.WriteLine("[obtenerDatos] Conexion exitosa a DB");
                    Console.WriteLine("[obtenerDatos] consulta sql: " + query);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(dt);
                }
                Console.WriteLine("[obtenerDatos] cantidad de registros obtenido: " + dt.Rows.Count + "\n");
            }catch (SqlException ex){
                Console.WriteLine("[obtenerDatos] Error: " + ex.Message);
                MessageBox.Show("Error al conectarse a la base de datos.. ");
            }
            return dt;
        }

        public void mostrarFecha(Label lblFecha, Label lblHora){
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

    }
}
