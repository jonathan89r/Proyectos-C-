using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_ONG.Modulo_Beneficiarios;
using Sistema_ONG.Modulo_FondosIncentivos;
using Sistema_ONG.Modulo_Usuarios;

namespace Sistema_ONG{
    public partial class frmConsultarBeneficiario : Form{

        private UtilidadesClases utilidadesClases = new UtilidadesClases();

        public frmConsultarBeneficiario(){
            InitializeComponent();
            dtgBeneficiarios.DataSource = BeneficiarioController.ListaBeneficiarios();
            utilidadesClases.mostrarFecha(lblFecha, lblHora);
        }
        
        public Int64 bn { get; set; }

        private void btnAgregar_Click_1(object sender, EventArgs e){
            frmBeneficiario beneficiario = new frmBeneficiario();
            beneficiario.Show();
            this.Hide();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e){
            try{
                dtgBeneficiarios.DataSource = BeneficiarioController.Buscar(int.Parse(txtBuscarDui.Text));
            }catch{
                MessageBox.Show("Ingrese el DUI del beneficiario", "No se encontro resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtgBeneficiarios.DataSource = BeneficiarioController.ListaBeneficiarios();
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e){
            int tipo = 1;
            if (dtgBeneficiarios.SelectedRows.Count == 1){
                Int64 dui = Convert.ToInt64(dtgBeneficiarios.CurrentRow.Cells[5].Value);

                //txtBuscarDui.Text = dui.ToString();
                frmBeneficiario b = new frmBeneficiario(dui, tipo);
                b.Show();
                this.Hide();
            }else{
                MessageBox.Show("Debe seleccionar la fila con los campos que necesita modificar", "No ha Seleccionado una fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e){
            int tipo = 0;
            if (dtgBeneficiarios.SelectedRows.Count == 1){
                Int64 dui = Convert.ToInt64(dtgBeneficiarios.CurrentRow.Cells[5].Value);

                txtBuscarDui.Text = dui.ToString();
                frmBeneficiario b = new frmBeneficiario(dui, tipo);
                b.Show();
                this.Hide();
            }else{
                MessageBox.Show("Debe seleccionar la fila con los campos que desea Eliminar", "No ha Seleccionado una fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e){
            frmMenu menus = new frmMenu();
            this.Hide();
            menus.Show();
        }


        private void btnIncentivos_Click_1(object sender, EventArgs e){
            frmIncentivos obj = new frmIncentivos();
            this.Hide();
            obj.Show();
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
