using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_ONG.Modulo_FondosIncentivos;
using Sistema_ONG.Modulo_Usuarios;

namespace Sistema_ONG.Modulo_Usuarios{
    public partial class frmUsuarios : Form{

        private UtilidadesClases utilidadesClases = new UtilidadesClases();
        private Clase_Usuario obj = new Clase_Usuario();

        public frmUsuarios(){
            InitializeComponent();
            utilidadesClases.mostrarFecha(lblFecha, lblHora);
            mostrarDatos();
        }

        internal static void show(){
            throw new NotImplementedException();
        }

        public int id_usuario, tipo_usuario;
        public void mostrarDatos(){
            Clase_Usuario obj = new Clase_Usuario();
            DGW_Users.DataSource = obj.Mostrarusuarios();
            DGW_Users.Columns[0].Visible = false;
            DGW_Users.Columns[8].Visible = false;
        }

        public void mostrardatosusuario(){
            this.cmb_tipo_usuario.DataSource = obj.mostrarDatostipousuario();
            this.cmb_tipo_usuario.ValueMember = "ID_TIPO_USUARIO";
            this.cmb_tipo_usuario.DisplayMember = "TIPO_USUARIO";
        }

        private void DGW_Users_CellContentClick(object sender, DataGridViewCellEventArgs e){
            DateTime fecha_naci;
            id_usuario = Convert.ToInt32(DGW_Users.SelectedCells[0].Value.ToString());
            this.txt_Nombre_Empleado.Text = DGW_Users.SelectedCells[1].Value.ToString();
            this.txtApellido_Empleado.Text = DGW_Users.SelectedCells[2].Value.ToString();
            fecha_naci = Convert.ToDateTime(DGW_Users.SelectedCells[3].Value.ToString());
            this.datepicker_fecha_nacimiento.Text = fecha_naci.ToString("dd/MM/yyyy");
            this.combob_Sexo.Text = DGW_Users.SelectedCells[4].Value.ToString();
            this.txt_direccion_empleado.Text = DGW_Users.SelectedCells[5].Value.ToString();
            this.txt_nombre_usuario.Text = DGW_Users.SelectedCells[6].Value.ToString();
            this.masktbox_password.Text = DGW_Users.SelectedCells[7].Value.ToString();
            tipo_usuario = Convert.ToInt32(DGW_Users.SelectedCells[8].Value.ToString());
            this.cmb_tipo_usuario.Text = DGW_Users.SelectedCells[9].Value.ToString();
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e){
            this.btn_nuevo.Visible = false;
            this.btn_guardar.Visible = true;

            this.txt_Nombre_Empleado.Text = "";
            this.txtApellido_Empleado.Text = "";
            this.datepicker_fecha_nacimiento.Value = DateTime.Now;
            this.combob_Sexo.Text = "";
            this.txt_direccion_empleado.Text = "";
            this.txt_nombre_usuario.Text = "";
            this.masktbox_password.Text = "";
            this.cmb_tipo_usuario.Text = "";
        }


        //BOTON PARA MODIFICAR USUARIO
        private void btn_modificar_Click_1(object sender, EventArgs e){
            Clase_Usuario modificar_usuario = new Clase_Usuario();
            int id = this.id_usuario; ;
            string nombreempleado = this.txt_Nombre_Empleado.Text;
            string apellidoempleado = this.txtApellido_Empleado.Text;
            DateTime fechanacimiento = Convert.ToDateTime(this.datepicker_fecha_nacimiento.Value.Date.ToString("yyyy-MM-dd"));
            string sexoempleado = Convert.ToString(this.combob_Sexo.SelectedItem);
            string direccionempleado = this.txt_direccion_empleado.Text;
            string nombreusuario = this.txt_nombre_usuario.Text;
            string passwordusuario = this.masktbox_password.Text;
            int id_tipousuario = 1 + Convert.ToInt32(this.cmb_tipo_usuario.SelectedIndex);

            if (modificar_usuario.ActualizarUsuarios(id, nombreempleado, apellidoempleado, fechanacimiento,
               sexoempleado, direccionempleado, nombreusuario, passwordusuario,
               id_tipousuario)){
               MessageBox.Show("Registro actualizado exitosamente", "Registro actualizado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                MessageBox.Show("No se pudo actualizar el registro", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        //BOTON PARA ELIMINAR
        private void btn_eliminar_Click_1(object sender, EventArgs e){
            Clase_Usuario eliminar_usuario = new Clase_Usuario();
            if (this.DGW_Users.CurrentRow != null){

                //Se captura el id de la fila a eliminar
                int id = Convert.ToInt32(this.DGW_Users.SelectedCells[0].Value.ToString());
                Console.WriteLine("idusuario: " + id);

                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){

                    if (eliminar_usuario.EliminarUsuario(id)){
                        MessageBox.Show("Registro eliminado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        this.txt_Nombre_Empleado.Text = "";
                        this.txtApellido_Empleado.Text = "";
                        this.datepicker_fecha_nacimiento.Value = DateTime.Now;
                        this.combob_Sexo.Text = "";
                        this.txt_direccion_empleado.Text = "";
                        this.txt_nombre_usuario.Text = "";
                        this.masktbox_password.Text = "";
                        this.cmb_tipo_usuario.Text = "";

                        //Recarga la vista de la gridview
                        mostrarDatos();


                    }else{
                        MessageBox.Show("No se pudo Eliminar el registro", "Ocurrió un error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }else
                    MessageBox.Show("Se canceló el proceso de eliminación", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BOTON PARA GUARDAR NUEVO
        private void btn_guardar_Click_1(object sender, EventArgs e){
            Clase_Usuario guardar_usuario = new Clase_Usuario();
            string nombre_empleado = this.txt_Nombre_Empleado.Text;
            string apellido_empleado = this.txtApellido_Empleado.Text;
            DateTime fecha_nacimi = Convert.ToDateTime(this.datepicker_fecha_nacimiento.Value.Date.ToString("yyyy-MM-dd"));
            string sexo = Convert.ToString(this.combob_Sexo.SelectedItem);
            string direccion_empleado = this.txt_direccion_empleado.Text;
            string nombre_usuario = this.txt_nombre_usuario.Text;
            string password_usuario = this.masktbox_password.Text;
            int id_tipo_usuario = 1 + Convert.ToInt32(this.cmb_tipo_usuario.SelectedIndex);

            if (guardar_usuario.insertarDatosUsuarios(nombre_empleado, apellido_empleado, fecha_nacimi, sexo, direccion_empleado, nombre_usuario, password_usuario, id_tipo_usuario)){
                MessageBox.Show("Registro guardado exitosamente.", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarDatos();

                this.btn_nuevo.Visible = true;
                this.btn_guardar.Visible = false;

                this.txt_Nombre_Empleado.Text = "";
                this.txtApellido_Empleado.Text = "";
                this.datepicker_fecha_nacimiento.Value = DateTime.Now;
                this.combob_Sexo.Text = "";
                this.txt_direccion_empleado.Text = "";
                this.txt_nombre_usuario.Text = "";
                this.masktbox_password.Text = "";
                this.cmb_tipo_usuario.Text = "";

            }else{
                MessageBox.Show("No se pudo guardar el registro.", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e){
            frmUsuarios obj = new frmUsuarios();
            this.Hide();
            obj.Show();
        }

        private void btnIncentivos_Click(object sender, EventArgs e){
            frmIncentivos obj = new frmIncentivos();
            this.Hide();
            obj.Show();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e){
            frmBeneficiario obj = new frmBeneficiario();
            this.Hide();
            obj.Show();
        }

        private void btnIncentivosEntregados_Click(object sender, EventArgs e){
            frmIncentivosEntregados obj = new frmIncentivosEntregados();
            this.Hide();
            obj.Show();
        }

        private void btnFondos_Click(object sender, EventArgs e){
            frmFondosIncentivos obj = new frmFondosIncentivos();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e){
            frmMenu menus = new frmMenu();
            this.Hide();
            menus.Show();
        }

        private void frmUsuarios_Load(object sender, EventArgs e){
            mostrarDatos();
            this.btn_guardar.Visible = false;
        }

    }
}
