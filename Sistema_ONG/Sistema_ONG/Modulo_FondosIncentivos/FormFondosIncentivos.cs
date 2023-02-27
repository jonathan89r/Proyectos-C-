using Sistema_ONG.Modulo_EntregaIncentivos;
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
using System.Runtime.CompilerServices;
using System.Net.NetworkInformation;
using Sistema_ONG.Modulo_Beneficiarios;

namespace Sistema_ONG.Modulo_FondosIncentivos{
    public partial class frmFondosIncentivos : Form{

        private Clase_FondosIncentivos clase_FondosIncentivos = new Clase_FondosIncentivos();
        private UtilidadesClases utilidadesClases = new UtilidadesClases();

        public frmFondosIncentivos(){
            InitializeComponent();
            mostrarDatos();
            utilidadesClases.mostrarFecha(lblFecha, lblHora);
        }

        /*
         * Metodos para mostrar datos, combobox, datagrid... etc
         */
        public void mostrarDatos()
        {
            dtgFondosIncentivos.DataSource = clase_FondosIncentivos.mostrarDatosFondos();

            //No se muestran filas donde se muestran los ids
            dtgFondosIncentivos.Columns[0].Visible = false;
        }

        /*
         * Metodos para guardar, actualizar y eliminar
         */
        private void btnGuardar_Click(object sender, EventArgs e){

            Console.WriteLine("fondo: " + txtFondo.Text);
            string fondo = Convert.ToString(txtFondo.Text);

            //Valida si el registro fue guardado, sino se brinda error
            if (clase_FondosIncentivos.insertarDatos(fondo)){
                MessageBox.Show("Registro guardado exitosamente", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                MessageBox.Show("No se pudo guardar el registro", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Recarga la vista de la gridview
            mostrarDatos();
            txtFondo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e){
            string id = Convert.ToString(dtgFondosIncentivos.CurrentRow.Cells["Id"].Value);
            string fondo = Convert.ToString(dtgFondosIncentivos.CurrentRow.Cells["Nombre del fondo"].Value);

            txtFondo.Text = fondo;
            txtId.Text = id;

            btnLlenarDatos.Visible = false;
            btnGuardar.Visible = false;
            txtFondo.Clear();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e){

            int id = Convert.ToInt32(txtId.Text);
            string fondo = Convert.ToString(txtFondo.Text);

            if (clase_FondosIncentivos.ActualizarDatos(id, fondo)){
                MessageBox.Show("Registro actualizado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFondo.Clear();
                btnLlenarDatos.Visible = true;
                btnGuardar.Visible = true;
            }else{
                MessageBox.Show("No se pudo actualizar el registro", "Ocurrió un error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Recarga la vista de la gridview
            mostrarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e){

            //Validar si se ha seleccionado una fila se brinda un error en pantalla
            if (dtgFondosIncentivos.CurrentRow != null){

                //Se captura el id de la fila a eliminar
                int id = Convert.ToInt32(dtgFondosIncentivos.CurrentRow.Cells["Id"].Value);
                Console.WriteLine("id: " + id);

                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){

                    if (clase_FondosIncentivos.eliminarDatos(id)){
                        MessageBox.Show("Registro eliminado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else{
                        MessageBox.Show("No se pudo Eliminar el registro", "Ocurrió un error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }else
                    MessageBox.Show("Se canceló el proceso de eliminación", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Recarga la vista de la gridview
                mostrarDatos();
            }
        }

        /*
         Redireccionamiento a los diferentes menus
         */
        private void btnFondos_Click(object sender, EventArgs e){
            frmFondosIncentivos obj = new frmFondosIncentivos();
            this.Hide();
            obj.Show();
        }

        private void btnIncentivos_Click(object sender, EventArgs e){
            frmIncentivos obj = new frmIncentivos();
            obj.Show();
            this.Hide();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e){
            frmConsultarBeneficiario obj = new frmConsultarBeneficiario();
            this.Hide();
            obj.Show();
        }

        private void btnIncentivosEntregados_Click(object sender, EventArgs e){
            frmIncentivosEntregados obj = new frmIncentivosEntregados();
            this.Hide();
            obj.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e){
            frmUsuarios obj = new frmUsuarios();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e){
            frmMenu menus = new frmMenu();
            this.Hide();
            menus.Show();
        }
    }
}
