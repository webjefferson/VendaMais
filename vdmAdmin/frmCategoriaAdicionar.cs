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
    public partial class frmCategoriaAdicionar : Form
    {
        Categoria catLocal = null;
        rdnCategoria rdnCat = new rdnCategoria();

        public frmCategoriaAdicionar(Categoria c = null)
        {
            InitializeComponent();

            if (c != null)
            {
                catLocal = c;

                if (catLocal != null)
                {
                    txtNome.Text = catLocal.nome;
                    txtID.Text = catLocal.id.ToString();

                    frmICMS frmicms = new frmICMS(catLocal);
                    frmicms.MdiParent = this;
                    frmicms.Tag = 1;
                    frmicms.Show();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (catLocal == null)
            {
                catLocal = new Categoria();

                String erro = "";

                if (erro == "")
                {
                    catLocal.nome = txtNome.Text;
                    MessageBox.Show(rdnCat.adicionar(catLocal));
                    txtID.Text = catLocal.id.ToString();
                }

                frmICMS frmicms = new frmICMS(catLocal);
                frmicms.MdiParent = this;
                frmicms.Tag = 1;
                frmicms.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
