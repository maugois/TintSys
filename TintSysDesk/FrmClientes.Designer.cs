namespace TintSysDesk
{
    partial class FrmClientes
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
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.clnIdTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.clnIdEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisarAtivo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbcInserir = new System.Windows.Forms.TabControl();
            this.tabDadosPessoais = new System.Windows.Forms.TabPage();
            this.mstCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabEnderecos = new System.Windows.Forms.TabPage();
            this.tabTelefones = new System.Windows.Forms.TabPage();
            this.chkAtivos = new System.Windows.Forms.CheckBox();
            this.pnlConsulta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.tbcInserir.SuspendLayout();
            this.tabDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.groupBox3);
            this.pnlConsulta.Controls.Add(this.groupBox2);
            this.pnlConsulta.Controls.Add(this.groupBox1);
            this.pnlConsulta.Location = new System.Drawing.Point(25, 143);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(1198, 450);
            this.pnlConsulta.TabIndex = 9;
            this.pnlConsulta.Visible = false;
            this.pnlConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTelefone);
            this.groupBox3.Location = new System.Drawing.Point(572, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 155);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telefones";
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdTelefone,
            this.clnNumeroTelefone,
            this.clnTipoTelefone});
            this.dgvTelefone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelefone.Location = new System.Drawing.Point(3, 16);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersVisible = false;
            this.dgvTelefone.Size = new System.Drawing.Size(372, 136);
            this.dgvTelefone.TabIndex = 19;
            // 
            // clnIdTelefone
            // 
            this.clnIdTelefone.Frozen = true;
            this.clnIdTelefone.HeaderText = "Id";
            this.clnIdTelefone.Name = "clnIdTelefone";
            this.clnIdTelefone.ReadOnly = true;
            this.clnIdTelefone.Width = 40;
            // 
            // clnNumeroTelefone
            // 
            this.clnNumeroTelefone.Frozen = true;
            this.clnNumeroTelefone.HeaderText = "Numero";
            this.clnNumeroTelefone.Name = "clnNumeroTelefone";
            this.clnNumeroTelefone.ReadOnly = true;
            this.clnNumeroTelefone.Width = 130;
            // 
            // clnTipoTelefone
            // 
            this.clnTipoTelefone.Frozen = true;
            this.clnTipoTelefone.HeaderText = "Tipo";
            this.clnTipoTelefone.Name = "clnTipoTelefone";
            this.clnTipoTelefone.ReadOnly = true;
            this.clnTipoTelefone.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEndereco);
            this.groupBox2.Location = new System.Drawing.Point(572, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 246);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enderecos";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdEndereco,
            this.clnCep,
            this.clnLogradouro,
            this.clnNumero,
            this.clnComplemento,
            this.clnBairro,
            this.clnCidade,
            this.clnEstado,
            this.clnUf,
            this.clnTipoEndereco});
            this.dgvEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEndereco.Location = new System.Drawing.Point(3, 16);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.RowHeadersVisible = false;
            this.dgvEndereco.Size = new System.Drawing.Size(617, 227);
            this.dgvEndereco.TabIndex = 18;
            // 
            // clnIdEndereco
            // 
            this.clnIdEndereco.Frozen = true;
            this.clnIdEndereco.HeaderText = "Id";
            this.clnIdEndereco.Name = "clnIdEndereco";
            this.clnIdEndereco.ReadOnly = true;
            this.clnIdEndereco.Width = 29;
            // 
            // clnCep
            // 
            this.clnCep.Frozen = true;
            this.clnCep.HeaderText = "CEP";
            this.clnCep.Name = "clnCep";
            this.clnCep.ReadOnly = true;
            this.clnCep.Width = 50;
            // 
            // clnLogradouro
            // 
            this.clnLogradouro.Frozen = true;
            this.clnLogradouro.HeaderText = "Logradouro";
            this.clnLogradouro.Name = "clnLogradouro";
            this.clnLogradouro.ReadOnly = true;
            this.clnLogradouro.Width = 150;
            // 
            // clnNumero
            // 
            this.clnNumero.Frozen = true;
            this.clnNumero.HeaderText = "Número";
            this.clnNumero.Name = "clnNumero";
            this.clnNumero.ReadOnly = true;
            this.clnNumero.Width = 50;
            // 
            // clnComplemento
            // 
            this.clnComplemento.Frozen = true;
            this.clnComplemento.HeaderText = "Complemento";
            this.clnComplemento.Name = "clnComplemento";
            this.clnComplemento.ReadOnly = true;
            this.clnComplemento.Width = 80;
            // 
            // clnBairro
            // 
            this.clnBairro.Frozen = true;
            this.clnBairro.HeaderText = "Bairro";
            this.clnBairro.Name = "clnBairro";
            this.clnBairro.ReadOnly = true;
            this.clnBairro.Width = 50;
            // 
            // clnCidade
            // 
            this.clnCidade.Frozen = true;
            this.clnCidade.HeaderText = "Cidade";
            this.clnCidade.Name = "clnCidade";
            this.clnCidade.ReadOnly = true;
            this.clnCidade.Width = 50;
            // 
            // clnEstado
            // 
            this.clnEstado.Frozen = true;
            this.clnEstado.HeaderText = "Estado";
            this.clnEstado.Name = "clnEstado";
            this.clnEstado.ReadOnly = true;
            this.clnEstado.Width = 50;
            // 
            // clnUf
            // 
            this.clnUf.Frozen = true;
            this.clnUf.HeaderText = "UF";
            this.clnUf.Name = "clnUf";
            this.clnUf.ReadOnly = true;
            this.clnUf.Width = 50;
            // 
            // clnTipoEndereco
            // 
            this.clnTipoEndereco.Frozen = true;
            this.clnTipoEndereco.HeaderText = "Tipos";
            this.clnTipoEndereco.Name = "clnTipoEndereco";
            this.clnTipoEndereco.ReadOnly = true;
            this.clnTipoEndereco.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAtivos);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtPesquisarAtivo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.dgvListaCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 428);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TintSysDesk.Properties.Resources.Search;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(520, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisarAtivo
            // 
            this.txtPesquisarAtivo.Location = new System.Drawing.Point(12, 50);
            this.txtPesquisarAtivo.Name = "txtPesquisarAtivo";
            this.txtPesquisarAtivo.Size = new System.Drawing.Size(509, 20);
            this.txtPesquisarAtivo.TabIndex = 28;
            this.txtPesquisarAtivo.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(110, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 22);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(476, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AllowUserToAddRows = false;
            this.dgvListaCliente.AllowUserToDeleteRows = false;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.Data});
            this.dgvListaCliente.Location = new System.Drawing.Point(12, 71);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.RowHeadersVisible = false;
            this.dgvListaCliente.Size = new System.Drawing.Size(540, 351);
            this.dgvListaCliente.TabIndex = 14;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 125;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 125;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 125;
            // 
            // Data
            // 
            this.Data.Frozen = true;
            this.Data.HeaderText = "Data Cadastro";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(33, 14);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(43, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.OldLace;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultar.Location = new System.Drawing.Point(267, 47);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(181, 62);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.OldLace;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserir.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserir.Location = new System.Drawing.Point(488, 47);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(181, 62);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.OldLace;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnAlterar.Location = new System.Drawing.Point(706, 47);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(181, 62);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbcInserir
            // 
            this.tbcInserir.Controls.Add(this.tabDadosPessoais);
            this.tbcInserir.Controls.Add(this.tabEnderecos);
            this.tbcInserir.Controls.Add(this.tabTelefones);
            this.tbcInserir.Location = new System.Drawing.Point(1214, 24);
            this.tbcInserir.Name = "tbcInserir";
            this.tbcInserir.SelectedIndex = 0;
            this.tbcInserir.Size = new System.Drawing.Size(626, 447);
            this.tbcInserir.TabIndex = 17;
            this.tbcInserir.Visible = false;
            // 
            // tabDadosPessoais
            // 
            this.tabDadosPessoais.Controls.Add(this.mstCpf);
            this.tabDadosPessoais.Controls.Add(this.label6);
            this.tabDadosPessoais.Controls.Add(this.label9);
            this.tabDadosPessoais.Controls.Add(this.label10);
            this.tabDadosPessoais.Controls.Add(this.txtEmail);
            this.tabDadosPessoais.Controls.Add(this.txtNome);
            this.tabDadosPessoais.Controls.Add(this.textBox1);
            this.tabDadosPessoais.Controls.Add(this.button2);
            this.tabDadosPessoais.Controls.Add(this.label11);
            this.tabDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabDadosPessoais.Name = "tabDadosPessoais";
            this.tabDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPessoais.Size = new System.Drawing.Size(618, 421);
            this.tabDadosPessoais.TabIndex = 0;
            this.tabDadosPessoais.Text = "Dados Pessoais";
            this.tabDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // mstCpf
            // 
            this.mstCpf.Location = new System.Drawing.Point(193, 222);
            this.mstCpf.Mask = "000.000.000-00";
            this.mstCpf.Name = "mstCpf";
            this.mstCpf.Size = new System.Drawing.Size(98, 20);
            this.mstCpf.TabIndex = 40;
            this.mstCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "CPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(193, 141);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = " ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::TintSysDesk.Properties.Resources.Add;
            this.button2.Location = new System.Drawing.Point(394, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 30;
            this.button2.Text = "Inserir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "ID";
            // 
            // tabEnderecos
            // 
            this.tabEnderecos.Location = new System.Drawing.Point(4, 22);
            this.tabEnderecos.Name = "tabEnderecos";
            this.tabEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnderecos.Size = new System.Drawing.Size(618, 421);
            this.tabEnderecos.TabIndex = 1;
            this.tabEnderecos.Text = "Endereços";
            this.tabEnderecos.UseVisualStyleBackColor = true;
            // 
            // tabTelefones
            // 
            this.tabTelefones.Location = new System.Drawing.Point(4, 22);
            this.tabTelefones.Name = "tabTelefones";
            this.tabTelefones.Padding = new System.Windows.Forms.Padding(3);
            this.tabTelefones.Size = new System.Drawing.Size(618, 421);
            this.tabTelefones.TabIndex = 2;
            this.tabTelefones.Text = "Telefones";
            this.tabTelefones.UseVisualStyleBackColor = true;
            // 
            // chkAtivos
            // 
            this.chkAtivos.AutoSize = true;
            this.chkAtivos.Location = new System.Drawing.Point(375, 14);
            this.chkAtivos.Name = "chkAtivos";
            this.chkAtivos.Size = new System.Drawing.Size(90, 17);
            this.chkAtivos.TabIndex = 30;
            this.chkAtivos.Text = "Listar inativos";
            this.chkAtivos.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 611);
            this.Controls.Add(this.tbcInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.pnlConsulta);
            this.Name = "FrmClientes";
            this.Text = "Administração dos Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlConsulta.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.tbcInserir.ResumeLayout(false);
            this.tabDadosPessoais.ResumeLayout(false);
            this.tabDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisarAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoEndereco;
        private System.Windows.Forms.TabControl tbcInserir;
        private System.Windows.Forms.TabPage tabDadosPessoais;
        private System.Windows.Forms.TabPage tabEnderecos;
        private System.Windows.Forms.TabPage tabTelefones;
        private System.Windows.Forms.MaskedTextBox mstCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkAtivos;
    }
}