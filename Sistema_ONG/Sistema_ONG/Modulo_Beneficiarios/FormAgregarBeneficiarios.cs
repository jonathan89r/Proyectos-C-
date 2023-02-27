using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_ONG.Modulo_Beneficiarios;

namespace Sistema_ONG{

    public partial class frmBeneficiario : Form{

        public frmBeneficiario(){
            InitializeComponent();
            btnEliminar.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmBeneficiario(Int64 dui, int tipo){
            InitializeComponent();
            btnEliminar.Visible = false;
            
            Beneficiario beneficiario = BeneficiarioController.consultarBeneficiario(dui);
            if (beneficiario != null) {
                txtDui.Text = beneficiario.Dui.ToString();
                txtNombres.Text = beneficiario.Nombre;
                txtApellidos.Text = beneficiario.Apellido;
                txtDireccion.Text = beneficiario.Direccion;
                if(beneficiario.Sexo == "Femenino"){
                    rbFemenino.Checked = true;
                }else{
                    rbMasculino.Checked = true;
                }
                dateNacimiento.Value = beneficiario.FechaNacimiento;
                id = beneficiario.Id;
            }
            if(tipo == 0){
                btnModificar.Visible = false;
                btnLimpiar.Visible = false;
                btnEliminar.Visible = true;
                txtNombres.Enabled = false;
                txtApellidos.Enabled = false;
                txtDireccion.Enabled = false;
                txtDui.Enabled = false;
                dateNacimiento.Enabled = false;
                rbFemenino.Enabled = false;
                rbMasculino.Enabled = false;
            }else{
                btnModificar.Visible = true;
                btnEliminar.Visible = false;
            }
        }
        public int id { set; get; }

        private void FormBeneficiario_Load(object sender, EventArgs e){
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void cerrarForm(object sender, EventArgs e){
            frmConsultarBeneficiario beneficiario = new frmConsultarBeneficiario();
            this.Hide();
            beneficiario.Show();
            
        }

        public void limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            dateNacimiento.Value = DateTime.Now;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e){
            if (MessageBox.Show("¿Esta seguro que desea eliminar el beneficiario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                int registro = BeneficiarioController.Eliminar(id);
                if (registro == 1)//Validar errores de guardado
                    MessageBox.Show("Datos Eliminados con Exito", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("No fue posible Eliminar los datos", "Error al Eliminar los Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e){
            string sexo = "";
            Beneficiario b = new Beneficiario();

            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtDui.Text != "" && txtDireccion.Text != "" && (rbMasculino.Checked != false || rbFemenino.Checked != false)){
                b.Nombre = txtNombres.Text;
                b.Apellido = txtApellidos.Text;
                b.Dui = int.Parse(txtDui.Text);
                b.Direccion = txtDireccion.Text;
                b.FechaNacimiento = dateNacimiento.Value;
                if (rbMasculino.Checked)//Validar sexo
                    sexo = "Masculino";
                else
                {
                    if (rbFemenino.Checked)
                        sexo = "Femenino";
                }
                b.Sexo = sexo;
                b.Id = id;
                int registro = BeneficiarioController.Modificar(b);
                if (registro == 1)//Validar errores de guardado
                    MessageBox.Show("Datos Actualizados con Exito", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No fue posible Actualizar los datos", "Error al Guardar los Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }else{
                MessageBox.Show("Debe llenar todos los campos", "Error al Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e){
            limpiar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e){
            string sexo = "";
            //Objeto beneficiario
            Beneficiario b = new Beneficiario();
            //Ingresar datos al objeto

            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtDui.Text != "" && txtDireccion.Text != "" && (rbMasculino.Checked != false || rbFemenino.Checked != false)){
                b.Nombre = txtNombres.Text;
                b.Apellido = txtApellidos.Text;
                b.Dui = int.Parse(txtDui.Text);
                b.Direccion = txtDireccion.Text;
                b.FechaNacimiento = dateNacimiento.Value;
                if (rbMasculino.Checked)//Validar sexo
                    sexo = "Masculino";
                else{
                    if (rbFemenino.Checked)
                        sexo = "Femenino";
                }
                b.Sexo = sexo;
                //Registrar datos en la base de datos
                int registro = BeneficiarioController.AgregarBeneficiario(b);

                if (registro == 1)//Validar errores de guardado
                    MessageBox.Show("Datos Guardado con Exito", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No fue posible guardar los datos, el DUI ya esta registrado", "Error al Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }else{
                MessageBox.Show("Debe llenar todos los campos", "Error al Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e){
            //ConsultarBeneficiario beneficiario = new ConsultarBeneficiario();
            this.Close();
        }
    }
}
