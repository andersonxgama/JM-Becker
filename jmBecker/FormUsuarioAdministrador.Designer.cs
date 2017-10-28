namespace jmBecker
{
    partial class FormUsuarioAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioAdministrador));
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTipoUsuario = new System.Windows.Forms.GroupBox();
            this.optComum = new System.Windows.Forms.RadioButton();
            this.optAdministrador = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMenuUsuariosNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuUsuariosEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuUsuariosExcluir = new System.Windows.Forms.ToolStripButton();
            this.grpSenha = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mskConfirmaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpUsuario.SuspendLayout();
            this.grpTipoUsuario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.cmbUsuario);
            this.grpUsuario.Controls.Add(this.label1);
            this.grpUsuario.Location = new System.Drawing.Point(8, 22);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(298, 61);
            this.grpUsuario.TabIndex = 0;
            this.grpUsuario.TabStop = false;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(78, 22);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(198, 21);
            this.cmbUsuario.TabIndex = 1;
            this.cmbUsuario.SelectedValueChanged += new System.EventHandler(this.cmbUsuario_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // grpTipoUsuario
            // 
            this.grpTipoUsuario.Controls.Add(this.optComum);
            this.grpTipoUsuario.Controls.Add(this.optAdministrador);
            this.grpTipoUsuario.Location = new System.Drawing.Point(8, 83);
            this.grpTipoUsuario.Name = "grpTipoUsuario";
            this.grpTipoUsuario.Size = new System.Drawing.Size(298, 61);
            this.grpTipoUsuario.TabIndex = 1;
            this.grpTipoUsuario.TabStop = false;
            this.grpTipoUsuario.Text = "Tipo do usuário";
            // 
            // optComum
            // 
            this.optComum.AutoSize = true;
            this.optComum.Location = new System.Drawing.Point(201, 26);
            this.optComum.Name = "optComum";
            this.optComum.Size = new System.Drawing.Size(60, 17);
            this.optComum.TabIndex = 3;
            this.optComum.TabStop = true;
            this.optComum.Text = "Comum";
            this.optComum.UseVisualStyleBackColor = true;
            this.optComum.Click += new System.EventHandler(this.optComum_Click);
            // 
            // optAdministrador
            // 
            this.optAdministrador.AutoSize = true;
            this.optAdministrador.Location = new System.Drawing.Point(37, 26);
            this.optAdministrador.Name = "optAdministrador";
            this.optAdministrador.Size = new System.Drawing.Size(88, 17);
            this.optAdministrador.TabIndex = 2;
            this.optAdministrador.TabStop = true;
            this.optAdministrador.Text = "Administrador";
            this.optAdministrador.UseVisualStyleBackColor = true;
            this.optAdministrador.Click += new System.EventHandler(this.optAdministrador_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuUsuariosNovo,
            this.toolStripSeparator2,
            this.btnMenuUsuariosEditar,
            this.toolStripSeparator1,
            this.btnMenuUsuariosExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(317, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMenuUsuariosNovo
            // 
            this.btnMenuUsuariosNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuUsuariosNovo.Image")));
            this.btnMenuUsuariosNovo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuariosNovo.Name = "btnMenuUsuariosNovo";
            this.btnMenuUsuariosNovo.Size = new System.Drawing.Size(56, 22);
            this.btnMenuUsuariosNovo.Text = "&Novo";
            this.btnMenuUsuariosNovo.Click += new System.EventHandler(this.btnMenuUsuariosNovo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenuUsuariosEditar
            // 
            this.btnMenuUsuariosEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuUsuariosEditar.Image")));
            this.btnMenuUsuariosEditar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuariosEditar.Name = "btnMenuUsuariosEditar";
            this.btnMenuUsuariosEditar.Size = new System.Drawing.Size(57, 22);
            this.btnMenuUsuariosEditar.Text = "&Editar";
            this.btnMenuUsuariosEditar.Click += new System.EventHandler(this.btnMenuUsuariosEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenuUsuariosExcluir
            // 
            this.btnMenuUsuariosExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuUsuariosExcluir.Image")));
            this.btnMenuUsuariosExcluir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuariosExcluir.Name = "btnMenuUsuariosExcluir";
            this.btnMenuUsuariosExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnMenuUsuariosExcluir.Text = "&Excluir";
            this.btnMenuUsuariosExcluir.Click += new System.EventHandler(this.btnMenuUsuariosExcluir_Click);
            // 
            // grpSenha
            // 
            this.grpSenha.Controls.Add(this.txtUsuario);
            this.grpSenha.Controls.Add(this.mskConfirmaSenha);
            this.grpSenha.Controls.Add(this.mskSenha);
            this.grpSenha.Controls.Add(this.label4);
            this.grpSenha.Controls.Add(this.lblSenha);
            this.grpSenha.Controls.Add(this.label2);
            this.grpSenha.Location = new System.Drawing.Point(8, 142);
            this.grpSenha.Name = "grpSenha";
            this.grpSenha.Size = new System.Drawing.Size(298, 130);
            this.grpSenha.TabIndex = 3;
            this.grpSenha.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(162, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // mskConfirmaSenha
            // 
            this.mskConfirmaSenha.Location = new System.Drawing.Point(115, 89);
            this.mskConfirmaSenha.Name = "mskConfirmaSenha";
            this.mskConfirmaSenha.PasswordChar = '●';
            this.mskConfirmaSenha.Size = new System.Drawing.Size(162, 20);
            this.mskConfirmaSenha.TabIndex = 6;
            // 
            // mskSenha
            // 
            this.mskSenha.Location = new System.Drawing.Point(115, 56);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '●';
            this.mskSenha.Size = new System.Drawing.Size(162, 20);
            this.mskSenha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirma senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(24, 60);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuário:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(31, 294);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormUsuarioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 342);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.grpTipoUsuario);
            this.Controls.Add(this.grpSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarioAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.FormUsuarioAdministrador_Load);
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpTipoUsuario.ResumeLayout(false);
            this.grpTipoUsuario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpSenha.ResumeLayout(false);
            this.grpSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTipoUsuario;
        private System.Windows.Forms.RadioButton optComum;
        private System.Windows.Forms.RadioButton optAdministrador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMenuUsuariosNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMenuUsuariosEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMenuUsuariosExcluir;
        private System.Windows.Forms.GroupBox grpSenha;
        private System.Windows.Forms.MaskedTextBox mskConfirmaSenha;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}