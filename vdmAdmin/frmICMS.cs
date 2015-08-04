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

        public frmICMS(Categoria cat = null)
        {
            InitializeComponent();

            //tpFormulario.vi

            catLocal = cat;
        }

        private void frmICMS_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.Tag) == 1)
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("SituacaoTributaria", typeof(string));
                dt.Columns.Add("Origem", typeof(string));

                


                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

               

                foreach (var item in rdn.listaImpostoCategoria(catLocal))
                {
                    dt.Rows.Add(item.ICMS.id, item.ICMS.SituacaoTributaria.codigo + " - " + item.ICMS.SituacaoTributaria.descricao, item.ICMS.Origem.dscricao);
                    
                }


                dgvICMS.DataSource = dt;
                
            }
        }
    }
}
