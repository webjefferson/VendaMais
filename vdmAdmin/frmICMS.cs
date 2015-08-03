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
    public partial class frmICMS : Form
    {
        Categoria catLocal = null;
        rdnProduto rdn = new rdnProduto();

        public frmICMS(Categoria cat)
        {
            InitializeComponent();

            catLocal = cat;
        }

        private void frmICMS_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.Tag) == 1)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                dgvICMS.DataSource = rdn.listaICMSPorCategoria(catLocal);
                
            }
        }
    }
}
