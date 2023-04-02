namespace TintSysDesk
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clnld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbNivel = new System.Windows.Forms.GroupBox();
            this.dgvNiveis = new System.Windows.Forms.DataGridView();
            this.clnIdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSiglaNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeleteNivel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.btnEditarNivel = new System.Windows.Forms.Button();
            this.btnConsultarNivel = new System.Windows.Forms.Button();
            this.btnInserirNivel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbNivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserir.Location = new System.Drawing.Point(172, 192);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 55);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultar.Location = new System.Drawing.Point(292, 192);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 55);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditar.Location = new System.Drawing.Point(416, 192);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 55);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Text = " ";
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(172, 153);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(116, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(172, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtNivel
            // 
            this.txtNivel.FormattingEnabled = true;
            this.txtNivel.Location = new System.Drawing.Point(365, 152);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(126, 21);
            this.txtNivel.TabIndex = 8;
            this.txtNivel.SelectedIndexChanged += new System.EventHandler(this.txtNivel_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(441, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nível";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnld,
            this.cln,
            this.clnEmail,
            this.clnNivel,
            this.clnAtivo});
            this.dgvUsuarios.Location = new System.Drawing.Point(54, 265);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(552, 200);
            this.dgvUsuarios.TabIndex = 14;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // clnld
            // 
            this.clnld.Frozen = true;
            this.clnld.HeaderText = "Id";
            this.clnld.Name = "clnld";
            this.clnld.ReadOnly = true;
            this.clnld.Width = 40;
            // 
            // cln
            // 
            this.cln.Frozen = true;
            this.cln.HeaderText = "Nome";
            this.cln.Name = "cln";
            this.cln.ReadOnly = true;
            this.cln.Width = 174;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 174;
            // 
            // clnNivel
            // 
            this.clnNivel.Frozen = true;
            this.clnNivel.HeaderText = "Nível";
            this.clnNivel.Name = "clnNivel";
            this.clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 60;
            // 
            // gbNivel
            // 
            this.gbNivel.Controls.Add(this.dgvNiveis);
            this.gbNivel.Controls.Add(this.label8);
            this.gbNivel.Controls.Add(this.label7);
            this.gbNivel.Controls.Add(this.label6);
            this.gbNivel.Controls.Add(this.txtSigla);
            this.gbNivel.Controls.Add(this.txtNomeNivel);
            this.gbNivel.Controls.Add(this.txtIdNivel);
            this.gbNivel.Controls.Add(this.btnEditarNivel);
            this.gbNivel.Controls.Add(this.btnConsultarNivel);
            this.gbNivel.Controls.Add(this.btnInserirNivel);
            this.gbNivel.Location = new System.Drawing.Point(634, 44);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Size = new System.Drawing.Size(388, 421);
            this.gbNivel.TabIndex = 15;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Níveis";
            // 
            // dgvNiveis
            // 
            this.dgvNiveis.AllowUserToAddRows = false;
            this.dgvNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdNivel,
            this.clnNomeNivel,
            this.clnSiglaNivel,
            this.clnDeleteNivel});
            this.dgvNiveis.Location = new System.Drawing.Point(34, 226);
            this.dgvNiveis.Name = "dgvNiveis";
            this.dgvNiveis.ReadOnly = true;
            this.dgvNiveis.RowHeadersVisible = false;
            this.dgvNiveis.Size = new System.Drawing.Size(323, 177);
            this.dgvNiveis.TabIndex = 16;
            this.dgvNiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNiveis_CellContentClick);
            // 
            // clnIdNivel
            // 
            this.clnIdNivel.Frozen = true;
            this.clnIdNivel.HeaderText = "ID";
            this.clnIdNivel.Name = "clnIdNivel";
            this.clnIdNivel.ReadOnly = true;
            this.clnIdNivel.Width = 40;
            // 
            // clnNomeNivel
            // 
            this.clnNomeNivel.Frozen = true;
            this.clnNomeNivel.HeaderText = "Nome";
            this.clnNomeNivel.Name = "clnNomeNivel";
            this.clnNomeNivel.ReadOnly = true;
            this.clnNomeNivel.Width = 120;
            // 
            // clnSiglaNivel
            // 
            this.clnSiglaNivel.Frozen = true;
            this.clnSiglaNivel.HeaderText = "Sigla";
            this.clnSiglaNivel.Name = "clnSiglaNivel";
            this.clnSiglaNivel.ReadOnly = true;
            this.clnSiglaNivel.Width = 80;
            // 
            // clnDeleteNivel
            // 
            this.clnDeleteNivel.Frozen = true;
            this.clnDeleteNivel.HeaderText = "Ação";
            this.clnDeleteNivel.Name = "clnDeleteNivel";
            this.clnDeleteNivel.ReadOnly = true;
            this.clnDeleteNivel.Text = "Excluir";
            this.clnDeleteNivel.Width = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sigla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(103, 111);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(124, 20);
            this.txtSigla.TabIndex = 5;
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(103, 78);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(219, 20);
            this.txtNomeNivel.TabIndex = 4;
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(103, 42);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(34, 20);
            this.txtIdNivel.TabIndex = 3;
            this.txtIdNivel.TextChanged += new System.EventHandler(this.txtIdNivel_TextChanged);
            // 
            // btnEditarNivel
            // 
            this.btnEditarNivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditarNivel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNivel.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditarNivel.Location = new System.Drawing.Point(247, 148);
            this.btnEditarNivel.Name = "btnEditarNivel";
            this.btnEditarNivel.Size = new System.Drawing.Size(75, 55);
            this.btnEditarNivel.TabIndex = 2;
            this.btnEditarNivel.Text = "Editar";
            this.btnEditarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarNivel.UseVisualStyleBackColor = false;
            this.btnEditarNivel.Click += new System.EventHandler(this.btnEditarNivel_Click);
            // 
            // btnConsultarNivel
            // 
            this.btnConsultarNivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarNivel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConsultarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNivel.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarNivel.Image")));
            this.btnConsultarNivel.Location = new System.Drawing.Point(152, 148);
            this.btnConsultarNivel.Name = "btnConsultarNivel";
            this.btnConsultarNivel.Size = new System.Drawing.Size(75, 55);
            this.btnConsultarNivel.TabIndex = 1;
            this.btnConsultarNivel.Text = "Consultar";
            this.btnConsultarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarNivel.UseVisualStyleBackColor = false;
            this.btnConsultarNivel.Click += new System.EventHandler(this.btnConsultarNivel_Click);
            // 
            // btnInserirNivel
            // 
            this.btnInserirNivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInserirNivel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserirNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnInserirNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInserirNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNivel.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserirNivel.Location = new System.Drawing.Point(62, 148);
            this.btnInserirNivel.Name = "btnInserirNivel";
            this.btnInserirNivel.Size = new System.Drawing.Size(75, 55);
            this.btnInserirNivel.TabIndex = 0;
            this.btnInserirNivel.Text = "Inserir";
            this.btnInserirNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirNivel.UseVisualStyleBackColor = false;
            this.btnInserirNivel.Click += new System.EventHandler(this.btnInserirNivel_Click);
            // 
            // FrmUsuarios
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.gbNivel);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "Administração dos Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbNivel.ResumeLayout(false);
            this.gbNivel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox txtNivel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnld;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.GroupBox gbNivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.Button btnEditarNivel;
        private System.Windows.Forms.Button btnConsultarNivel;
        private System.Windows.Forms.Button btnInserirNivel;
        private System.Windows.Forms.DataGridView dgvNiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSiglaNivel;
        private System.Windows.Forms.DataGridViewButtonColumn clnDeleteNivel;
    }
}