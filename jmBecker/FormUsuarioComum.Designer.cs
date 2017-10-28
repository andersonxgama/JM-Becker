namespace jmBecker
{
    partial class FormUsuarioComum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioComum));
            this.grpAlterarSenha = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskConfirmaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskSenhaAtual = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpAlterarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlterarSenha
            // 
            this.grpAlterarSenha.Controls.Add(this.label3);
            this.grpAlterarSenha.Controls.Add(this.mskConfirmaSenha);
            this.grpAlterarSenha.Controls.Add(this.mskNovaSenha);
            this.grpAlterarSenha.Controls.Add(this.mskSenhaAtual);
            this.grpAlterarSenha.Controls.Add(this.label2);
            this.grpAlterarSenha.Controls.Add(this.label1);
            this.grpAlterarSenha.Location = new System.Drawing.Point(8, 2);
            this.grpAlterarSenha.Name = "grpAlterarSenha";
            this.grpAlterarSenha.Size = new System.Drawing.Size(271, 138);
            this.grpAlterarSenha.TabIndex = 0;
            this.grpAlterarSenha.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirma senha:";
            // 
            // mskConfirmaSenha
            // 
            this.mskConfirmaSenha.Location = new System.Drawing.Point(125, 95);
            this.mskConfirmaSenha.Name = "mskConfirmaSenha";
            this.mskConfirmaSenha.PasswordChar = '●';
            this.mskConfirmaSenha.Size = new System.Drawing.Size(116, 20);
            this.mskConfirmaSenha.TabIndex = 3;
            // 
            // mskNovaSenha
            // 
            this.mskNovaSenha.Location = new System.Drawing.Point(125, 60);
            this.mskNovaSenha.Name = "mskNovaSenha";
            this.mskNovaSenha.PasswordChar = '●';
            this.mskNovaSenha.Size = new System.Drawing.Size(116, 20);
            this.mskNovaSenha.TabIndex = 2;
            // 
            // mskSenhaAtual
            // 
            this.mskSenhaAtual.Location = new System.Drawing.Point(125, 25);
            this.mskSenhaAtual.Name = "mskSenhaAtual";
            this.mskSenhaAtual.PasswordChar = '●';
            this.mskSenhaAtual.Size = new System.Drawing.Size(116, 20);
            this.mskSenhaAtual.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha atual:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(30, 156);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(98, 32);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormUsuarioComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 205);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpAlterarSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarioComum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.grpAlterarSenha.ResumeLayout(false);
            this.grpAlterarSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlterarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskConfirmaSenha;
        private System.Windows.Forms.MaskedTextBox mskNovaSenha;
        private System.Windows.Forms.MaskedTextBox mskSenhaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}