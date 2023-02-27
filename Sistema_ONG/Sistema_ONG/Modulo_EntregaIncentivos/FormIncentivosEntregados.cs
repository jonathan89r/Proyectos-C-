using Sistema_ONG.Modulo_EntregaIncentivos;
using Sistema_ONG.Modulo_Beneficiarios;
using Sistema_ONG.Modulo_Usuarios;
using System;
using System.Windows.Forms;
using Sistema_ONG.Modulo_FondosIncentivos;

namespace Sistema_ONG{
    public partial class frmIncentivosEntregados : Form{

        private Clase_EntregaIncentivos clase_EntregaIncentivos = new Clase_EntregaIncentivos();
        private UtilidadesClases utilidadesClases = new UtilidadesClases();

        public frmIncentivosEntregados(){
            InitializeComponent();
            mostrarDatos();
            mostrarIncentivo();
            mostrarBeneficiario();
            utilidadesClases.mostrarFecha(lblFecha, lblHora);
        }

        /*
         * Metodos para mostrar datos, combobox, datagrid... etc
         */
        public void mostrarDatos() {
            dtgIncentivosEntregados.DataSource = clase_EntregaIncentivos.mostrarDatosIncentivosEntregados();

            //No se muestran filas donde se muestran los ids
            dtgIncentivosEntregados.Columns[0].Visible = false;
            dtgIncentivosEntregados.Columns[1].Visible = false;
            dtgIncentivosEntregados.Columns[3].Visible = false;
        }

        public void mostrarIncentivo() {
            cboIncentivo.DataSource = clase_EntregaIncentivos.mostrarDatosIncentivos();

            //Son los nombres que son retornados en la consulta SQL
            cboIncentivo.ValueMember = "Id";
            cboIncentivo.DisplayMember = "Incentivo";
        }

        public void mostrarBeneficiario(){
            cboBeneficiario.DataSource = clase_EntregaIncentivos.mostrarDatosBeneficiarios();

            //Son los nombres que son retornados en la consulta SQL
            cboBeneficiario.ValueMember = "Id";
            cboBeneficiario.DisplayMember = "Nombre del beneficiario";
        }

        /*
         * Metodos para guardar, actualizar y eliminar
         */
        private void btnGuardar_Click_1(object sender, EventArgs e){
            
            Console.WriteLine("fecha: " + cboFechaEntrega.Value);
            Console.WriteLine("beneficio: " + cboBeneficiario.SelectedValue);
            Console.WriteLine("incentico: " + cboIncentivo.SelectedValue);

            int idIncentivo = Convert.ToInt32(cboIncentivo.SelectedValue);
            int idBeneficiario = Convert.ToInt32(cboBeneficiario.SelectedValue);
            DateTime fechaEntrega = cboFechaEntrega.Value;

            //Valida si el registro fue guardado, sino se brinda error
            if (clase_EntregaIncentivos.insertarDatos(idBeneficiario, idIncentivo, fechaEntrega)){
                MessageBox.Show("Registro guardado exitosamente", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                MessageBox.Show("No se pudo guardar el registro", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Recarga la vista de la gridview
            mostrarDatos();
            mostrarIncentivo();
            mostrarBeneficiario();
        }

        private void btnEliminar_Click(object sender, EventArgs e){

            //Validar si se ha seleccionado una fila se brinda un error en pantalla
            if (dtgIncentivosEntregados.CurrentRow != null){
                
                //Se captura el id de la fila a eliminar
                int id = Convert.ToInt32(dtgIncentivosEntregados.CurrentRow.Cells["id"].Value);
                Console.WriteLine("id: " + id);

                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){

                    if (clase_EntregaIncentivos.eliminarDatos(id)){
                        MessageBox.Show("Registro eliminado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else{
                        MessageBox.Show("No se pudo Eliminar el registro", "Ocurrió un error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }else
                    MessageBox.Show("Se canceló el proceso de eliminación", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            //Recarga la vista de la gridview
            mostrarDatos();
            mostrarIncentivo();
            mostrarBeneficiario();
        }

        private void btnModificar_Click(object sender, EventArgs e){

            if (dtgIncentivosEntregados.CurrentRow != null){

                Objeto_EntregaIncentivos objeto_EntregaIncentivos = new Objeto_EntregaIncentivos();
                objeto_EntregaIncentivos.Id_incentivos_entregados = Convert.ToInt32(dtgIncentivosEntregados.CurrentRow.Cells["Id"].Value);
                objeto_EntregaIncentivos.Id_beneficiario = Convert.ToInt32(dtgIncentivosEntregados.CurrentRow.Cells["Id_Beneficiario"].Value);
                objeto_EntregaIncentivos.Id_incentivo = Convert.ToInt32(dtgIncentivosEntregados.CurrentRow.Cells["Id_Incentivo"].Value);
                objeto_EntregaIncentivos.Fecha_entrega = Convert.ToDateTime(dtgIncentivosEntregados.CurrentRow.Cells["Fecha a entregar"].Value);

                Console.WriteLine("\n[btnModificar_Click antes de modificar] idIncentivoEntregado: " + objeto_EntregaIncentivos.Id_incentivos_entregados);
                Console.WriteLine("[btnModificar_Click antes de modificar] fechaEntrega: " + objeto_EntregaIncentivos.Fecha_entrega);
                Console.WriteLine("[btnModificar_Click antes de modificar] idIncentivo: " + objeto_EntregaIncentivos.Id_incentivo);
                Console.WriteLine("[btnModificar_Click antes de modificar] idBeneficiario: " + objeto_EntregaIncentivos.Id_beneficiario);

                this.Hide();
                frmIncentivosEntregadosModificar formIncentivosEntregadosModificar = new frmIncentivosEntregadosModificar();
                formIncentivosEntregadosModificar.recibirDatosMostrarActualizacion(objeto_EntregaIncentivos);
                formIncentivosEntregadosModificar.ShowDialog();
            }
            else {
                MessageBox.Show("Favor seleccione una fila para poder hacer la modificacion...","Comentarios");
            }

            //Recarga la vista de la gridview
            mostrarDatos();
            mostrarIncentivo();
            mostrarBeneficiario();
        }

        /*
         Redireccionamiento a los diferentes menus
         */
        private void btnMenu_Click(object sender, EventArgs e){
            frmMenu menus = new frmMenu();
            this.Hide();
            menus.Show();
        }

        private void btnIncentivos_Click_1(object sender, EventArgs e){
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

        private void btnFondos_Click(object sender, EventArgs e){
            frmFondosIncentivos obj = new frmFondosIncentivos();
            this.Hide();
            obj.Show();
        }
    }
}
