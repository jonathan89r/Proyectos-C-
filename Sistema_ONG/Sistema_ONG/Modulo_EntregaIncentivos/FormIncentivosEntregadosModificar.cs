using System;
using System.Windows.Forms;
using Sistema_ONG.Modulo_EntregaIncentivos;

namespace Sistema_ONG{
    public partial class frmIncentivosEntregadosModificar : Form{

        private Clase_EntregaIncentivos clase_EntregaIncentivos = new Clase_EntregaIncentivos();
        public Objeto_EntregaIncentivos objeto_EntregaIncentivos = new Objeto_EntregaIncentivos();

        public frmIncentivosEntregadosModificar(){
            InitializeComponent();
        }

        /*
         * Metodos para mostrar datos, combobox... etc
         */
        public void mostrarIncentivoById(int idIncentivo){
            Console.WriteLine("\n[mostrarIncentivoById] Id_incentivo: " + idIncentivo);
            cboIncentivo.DataSource = clase_EntregaIncentivos.mostrarDatosIncentivosById(idIncentivo);
            cboIncentivo.ValueMember = "Id";
            cboIncentivo.DisplayMember = "Incentivo";
        }

        public void mostrarBeneficiarioById(int id_beneficiario) {
            Console.WriteLine("\n[mostrarBeneficiarioById] Id_beneficiario: " + id_beneficiario);
            cboBeneficiario.DataSource = clase_EntregaIncentivos.mostrarDatosBeneficiariosById(id_beneficiario);
            cboBeneficiario.ValueMember = "Id";
            cboBeneficiario.DisplayMember = "Nombre del beneficiario";
        }

        public void recibirDatosMostrarActualizacion(Objeto_EntregaIncentivos objeto) {
            objeto_EntregaIncentivos.Id_incentivo = objeto.Id_incentivo;
            objeto_EntregaIncentivos.Id_beneficiario = objeto.Id_beneficiario;
            objeto_EntregaIncentivos.Id_incentivos_entregados = objeto.Id_incentivos_entregados;
            objeto_EntregaIncentivos.Fecha_entrega = objeto.Fecha_entrega;

            cboFechaEntrega.Value = Convert.ToDateTime(objeto_EntregaIncentivos.Fecha_entrega);

            mostrarIncentivoById(objeto_EntregaIncentivos.Id_incentivo);
            mostrarBeneficiarioById(objeto_EntregaIncentivos.Id_beneficiario);
        }

        private void btnActualizar_Click(object sender, System.EventArgs e){

            Console.WriteLine("\n[btnActualizar_Click] idIncentivoEntregado: " + objeto_EntregaIncentivos.Id_incentivos_entregados);
            Console.WriteLine("[btnActualizar_Click] fechaEntrega: " + objeto_EntregaIncentivos.Fecha_entrega);
            Console.WriteLine("[btnActualizar_Click] idIncentivo: " + objeto_EntregaIncentivos.Id_incentivo);
            Console.WriteLine("[btnActualizar_Click] idBeneficiario: " + objeto_EntregaIncentivos.Id_beneficiario);

            int id = Convert.ToInt32(objeto_EntregaIncentivos.Id_incentivos_entregados);
            int idIncentivo = Convert.ToInt32(cboIncentivo.SelectedValue);
            int idBeneficiario = Convert.ToInt32(cboBeneficiario.SelectedValue);
            DateTime fechaEntrega = cboFechaEntrega.Value;

            if (clase_EntregaIncentivos.ActualizarDatos(id,idBeneficiario, idIncentivo, fechaEntrega)){
                if (MessageBox.Show("Desea cerrar la ventana?", "Registro actualizado exitosamente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    this.Close();
                    frmIncentivosEntregados formulario = new frmIncentivosEntregados();
                    formulario.Show();
                }
            }else{
                MessageBox.Show("No se pudo actualizar el registro", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void frmIncentivosEntregadosModificar_Load(object sender, EventArgs e){
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario); 
        }

        private void cerrarFormulario(object sender, EventArgs e) {
            frmIncentivosEntregados formulario = new frmIncentivosEntregados();
            this.Hide();
            formulario.Show();
        }
    }
}
