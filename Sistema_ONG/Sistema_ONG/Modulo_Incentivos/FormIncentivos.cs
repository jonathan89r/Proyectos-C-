using Sistema_ONG.Modulo_EntregaIncentivos;
using System;
using System.Windows.Forms;
using Sistema_ONG.Modulo_Usuarios;
using Sistema_ONG.Modulo_FondosIncentivos;

namespace Sistema_ONG{
    public partial class frmIncentivos : Form {

        private Clase_Incentivos clase_Incentivos = new Clase_Incentivos();
        private UtilidadesClases utilidadesClases = new UtilidadesClases();

        public frmIncentivos() {
            InitializeComponent();
            mostrarDatos();
            mostrarFondos();
            utilidadesClases.mostrarFecha(lblFecha, lblHora);
        }

        /*
         * Metodos para mostrar datos, combobox, datagrid... etc
         */
        public void mostrarDatos() {
            dtgIncentivos.DataSource = clase_Incentivos.mostrarDatosIncentivos();

            //No se muestran filas donde se muestran los ids
            dtgIncentivos.Columns[0].Visible = false;
            dtgIncentivos.Columns[3].Visible = false;
        }

        public void mostrarFondos() {
            cboFondo.DataSource = clase_Incentivos.mostrarDatosFondos();

            //Son los nombres que son retornados en la consulta SQL
            cboFondo.ValueMember = "Id_Fondo_Incentivo";
            cboFondo.DisplayMember = "Nombre";
        }

        /*
         * Metodos para guardar, actualizar y eliminar
         */
        private void btnGuardar_Click(object sender, EventArgs e) {
            Console.WriteLine("Nombre incentivo: " + txtNombreIncentivo.Text);
            Console.WriteLine("Descripcion: " + richDescripcionIncentivo.Text);
            Console.WriteLine("Fondo: " + cboFondo.SelectedValue);

            string nombreIncentivo = txtNombreIncentivo.Text;
            string descripcionIncentivo = richDescripcionIncentivo.Text;
            int idFondo = Convert.ToInt32(cboFondo.SelectedValue);

            //Valida si el registro fue guardado, sino se brinda error
            if (clase_Incentivos.insertarDatos(nombreIncentivo, descripcionIncentivo, idFondo)) {
                MessageBox.Show("Registro guardado exitosamente.", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("No se pudo guardar el registro.", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Recarga la vista de la gridview
            mostrarDatos();
            limpiar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e) {
            //Validar si se ha seleccionado una fila se brinda un error en pantalla
            if (dtgIncentivos.CurrentRow != null) {

                //Se captura el id de la fila a eliminar
                int id = Convert.ToInt32(dtgIncentivos.CurrentRow.Cells["Id_Incentivo"].Value);
                Console.WriteLine("Id_Incentivo: " + id);

                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    if (clase_Incentivos.eliminarDatos(id)) {
                        MessageBox.Show("Registro eliminado correctamente.", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("No se pudo Eliminar el registro, favor verificar que el dato no este siendo utilizado.", "Ocurrió un error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se canceló el proceso de eliminación.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Recarga la vista de la gridview
            mostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (dtgIncentivos.CurrentRow != null) {

                Objeto_Incentivos objeto_Incentivos = new Objeto_Incentivos();
                objeto_Incentivos.IdIncentivo = Convert.ToInt32(dtgIncentivos.CurrentRow.Cells["Id_Incentivo"].Value);
                objeto_Incentivos.NombreIncentivo = Convert.ToString(dtgIncentivos.CurrentRow.Cells["Nombre"].Value);
                objeto_Incentivos.DescripcionIncentivo = Convert.ToString(dtgIncentivos.CurrentRow.Cells["Descripcion"].Value);
                objeto_Incentivos.IdFondoIncentivo = Convert.ToInt32(dtgIncentivos.CurrentRow.Cells["Id_Fondo_Incentivo"].Value);

                Console.WriteLine("\n[btnModificar_Click antes de modificar] IdIncentivo: " + objeto_Incentivos.IdIncentivo);
                Console.WriteLine("[btnModificar_Click antes de modificar] NombreIncentivo: " + objeto_Incentivos.NombreIncentivo);
                Console.WriteLine("[btnModificar_Click antes de modificar] DescripcionIncentivo: " + objeto_Incentivos.DescripcionIncentivo);
                Console.WriteLine("[btnModificar_Click antes de modificar] IdFondoIncentivo: " + objeto_Incentivos.IdFondoIncentivo);

                this.Hide();
                frmIncentivosModificar formIncentivosModificar = new frmIncentivosModificar();
                formIncentivosModificar.recibirDatosMostrarActualizacion(objeto_Incentivos);
                formIncentivosModificar.ShowDialog();

            } else {
                MessageBox.Show("Favor seleccione una fila para poder hacer la modificacion...", "Comentarios");
            }

            //Recarga la vista de la gridview
            mostrarDatos();
        }

        /*
         Redireccionamiento a los diferentes menus
         */
        private void btnMenu_Click(object sender, EventArgs e){
            frmMenu menus = new frmMenu();
            this.Hide();
            menus.Show();
        }

        private void btnIncentivosEntregados_Click(object sender, EventArgs e){
            frmIncentivosEntregados obj = new frmIncentivosEntregados();
            this.Hide();
            obj.Show();
        }

        private void btnIncentivos_Click(object sender, EventArgs e){
            frmIncentivos obj = new frmIncentivos();
            obj.Show();
            this.Hide();
        }

        private void btnBeneficiarios_Click_1(object sender, EventArgs e){
            frmConsultarBeneficiario obj = new frmConsultarBeneficiario();
            this.Hide();
            obj.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e){
            frmUsuarios obj = new frmUsuarios();
            this.Hide();
            obj.Show();
        }

        private void btnFondos_Click(object sender, EventArgs e){
            frmFondosIncentivos obj = new frmFondosIncentivos();
            this.Hide();
            obj.Show();
        }

        /*
         Metodo para limpiar formulario
         */
        private void limpiar() {
            txtNombreIncentivo.Clear();
            richDescripcionIncentivo.Clear();
            mostrarFondos();
        }
    }
}
