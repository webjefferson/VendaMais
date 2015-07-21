﻿using System;
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
        frmPessoaAdicionar frmfrmPessoaAdicionar = null;
        frmProdutoAdicionar frmProdutoAdicionar = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmfrmPessoaAdicionar == null)
            {
                frmfrmPessoaAdicionar = new frmPessoaAdicionar();


                frmfrmPessoaAdicionar.MdiParent = this;

            }

            frmfrmPessoaAdicionar.Show();
        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {

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

    }
}
