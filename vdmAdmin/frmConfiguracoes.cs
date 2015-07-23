using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vdmNegocio;

namespace vdmAdmin
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();

            rdnConfiguracoes rdn = new rdnConfiguracoes();

            Configuracoes config = rdn.buscarConfig();

            int index = cbxRegime.FindString(config.regime);
            cbxRegime.SelectedIndex = index;
           
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            rdnConfiguracoes rdn = new rdnConfiguracoes();

            Configuracoes config = new Configuracoes();
            config.regime = Convert.ToString(cbxRegime.SelectedValue);
            MessageBox.Show(rdn.editarConfiguracoes(config));
        }
    }
}
