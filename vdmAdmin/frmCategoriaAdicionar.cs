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
        Categoria cat = null;
        rdnCategoria rdnCat = new rdnCategoria();

        public frmCategoriaAdicionar(Categoria c = null)
        {
            InitializeComponent();

            if (c != null)
            {
                cat = c;

                if (cat != null)
                {
                    txtNome.Text = cat.nome;
                    txtID.Text = cat.id.ToString();

                    //frmImposto frmicms = new frmImposto(cat);
                    //frmicms.MdiParent = this;
                    //frmicms.Tag = 1;
                    //frmicms.Show();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cat == null)
            {
                cat = new Categoria();

                String erro = "";

                if (erro == "")
                {
                    cat.nome = txtNome.Text;
                    MessageBox.Show(rdnCat.adicionar(cat));
                }

                //frmImposto frmicms = new frmImposto(cat);
                //frmicms.MdiParent = this;
                //frmicms.Tag = 1;
                //frmicms.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
