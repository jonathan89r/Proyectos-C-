using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_ONG.Modulo_Usuarios;

namespace Sistema_ONG{
    public partial class login : Form{

        public login(){
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e){
            int dato;
            Clase_Usuario acceso = new Clase_Usuario();
            acceso.nombreusuario = txtUsuario.Text;
            acceso.passwordusuario = txtPassword.Text;
            dato = Convert.ToInt32(acceso.loguear().Rows.Count.ToString());
            if (dato == 1){
                MessageBox.Show("BIENVENIDO AL SISTEMA", "MENSAJE DE BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }else{
                MessageBox.Show("Error al ingresa el Nombre de Usuario o Contraseña", "MENSAJE DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e){
            this.Close();
        }
    }
}
