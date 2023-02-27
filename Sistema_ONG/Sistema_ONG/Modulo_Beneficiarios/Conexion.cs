using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_ONG.Modulo_Beneficiarios{
    class Conexion{

        public static SqlConnection Conectar(){
            SqlConnection cn = new SqlConnection("Data Source=CASA;Initial Catalog=BD_SISTEMA_ONG;Integrated Security=True");
            cn.Open();
            return cn;
        }

    }
}
