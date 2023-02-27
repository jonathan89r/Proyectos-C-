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
    class Clase_EntregaIncentivos:UtilidadesClases{

        //Consulta para llenar datagrid
        public DataTable mostrarDatosIncentivosEntregados(){
            string sql = "select t3.Id_Incentivo_Entregado as \"Id\", t3.Id_Beneficiario, CONCAT(t4.Nombre,' ', t4.Apellido) as \"Nombre del beneficiario\", t3.Id_Incentivo, t2.Descripcion_Incentivo as \"Incentivo\", t4.Numero_DUI as \"Numero de documento\", t3.Fecha_Entrega as \"Fecha a entregar\", t4.Direccion_Beneficiario as \"Direccion registrada\" from Tabla_Fondo_Incentivo t1 inner join Tabla_Incentivos t2 on t1.Id_Fondo_Incentivo = t2.Id_Fondo_Incentivo inner join Tabla_Incentivos_Entregados t3 on t3.Id_Incentivo = t2.Id_Incentivo inner join Tabla_Beneficiarios t4 on t4.Id_Beneficiario = t3.Id_Beneficiario order by t3.Fecha_Entrega desc";
            return obtenerDatos(CadenaConexion,sql);
        }

        //Consulta para llenar combobox de incentivos
        public DataTable mostrarDatosIncentivos(){
            string sql = "select Id_Incentivo as \"Id\", Descripcion_Incentivo as \"Incentivo\" from Tabla_Incentivos";
            return obtenerDatos(CadenaConexion,sql);
        }

        //Consulta para llenar combobox de beneficiarios
        public DataTable mostrarDatosBeneficiarios() {
            string sql = "select Id_Beneficiario as \"Id\", CONCAT(Nombre,' ',Apellido) as \"Nombre del beneficiario\" from Tabla_Beneficiarios";
            return obtenerDatos(CadenaConexion,sql);
        }

        //Consulta para mostrar por id incentivos entregados
        public DataTable mostrarDatosIncentivosById(int id){
            string sql = "select Id_Incentivo as \"Id\", Descripcion_Incentivo as \"Incentivo\" from Tabla_Incentivos where Id_Incentivo='"+id+ "' union select Id_Incentivo as \"Id\", Descripcion_Incentivo as \"Incentivo\" from Tabla_Incentivos where Id_Incentivo not in ('" + id+"')";
            return obtenerDatos(CadenaConexion, sql);
        }

        //Consulta para mostrar por id beneficiarios
        public DataTable mostrarDatosBeneficiariosById(int id){
            string sql = "select Id_Beneficiario as \"Id\", CONCAT(Nombre,' ',Apellido) as \"Nombre del beneficiario\" from Tabla_Beneficiarios where Id_Beneficiario='"+id+"' union select Id_Beneficiario as \"Id\", CONCAT(Nombre,' ',Apellido) as \"Nombre del beneficiario\" from Tabla_Beneficiarios where Id_Beneficiario not in ('"+id+"')";
            return obtenerDatos(CadenaConexion, sql);
        }

        /*
         Ejecucion de procedimientos almacenados: 
            - Insercion
            - Eliminacion
            - Actualizacion
         */
        public bool insertarDatos(int idBeneficiario, int idIncentivo, DateTime fechaEntrega){
            bool flag = false;
            try{

                Console.WriteLine("[insertarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("guardarIncentivoEntregado", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Beneficiario", idBeneficiario);
                    cmd.Parameters.AddWithValue("@Id_Incentivo", idIncentivo);
                    cmd.Parameters.AddWithValue("@Fecha_Entrega", fechaEntrega);

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

                    SqlCommand cmd = new SqlCommand("eliminarIncentivoEntregado", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    if (cmd.ExecuteNonQuery() > 0){
                        flag = true;
                        Console.WriteLine("[eliminarDatos] eliminacion exitosa..");
                    }
                }

            }catch (SqlException ex){
                Console.WriteLine("[eliminarDatos] Error: " + ex.Message);
                MessageBox.Show("Error al conectarse a la base de datos.. ");
            }
            return flag;
        }

        public bool ActualizarDatos(int id, int idBeneficiario, int idIncentivo, DateTime fechaEntrega){
            bool flag = false;
            try{

                Console.WriteLine("[ActualizarDatos] url conexion: " + CadenaConexion);
                using (SqlConnection sqlConnection = new SqlConnection(CadenaConexion)){
                    sqlConnection.Open();

                    if (sqlConnection.State != ConnectionState.Open){
                        MessageBox.Show("Problemas al obtener conexion");
                        return flag;
                    }

                    SqlCommand cmd = new SqlCommand("actualizarIncentivoEntregado", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Incentivo_Entregado", id);
                    cmd.Parameters.AddWithValue("@Id_beneficiario", idBeneficiario);
                    cmd.Parameters.AddWithValue("@Id_Incentivo", idIncentivo);
                    cmd.Parameters.AddWithValue("@Fecha_Entrega", fechaEntrega);

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
