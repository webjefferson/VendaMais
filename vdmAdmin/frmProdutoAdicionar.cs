using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using vdmNegocio;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vdmAdmin
{
    public partial class frmProdutoAdicionar : Form
    {
        public frmProdutoAdicionar()
        {
            InitializeComponent();
            TipoProdutoDAO tipoProdutoDAO = new TipoProdutoDAO();
            rdnSubCategoria rdnSub = new rdnSubCategoria();
            rdnCategoria rdnCat = new rdnCategoria();

            cbxUniMed.DataSource = tipoProdutoDAO.listarTodos();
            cbxUniMed.DisplayMember = "Descricao";
            cbxUniMed.ValueMember = "id";

            cbxSubCategoria.DataSource = rdnSub.listarTodos();
            cbxSubCategoria.DisplayMember = "nome";
            cbxSubCategoria.ValueMember = "id";

            cbxCategoria.DataSource = rdnCat.listarTodos();
            cbxCategoria.DisplayMember = "nome";
            cbxCategoria.ValueMember = "id";


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String erro = "";


            if (txtNome.Text.Length <= 0)
            {
                erro = "Nome;";
            }

            if (txtCodRel.Text.Length <= 0)
            {
                erro = erro + " Código;";
            }

            if (txtPreco.Text.Length <= 0)
            {
                erro = erro + " Preço;";
            }

            if (erro == "")
            {
                Produto p = new Produto();

                p.codigo_referencia = Convert.ToInt64(txtCodRel.Text);
                p.nome = txtNome.Text;
                p.descricao = txtNome.Text;
                p.id_categoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                p.id_sub_categoria = Convert.ToInt32(cbxSubCategoria.SelectedValue);
                p.data_inclusao = DateTime.Now;
                p.preco = Convert.ToDecimal(txtPreco.Text);
                p.tipo_unidade = Convert.ToInt32(cbxUniMed.SelectedValue);

                rdnProduto rdn = new rdnProduto();

                MessageBox.Show(rdn.adicionar(p));
            }
            else
            {
                MessageBox.Show("Os campos são obrigatórios: " + erro);
            }
        }

        private void txtCodRel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
