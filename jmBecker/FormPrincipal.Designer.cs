namespace jmBecker
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnMenuPrincipalClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuPrincipalOs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuPrincipalPagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuPrincipalReceber = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuPrincipalAdmin = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomeUsuarioAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuPrincipalClientes,
            this.toolStripSeparator4,
            this.btnMenuPrincipalOs,
            this.toolStripSeparator3,
            this.btnMenuPrincipalPagar,
            this.toolStripSeparator2,
            this.btnMenuPrincipalReceber,
            this.toolStripSeparator1,
            this.btnMenuPrincipalAdmin});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 43);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "toolStrip1";
            // 
            // btnMenuPrincipalClientes
            // 
            this.btnMenuPrincipalClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPrincipalClientes.Image")));
            this.btnMenuPrincipalClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPrincipalClientes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuPrincipalClientes.Name = "btnMenuPrincipalClientes";
            this.btnMenuPrincipalClientes.Size = new System.Drawing.Size(89, 40);
            this.btnMenuPrincipalClientes.Text = "&Clientes";
            this.btnMenuPrincipalClientes.Click += new System.EventHandler(this.btnMenuPrincipalClientes_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // btnMenuPrincipalOs
            // 
            this.btnMenuPrincipalOs.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPrincipalOs.Image")));
            this.btnMenuPrincipalOs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPrincipalOs.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuPrincipalOs.Name = "btnMenuPrincipalOs";
            this.btnMenuPrincipalOs.Size = new System.Drawing.Size(140, 40);
            this.btnMenuPrincipalOs.Text = "&Ordem de serviço";
            this.btnMenuPrincipalOs.Click += new System.EventHandler(this.btnMenuPrincipalOs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnMenuPrincipalPagar
            // 
            this.btnMenuPrincipalPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPrincipalPagar.Image")));
            this.btnMenuPrincipalPagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPrincipalPagar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuPrincipalPagar.Name = "btnMenuPrincipalPagar";
            this.btnMenuPrincipalPagar.Size = new System.Drawing.Size(126, 40);
            this.btnMenuPrincipalPagar.Text = "Contas a &Pagar";
            this.btnMenuPrincipalPagar.Click += new System.EventHandler(this.btnMenuPrincipalPagar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnMenuPrincipalReceber
            // 
            this.btnMenuPrincipalReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPrincipalReceber.Image")));
            this.btnMenuPrincipalReceber.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPrincipalReceber.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuPrincipalReceber.Name = "btnMenuPrincipalReceber";
            this.btnMenuPrincipalReceber.Size = new System.Drawing.Size(138, 40);
            this.btnMenuPrincipalReceber.Text = "Contas a &Receber";
            this.btnMenuPrincipalReceber.Click += new System.EventHandler(this.btnMenuPrincipalReceber_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnMenuPrincipalAdmin
            // 
            this.btnMenuPrincipalAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPrincipalAdmin.Image")));
            this.btnMenuPrincipalAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPrincipalAdmin.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuPrincipalAdmin.Name = "btnMenuPrincipalAdmin";
            this.btnMenuPrincipalAdmin.Size = new System.Drawing.Size(92, 40);
            this.btnMenuPrincipalAdmin.Text = "&Usuários";
            this.btnMenuPrincipalAdmin.Click += new System.EventHandler(this.btnMenuPrincipalAdmin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioAtual,
            this.lblNomeUsuarioAtual});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblUsuarioAtual
            // 
            this.lblUsuarioAtual.Name = "lblUsuarioAtual";
            this.lblUsuarioAtual.Size = new System.Drawing.Size(79, 17);
            this.lblUsuarioAtual.Text = "Usuário atual:";
            // 
            // lblNomeUsuarioAtual
            // 
            this.lblNomeUsuarioAtual.Name = "lblNomeUsuarioAtual";
            this.lblNomeUsuarioAtual.Size = new System.Drawing.Size(118, 17);
            this.lblNomeUsuarioAtual.Text = "toolStripStatusLabel2";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J.M. Becker - Tornearia e Mangueiras Hidráulicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuPrincipal;
        private System.Windows.Forms.ToolStripButton btnMenuPrincipalClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnMenuPrincipalOs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnMenuPrincipalPagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMenuPrincipalReceber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMenuPrincipalAdmin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioAtual;
        private System.Windows.Forms.ToolStripStatusLabel lblNomeUsuarioAtual;
    }
}