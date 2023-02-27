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

namespace Sistema_ONG{
    public partial class frmIncentivosModificar : Form
    {

        private Clase_Incentivos clase_Incentivos = new Clase_Incentivos();
        public Objeto_Incentivos objeto_Incentivos = new Objeto_Incentivos();

        public frmIncentivosModificar(){
            InitializeComponent();
        }

        /*
         * Metodos para mostrar datos, combobox... etc
         */
        public void mostrarFondoById(int id){
            Console.WriteLine("\n[mostrarFondoById] Id_Fondo: " + id);
            cboFondo.DataSource = clase_Incentivos.mostrarDatosFondosById(id);
            cboFondo.ValueMember = "Id_Fondo_Incentivo";
            cboFondo.DisplayMember = "Nombre";
        }

        /*
         Recibir datos desde otro formulario
         */
        public void recibirDatosMostrarActualizacion(Objeto_Incentivos objeto){
            
            objeto_Incentivos.IdIncentivo = objeto.IdIncentivo;
            objeto_Incentivos.NombreIncentivo = objeto.NombreIncentivo;
            objeto_Incentivos.DescripcionIncentivo = objeto.DescripcionIncentivo;
            objeto_Incentivos.IdFondoIncentivo = objeto.IdFondoIncentivo;

            txtNombreIncentivo.Text = objeto_Incentivos.NombreIncentivo;
            richDescripcionIncentivo.Text = objeto_Incentivos.DescripcionIncentivo;

            mostrarFondoById(objeto_Incentivos.IdFondoIncentivo);
        }

        /*
         Actualizar registro
         */
        private void btnActualizar_Click(object sender, EventArgs e){
            
            Console.WriteLine("\n[btnActualizar_Click] IdIncentivo: " + objeto_Incentivos.IdIncentivo);
            Console.WriteLine("[btnActualizar_Click] NombreIncentivo: " + objeto_Incentivos.NombreIncentivo);
            Console.WriteLine("[btnActualizar_Click] DescripcionIncentivo: " + objeto_Incentivos.DescripcionIncentivo);
            Console.WriteLine("[btnActualizar_Click] IdFondoIncentivo: " + objeto_Incentivos.IdFondoIncentivo);

            int id = Convert.ToInt32(objeto_Incentivos.IdIncentivo);
            string nombreIncentivo = txtNombreIncentivo.Text;
            string descripcionIncentivo = richDescripcionIncentivo.Text;
            int idFondoIncentivo = Convert.ToInt32(cboFondo.SelectedValue);
           
            if (clase_Incentivos.ActualizarDatos(id,nombreIncentivo,descripcionIncentivo, idFondoIncentivo)){
                if (MessageBox.Show("Desea cerrar la ventana?", "Registro actualizado exitosamente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    this.Close();
                    frmIncentivos formulario = new frmIncentivos();
                    formulario.Show();
                }
            }else{
                MessageBox.Show("No se pudo actualizar el registro", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmIncentivosModificar_Load(object sender, EventArgs e){
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }

        private void cerrarFormulario(object sender, EventArgs e){
            frmIncentivos formulario = new frmIncentivos();
            this.Hide();
            formulario.Show();
        }
    }
}
