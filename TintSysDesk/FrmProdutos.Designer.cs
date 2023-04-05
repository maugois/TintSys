namespace TintSysDesk
{
    partial class FrmProdutos
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.chkDescontinuado = new System.Windows.Forms.CheckBox();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescontinuadoo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnDescricao,
            this.clnUnidade,
            this.clnCodBar,
            this.clnPreco,
            this.clnDesconto,
            this.clnDescontinuadoo});
            this.dgvLista.Location = new System.Drawing.Point(56, 245);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.Size = new System.Drawing.Size(500, 150);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(56, 195);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(183, 195);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(301, 195);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnArquivar
            // 
            this.btnArquivar.Location = new System.Drawing.Point(407, 195);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(75, 23);
            this.btnArquivar.TabIndex = 4;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(143, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 56);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(51, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(56, 99);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(227, 20);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(56, 144);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(100, 20);
            this.txtCodBar.TabIndex = 9;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(183, 145);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 10;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(301, 145);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código de Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Preço (R$)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Desconto (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unidade";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "Kilo",
            "Litro",
            "Pacote",
            "Peça",
            "Caixa",
            "Unidade",
            "Gramas",
            "Fardo",
            "Mili Litro",
            "Metro"});
            this.cmbUnidade.Location = new System.Drawing.Point(301, 100);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(100, 21);
            this.cmbUnidade.TabIndex = 18;
            // 
            // chkDescontinuado
            // 
            this.chkDescontinuado.AutoSize = true;
            this.chkDescontinuado.Location = new System.Drawing.Point(303, 62);
            this.chkDescontinuado.Name = "chkDescontinuado";
            this.chkDescontinuado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDescontinuado.Size = new System.Drawing.Size(98, 17);
            this.chkDescontinuado.TabIndex = 19;
            this.chkDescontinuado.Text = "Descontinuado";
            this.chkDescontinuado.UseVisualStyleBackColor = true;
            this.chkDescontinuado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 159;
            // 
            // clnUnidade
            // 
            this.clnUnidade.Frozen = true;
            this.clnUnidade.HeaderText = "Unidade";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 60;
            // 
            // clnCodBar
            // 
            this.clnCodBar.Frozen = true;
            this.clnCodBar.HeaderText = "CodBar";
            this.clnCodBar.Name = "clnCodBar";
            this.clnCodBar.ReadOnly = true;
            this.clnCodBar.Width = 70;
            // 
            // clnPreco
            // 
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "Preço";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            this.clnPreco.Width = 60;
            // 
            // clnDesconto
            // 
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "Desconto";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            this.clnDesconto.Width = 60;
            // 
            // clnDescontinuadoo
            // 
            this.clnDescontinuadoo.Frozen = true;
            this.clnDescontinuadoo.HeaderText = "Inativo";
            this.clnDescontinuadoo.Name = "clnDescontinuadoo";
            this.clnDescontinuadoo.ReadOnly = true;
            this.clnDescontinuadoo.Width = 50;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkDescontinuado);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodBar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.CheckBox chkDescontinuado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnDescontinuadoo;
    }
}