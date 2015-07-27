using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vdmAdmin
{
    public partial class frmPrincipal : Form
    {
        frmClienteAdicionar frmfrmPessoaAdicionar = null;
        frmProdutoAdicionar frmProdutoAdicionar = null;
        frmConfiguracoes frmConfig = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProdutoAdicionar == null)
            {
                frmProdutoAdicionar = new frmProdutoAdicionar();


                frmProdutoAdicionar.MdiParent = this;

            }

            frmProdutoAdicionar.Show();

        }

        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmProdutoAdicionar == null)
            {
                frmProdutoAdicionar = new frmProdutoAdicionar();
                frmProdutoAdicionar.MdiParent = this;

            }

            frmProdutoAdicionar.Show();

        }

        private void conToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConfig == null)
            {
                frmConfig = new frmConfiguracoes();
                frmConfig.MdiParent = this;

            }

            frmConfig.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista frm = new frmLista();

            frm.Tag = 1;
            frm.Show();
        }
        
    }
}
