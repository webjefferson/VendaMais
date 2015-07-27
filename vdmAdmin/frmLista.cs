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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();            
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.Tag) == 1)
            {
                rdnCategoria rdn = new rdnCategoria();

                dgvLista.DataSource = rdn.listarTodos();
                dgvLista.Refresh();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria cat = (dgvLista.SelectedRows[0].DataBoundItem as Categoria);

            frmCategoriaAdicionar frm = new frmCategoriaAdicionar(cat);
            frm.Tag = 1;
            frm.ShowDialog();     

        }
    }
}
