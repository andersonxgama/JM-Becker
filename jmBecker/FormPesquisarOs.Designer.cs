namespace jmBecker
{
    partial class FormPesquisarOs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarOs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisaClienteOs = new System.Windows.Forms.Button();
            this.txtPesquisaClienteOs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisarOsNumOs = new System.Windows.Forms.TextBox();
            this.dataPesquisarOsAte = new System.Windows.Forms.DateTimePicker();
            this.dataPesquisarOsDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optPesquisarOsData = new System.Windows.Forms.RadioButton();
            this.optPesquisarOsNumOs = new System.Windows.Forms.RadioButton();
            this.cmbPesquisaClienteOs = new System.Windows.Forms.ComboBox();
            this.optPesquisarOsCliente = new System.Windows.Forms.RadioButton();
            this.grdPesquisarOs = new System.Windows.Forms.DataGridView();
            this.cl_numOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisarOs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisaClienteOs);
            this.groupBox1.Controls.Add(this.txtPesquisaClienteOs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisarOsNumOs);
            this.groupBox1.Controls.Add(this.dataPesquisarOsAte);
            this.groupBox1.Controls.Add(this.dataPesquisarOsDe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optPesquisarOsData);
            this.groupBox1.Controls.Add(this.optPesquisarOsNumOs);
            this.groupBox1.Controls.Add(this.cmbPesquisaClienteOs);
            this.groupBox1.Controls.Add(this.optPesquisarOsCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisaClienteOs
            // 
            this.btnPesquisaClienteOs.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaClienteOs.Image")));
            this.btnPesquisaClienteOs.Location = new System.Drawing.Point(393, 19);
            this.btnPesquisaClienteOs.Name = "btnPesquisaClienteOs";
            this.btnPesquisaClienteOs.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisaClienteOs.TabIndex = 11;
            this.btnPesquisaClienteOs.UseVisualStyleBackColor = true;
            this.btnPesquisaClienteOs.Click += new System.EventHandler(this.btnPesquisaClienteOs_Click);
            // 
            // txtPesquisaClienteOs
            // 
            this.txtPesquisaClienteOs.Location = new System.Drawing.Point(133, 24);
            this.txtPesquisaClienteOs.Name = "txtPesquisaClienteOs";
            this.txtPesquisaClienteOs.Size = new System.Drawing.Size(249, 20);
            this.txtPesquisaClienteOs.TabIndex = 10;
            this.txtPesquisaClienteOs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaClienteOs_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pesquisar cliente:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(740, 62);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 25);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisarOsNumOs
            // 
            this.txtPesquisarOsNumOs.Location = new System.Drawing.Point(599, 64);
            this.txtPesquisarOsNumOs.Name = "txtPesquisarOsNumOs";
            this.txtPesquisarOsNumOs.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisarOsNumOs.TabIndex = 7;
            // 
            // dataPesquisarOsAte
            // 
            this.dataPesquisarOsAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPesquisarOsAte.Location = new System.Drawing.Point(767, 20);
            this.dataPesquisarOsAte.Name = "dataPesquisarOsAte";
            this.dataPesquisarOsAte.Size = new System.Drawing.Size(95, 20);
            this.dataPesquisarOsAte.TabIndex = 6;
            // 
            // dataPesquisarOsDe
            // 
            this.dataPesquisarOsDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPesquisarOsDe.Location = new System.Drawing.Point(625, 20);
            this.dataPesquisarOsDe.Name = "dataPesquisarOsDe";
            this.dataPesquisarOsDe.Size = new System.Drawing.Size(95, 20);
            this.dataPesquisarOsDe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // optPesquisarOsData
            // 
            this.optPesquisarOsData.AutoSize = true;
            this.optPesquisarOsData.Location = new System.Drawing.Point(527, 22);
            this.optPesquisarOsData.Name = "optPesquisarOsData";
            this.optPesquisarOsData.Size = new System.Drawing.Size(51, 17);
            this.optPesquisarOsData.TabIndex = 2;
            this.optPesquisarOsData.TabStop = true;
            this.optPesquisarOsData.Text = "Data:";
            this.optPesquisarOsData.UseVisualStyleBackColor = true;
            this.optPesquisarOsData.Click += new System.EventHandler(this.optPesquisarOsData_Click);
            // 
            // optPesquisarOsNumOs
            // 
            this.optPesquisarOsNumOs.AutoSize = true;
            this.optPesquisarOsNumOs.Location = new System.Drawing.Point(527, 66);
            this.optPesquisarOsNumOs.Name = "optPesquisarOsNumOs";
            this.optPesquisarOsNumOs.Size = new System.Drawing.Size(70, 17);
            this.optPesquisarOsNumOs.TabIndex = 1;
            this.optPesquisarOsNumOs.TabStop = true;
            this.optPesquisarOsNumOs.Text = "Nº.  O.S.:";
            this.optPesquisarOsNumOs.UseVisualStyleBackColor = true;
            this.optPesquisarOsNumOs.Click += new System.EventHandler(this.optPesquisarOsNumOs_Click);
            // 
            // cmbPesquisaClienteOs
            // 
            this.cmbPesquisaClienteOs.AllowDrop = true;
            this.cmbPesquisaClienteOs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisaClienteOs.Location = new System.Drawing.Point(90, 58);
            this.cmbPesquisaClienteOs.Name = "cmbPesquisaClienteOs";
            this.cmbPesquisaClienteOs.Size = new System.Drawing.Size(344, 21);
            this.cmbPesquisaClienteOs.TabIndex = 0;
            this.cmbPesquisaClienteOs.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisaClienteOs_SelectedIndexChanged);
            // 
            // optPesquisarOsCliente
            // 
            this.optPesquisarOsCliente.AutoSize = true;
            this.optPesquisarOsCliente.Location = new System.Drawing.Point(29, 60);
            this.optPesquisarOsCliente.Name = "optPesquisarOsCliente";
            this.optPesquisarOsCliente.Size = new System.Drawing.Size(57, 17);
            this.optPesquisarOsCliente.TabIndex = 0;
            this.optPesquisarOsCliente.TabStop = true;
            this.optPesquisarOsCliente.Text = "Cliente";
            this.optPesquisarOsCliente.UseVisualStyleBackColor = true;
            this.optPesquisarOsCliente.Click += new System.EventHandler(this.optPesquisarOsCliente_Click);
            // 
            // grdPesquisarOs
            // 
            this.grdPesquisarOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisarOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_numOs,
            this.cl_data,
            this.cl_valor,
            this.cl_descricao,
            this.cl_observacoes});
            this.grdPesquisarOs.Location = new System.Drawing.Point(12, 109);
            this.grdPesquisarOs.Name = "grdPesquisarOs";
            this.grdPesquisarOs.Size = new System.Drawing.Size(881, 185);
            this.grdPesquisarOs.TabIndex = 1;
            this.grdPesquisarOs.DoubleClick += new System.EventHandler(this.grdPesquisarOs_DoubleClick);
            // 
            // cl_numOs
            // 
            this.cl_numOs.HeaderText = "Nº O.S.";
            this.cl_numOs.Name = "cl_numOs";
            this.cl_numOs.ReadOnly = true;
            this.cl_numOs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_numOs.Width = 70;
            // 
            // cl_data
            // 
            this.cl_data.HeaderText = "Data";
            this.cl_data.Name = "cl_data";
            this.cl_data.ReadOnly = true;
            this.cl_data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_data.Width = 70;
            // 
            // cl_valor
            // 
            this.cl_valor.HeaderText = "Valor";
            this.cl_valor.Name = "cl_valor";
            this.cl_valor.ReadOnly = true;
            this.cl_valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_valor.Width = 95;
            // 
            // cl_descricao
            // 
            this.cl_descricao.HeaderText = "Descrição";
            this.cl_descricao.Name = "cl_descricao";
            this.cl_descricao.ReadOnly = true;
            this.cl_descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_descricao.Width = 250;
            // 
            // cl_observacoes
            // 
            this.cl_observacoes.HeaderText = "Observações";
            this.cl_observacoes.Name = "cl_observacoes";
            this.cl_observacoes.ReadOnly = true;
            this.cl_observacoes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_observacoes.Width = 350;
            // 
            // FormPesquisarOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 315);
            this.Controls.Add(this.grdPesquisarOs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisarOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar O.S.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisarOs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPesquisarOsData;
        private System.Windows.Forms.RadioButton optPesquisarOsNumOs;
        private System.Windows.Forms.ComboBox cmbPesquisaClienteOs;
        private System.Windows.Forms.RadioButton optPesquisarOsCliente;
        private System.Windows.Forms.DateTimePicker dataPesquisarOsAte;
        private System.Windows.Forms.DateTimePicker dataPesquisarOsDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisarOsNumOs;
        private System.Windows.Forms.DataGridView grdPesquisarOs;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisaClienteOs;
        private System.Windows.Forms.TextBox txtPesquisaClienteOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_numOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_observacoes;
    }
}