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

namespace Sistema_ONG{
    public partial class frmMenu : Form{

        private UtilidadesClases utilidadesClases = new UtilidadesClases();

        public frmMenu(){
            InitializeComponent();
            utilidadesClases.mostrarFecha(lblFecha, lblHora);
        }

        private void btnIncentivosEntregados_Click(object sender, EventArgs e){
            this.Hide();
            frmIncentivosEntregados frmIncentivosEntregados_form = new frmIncentivosEntregados();
            frmIncentivosEntregados_form.Show();
            
        }

        private void btnSalir_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnIncentivos_Click(object sender, EventArgs e){
            this.Hide();
            frmIncentivos frmIncentivos_form = new frmIncentivos();
            frmIncentivos_form.Show();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e){
            this.Hide();
            frmConsultarBeneficiario frmConsultarBeneficiario_form = new frmConsultarBeneficiario();
            frmConsultarBeneficiario_form.Show();
        }

        private void btnFondos_Click(object sender, EventArgs e){
           frmFondosIncentivos obj = new frmFondosIncentivos();
           this.Hide();
           obj.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e){
            this.Hide();
            frmUsuarios frmUsuarios_form = new frmUsuarios();
            frmUsuarios_form.Show();
        }
    }
}
