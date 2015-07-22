using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vdmAdmin
{
    public partial class frmPessoaAdicionar : Form
    {
        public frmPessoaAdicionar()
        {
            InitializeComponent();
        }

        private void cbPaís_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPessoaAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendaMaisDataSet.País' table. You can move, or remove it, as needed.
            this.paísTableAdapter.Fill(this.vendaMaisDataSet.País);

        }

              
    }
}
