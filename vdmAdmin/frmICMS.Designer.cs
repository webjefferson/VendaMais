namespace vdmAdmin
{
    partial class frmICMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpFormulario = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvICMS = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSituacaoTributaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Origem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSituação = new System.Windows.Forms.ComboBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvICMS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpFormulario);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 207);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVer);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btn);
            this.tabPage1.Controls.Add(this.btnAdicionar);
            this.tabPage1.Controls.Add(this.dgvICMS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpFormulario
            // 
            this.tpFormulario.Controls.Add(this.button2);
            this.tpFormulario.Controls.Add(this.button1);
            this.tpFormulario.Controls.Add(this.cbxOrigem);
            this.tpFormulario.Controls.Add(this.cbxSituação);
            this.tpFormulario.Controls.Add(this.label3);
            this.tpFormulario.Controls.Add(this.label2);
            this.tpFormulario.Controls.Add(this.Origem);
            this.tpFormulario.Controls.Add(this.txtID);
            this.tpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tpFormulario.Name = "tpFormulario";
            this.tpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulario.Size = new System.Drawing.Size(589, 181);
            this.tpFormulario.TabIndex = 1;
            this.tpFormulario.Text = "Formulário";
            this.tpFormulario.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(428, 155);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 6;
            this.btn.Text = "Editar";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(347, 155);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvICMS
            // 
            this.dgvICMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvICMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnSituacaoTributaria,
            this.ColumnOrigem});
            this.dgvICMS.Location = new System.Drawing.Point(-1, 1);
            this.dgvICMS.MultiSelect = false;
            this.dgvICMS.Name = "dgvICMS";
            this.dgvICMS.ReadOnly = true;
            this.dgvICMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvICMS.Size = new System.Drawing.Size(591, 150);
            this.dgvICMS.TabIndex = 4;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 30;
            // 
            // ColumnSituacaoTributaria
            // 
            this.ColumnSituacaoTributaria.DataPropertyName = "SituacaoTributaria";
            this.ColumnSituacaoTributaria.HeaderText = "Situação tributária";
            this.ColumnSituacaoTributaria.Name = "ColumnSituacaoTributaria";
            this.ColumnSituacaoTributaria.ReadOnly = true;
            this.ColumnSituacaoTributaria.Width = 400;
            // 
            // ColumnOrigem
            // 
            this.ColumnOrigem.DataPropertyName = "Origem";
            this.ColumnOrigem.HeaderText = "Origem";
            this.ColumnOrigem.Name = "ColumnOrigem";
            this.ColumnOrigem.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(266, 155);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(35, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(32, 20);
            this.txtID.TabIndex = 0;
            // 
            // Origem
            // 
            this.Origem.AutoSize = true;
            this.Origem.Location = new System.Drawing.Point(211, 40);
            this.Origem.Name = "Origem";
            this.Origem.Size = new System.Drawing.Size(40, 13);
            this.Origem.TabIndex = 1;
            this.Origem.Text = "Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Situação tributária ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // cbxSituação
            // 
            this.cbxSituação.FormattingEnabled = true;
            this.cbxSituação.Location = new System.Drawing.Point(74, 58);
            this.cbxSituação.Name = "cbxSituação";
            this.cbxSituação.Size = new System.Drawing.Size(121, 21);
            this.cbxSituação.TabIndex = 4;
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(214, 58);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(121, 21);
            this.cbxOrigem.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmICMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 207);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmICMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Impostos";
            this.Load += new System.EventHandler(this.frmICMS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.tpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvICMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSituacaoTributaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrigem;
        private System.Windows.Forms.TabPage tpFormulario;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.ComboBox cbxSituação;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Origem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}