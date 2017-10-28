namespace jmBecker
{
    partial class FormContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasPagar));
            this.menuContasPagar = new System.Windows.Forms.ToolStrip();
            this.btnNovomenuContasPagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarMenuContasPagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluirMenuContasPagar = new System.Windows.Forms.ToolStripButton();
            this.grpContasPagar = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPesquisaContasPagar = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataDeVencimento = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataAteVencimento = new System.Windows.Forms.DateTimePicker();
            this.dataAtePagamento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataDePagamento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.optDataVencimento = new System.Windows.Forms.RadioButton();
            this.optDataPagamento = new System.Windows.Forms.RadioButton();
            this.grdContasPagar = new System.Windows.Forms.DataGridView();
            this.cl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.grpSituacao = new System.Windows.Forms.GroupBox();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.optApagar = new System.Windows.Forms.RadioButton();
            this.optPago = new System.Windows.Forms.RadioButton();
            this.menuContasPagar.SuspendLayout();
            this.grpContasPagar.SuspendLayout();
            this.grpPesquisaContasPagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContasPagar)).BeginInit();
            this.grpSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContasPagar
            // 
            this.menuContasPagar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovomenuContasPagar,
            this.toolStripSeparator2,
            this.btnEditarMenuContasPagar,
            this.toolStripSeparator1,
            this.btnExcluirMenuContasPagar});
            this.menuContasPagar.Location = new System.Drawing.Point(0, 0);
            this.menuContasPagar.Name = "menuContasPagar";
            this.menuContasPagar.Size = new System.Drawing.Size(613, 25);
            this.menuContasPagar.TabIndex = 0;
            this.menuContasPagar.Text = "toolStrip1";
            // 
            // btnNovomenuContasPagar
            // 
            this.btnNovomenuContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnNovomenuContasPagar.Image")));
            this.btnNovomenuContasPagar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnNovomenuContasPagar.Name = "btnNovomenuContasPagar";
            this.btnNovomenuContasPagar.Size = new System.Drawing.Size(56, 22);
            this.btnNovomenuContasPagar.Text = "&Novo";
            this.btnNovomenuContasPagar.Click += new System.EventHandler(this.btnNovomenuContasPagar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditarMenuContasPagar
            // 
            this.btnEditarMenuContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMenuContasPagar.Image")));
            this.btnEditarMenuContasPagar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnEditarMenuContasPagar.Name = "btnEditarMenuContasPagar";
            this.btnEditarMenuContasPagar.Size = new System.Drawing.Size(57, 22);
            this.btnEditarMenuContasPagar.Text = "&Editar";
            this.btnEditarMenuContasPagar.Click += new System.EventHandler(this.btnEditarMenuContasPagar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExcluirMenuContasPagar
            // 
            this.btnExcluirMenuContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMenuContasPagar.Image")));
            this.btnExcluirMenuContasPagar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnExcluirMenuContasPagar.Name = "btnExcluirMenuContasPagar";
            this.btnExcluirMenuContasPagar.Size = new System.Drawing.Size(61, 22);
            this.btnExcluirMenuContasPagar.Text = "E&xcluir";
            this.btnExcluirMenuContasPagar.Click += new System.EventHandler(this.btnExcluirMenuContasPagar_Click);
            // 
            // grpContasPagar
            // 
            this.grpContasPagar.Controls.Add(this.txtObservacoes);
            this.grpContasPagar.Controls.Add(this.txtDescricao);
            this.grpContasPagar.Controls.Add(this.mskValor);
            this.grpContasPagar.Controls.Add(this.label3);
            this.grpContasPagar.Controls.Add(this.label2);
            this.grpContasPagar.Controls.Add(this.label1);
            this.grpContasPagar.Location = new System.Drawing.Point(12, 28);
            this.grpContasPagar.Name = "grpContasPagar";
            this.grpContasPagar.Size = new System.Drawing.Size(589, 179);
            this.grpContasPagar.TabIndex = 1;
            this.grpContasPagar.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(93, 78);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(482, 87);
            this.txtObservacoes.TabIndex = 3;
            this.txtObservacoes.Text = "";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(93, 46);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(252, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(51, 18);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(100, 20);
            this.mskValor.TabIndex = 1;
            this.mskValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // grpPesquisaContasPagar
            // 
            this.grpPesquisaContasPagar.Controls.Add(this.label9);
            this.grpPesquisaContasPagar.Controls.Add(this.label8);
            this.grpPesquisaContasPagar.Controls.Add(this.dataDeVencimento);
            this.grpPesquisaContasPagar.Controls.Add(this.btnPesquisar);
            this.grpPesquisaContasPagar.Controls.Add(this.dataAteVencimento);
            this.grpPesquisaContasPagar.Controls.Add(this.dataAtePagamento);
            this.grpPesquisaContasPagar.Controls.Add(this.label7);
            this.grpPesquisaContasPagar.Controls.Add(this.dataDePagamento);
            this.grpPesquisaContasPagar.Controls.Add(this.label6);
            this.grpPesquisaContasPagar.Controls.Add(this.optDataVencimento);
            this.grpPesquisaContasPagar.Controls.Add(this.optDataPagamento);
            this.grpPesquisaContasPagar.Location = new System.Drawing.Point(12, 286);
            this.grpPesquisaContasPagar.Name = "grpPesquisaContasPagar";
            this.grpPesquisaContasPagar.Size = new System.Drawing.Size(589, 115);
            this.grpPesquisaContasPagar.TabIndex = 2;
            this.grpPesquisaContasPagar.TabStop = false;
            this.grpPesquisaContasPagar.Text = "Pesquisar por";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "De:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Até:";
            // 
            // dataDeVencimento
            // 
            this.dataDeVencimento.CustomFormat = "dd/MM/yyyy";
            this.dataDeVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDeVencimento.Location = new System.Drawing.Point(38, 40);
            this.dataDeVencimento.Name = "dataDeVencimento";
            this.dataDeVencimento.Size = new System.Drawing.Size(97, 20);
            this.dataDeVencimento.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(246, 79);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 27);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataAteVencimento
            // 
            this.dataAteVencimento.CustomFormat = "dd/MM/yyyy";
            this.dataAteVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAteVencimento.Location = new System.Drawing.Point(184, 40);
            this.dataAteVencimento.Name = "dataAteVencimento";
            this.dataAteVencimento.Size = new System.Drawing.Size(97, 20);
            this.dataAteVencimento.TabIndex = 10;
            // 
            // dataAtePagamento
            // 
            this.dataAtePagamento.CustomFormat = "dd/MM/yyyy";
            this.dataAtePagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAtePagamento.Location = new System.Drawing.Point(479, 38);
            this.dataAtePagamento.Name = "dataAtePagamento";
            this.dataAtePagamento.Size = new System.Drawing.Size(97, 20);
            this.dataAtePagamento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Até:";
            // 
            // dataDePagamento
            // 
            this.dataDePagamento.CustomFormat = "dd/MM/yyyy";
            this.dataDePagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDePagamento.Location = new System.Drawing.Point(333, 38);
            this.dataDePagamento.Name = "dataDePagamento";
            this.dataDePagamento.Size = new System.Drawing.Size(97, 20);
            this.dataDePagamento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "De:";
            // 
            // optDataVencimento
            // 
            this.optDataVencimento.AutoSize = true;
            this.optDataVencimento.Location = new System.Drawing.Point(86, 18);
            this.optDataVencimento.Name = "optDataVencimento";
            this.optDataVencimento.Size = new System.Drawing.Size(121, 17);
            this.optDataVencimento.TabIndex = 8;
            this.optDataVencimento.TabStop = true;
            this.optDataVencimento.Text = "Data do vencimento";
            this.optDataVencimento.UseVisualStyleBackColor = true;
            this.optDataVencimento.Click += new System.EventHandler(this.optDataVencimento_Click);
            // 
            // optDataPagamento
            // 
            this.optDataPagamento.AutoSize = true;
            this.optDataPagamento.Location = new System.Drawing.Point(382, 16);
            this.optDataPagamento.Name = "optDataPagamento";
            this.optDataPagamento.Size = new System.Drawing.Size(119, 17);
            this.optDataPagamento.TabIndex = 11;
            this.optDataPagamento.TabStop = true;
            this.optDataPagamento.Text = "Data do pagamento";
            this.optDataPagamento.UseVisualStyleBackColor = true;
            this.optDataPagamento.Click += new System.EventHandler(this.optDataPagamento_Click);
            // 
            // grdContasPagar
            // 
            this.grdContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_valor,
            this.cl_dataVencimento,
            this.cl_Situacao});
            this.grdContasPagar.Location = new System.Drawing.Point(12, 407);
            this.grdContasPagar.Name = "grdContasPagar";
            this.grdContasPagar.Size = new System.Drawing.Size(589, 174);
            this.grdContasPagar.TabIndex = 3;
            this.grdContasPagar.Click += new System.EventHandler(this.grdContasPagar_Click);
            // 
            // cl_valor
            // 
            this.cl_valor.HeaderText = "Valor";
            this.cl_valor.Name = "cl_valor";
            this.cl_valor.ReadOnly = true;
            this.cl_valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_valor.Width = 95;
            // 
            // cl_dataVencimento
            // 
            this.cl_dataVencimento.HeaderText = "Data do vencimento";
            this.cl_dataVencimento.Name = "cl_dataVencimento";
            this.cl_dataVencimento.ReadOnly = true;
            this.cl_dataVencimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_dataVencimento.Width = 130;
            // 
            // cl_Situacao
            // 
            this.cl_Situacao.HeaderText = "Descrição";
            this.cl_Situacao.Name = "cl_Situacao";
            this.cl_Situacao.ReadOnly = true;
            this.cl_Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_Situacao.Width = 315;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(89, 601);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 32);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 601);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(421, 601);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(102, 32);
            this.btnRelatorio.TabIndex = 17;
            this.btnRelatorio.Text = "&Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // grpSituacao
            // 
            this.grpSituacao.Controls.Add(this.dataVencimento);
            this.grpSituacao.Controls.Add(this.dataPagamento);
            this.grpSituacao.Controls.Add(this.label5);
            this.grpSituacao.Controls.Add(this.label4);
            this.grpSituacao.Controls.Add(this.optApagar);
            this.grpSituacao.Controls.Add(this.optPago);
            this.grpSituacao.Location = new System.Drawing.Point(12, 206);
            this.grpSituacao.Name = "grpSituacao";
            this.grpSituacao.Size = new System.Drawing.Size(589, 80);
            this.grpSituacao.TabIndex = 7;
            this.grpSituacao.TabStop = false;
            this.grpSituacao.Text = "Situação";
            // 
            // dataVencimento
            // 
            this.dataVencimento.CustomFormat = "dd/MM/yyyy";
            this.dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataVencimento.Location = new System.Drawing.Point(151, 46);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(95, 20);
            this.dataVencimento.TabIndex = 5;
            this.dataVencimento.Value = new System.DateTime(2013, 11, 26, 0, 0, 0, 0);
            // 
            // dataPagamento
            // 
            this.dataPagamento.CustomFormat = "dd/MM/yyyy";
            this.dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPagamento.Location = new System.Drawing.Point(451, 46);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(95, 20);
            this.dataPagamento.TabIndex = 7;
            this.dataPagamento.Value = new System.DateTime(2013, 11, 26, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data do vencimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data do pagamento:";
            // 
            // optApagar
            // 
            this.optApagar.AutoSize = true;
            this.optApagar.Location = new System.Drawing.Point(118, 21);
            this.optApagar.Name = "optApagar";
            this.optApagar.Size = new System.Drawing.Size(63, 17);
            this.optApagar.TabIndex = 4;
            this.optApagar.TabStop = true;
            this.optApagar.Text = "A Pagar";
            this.optApagar.UseVisualStyleBackColor = true;
            this.optApagar.Click += new System.EventHandler(this.optApagar_Click);
            // 
            // optPago
            // 
            this.optPago.AutoSize = true;
            this.optPago.Location = new System.Drawing.Point(419, 21);
            this.optPago.Name = "optPago";
            this.optPago.Size = new System.Drawing.Size(50, 17);
            this.optPago.TabIndex = 6;
            this.optPago.TabStop = true;
            this.optPago.Text = "Pago";
            this.optPago.UseVisualStyleBackColor = true;
            this.optPago.Click += new System.EventHandler(this.optPago_Click);
            // 
            // FormContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 650);
            this.Controls.Add(this.grpSituacao);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grdContasPagar);
            this.Controls.Add(this.grpPesquisaContasPagar);
            this.Controls.Add(this.grpContasPagar);
            this.Controls.Add(this.menuContasPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.menuContasPagar.ResumeLayout(false);
            this.menuContasPagar.PerformLayout();
            this.grpContasPagar.ResumeLayout(false);
            this.grpContasPagar.PerformLayout();
            this.grpPesquisaContasPagar.ResumeLayout(false);
            this.grpPesquisaContasPagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContasPagar)).EndInit();
            this.grpSituacao.ResumeLayout(false);
            this.grpSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuContasPagar;
        private System.Windows.Forms.ToolStripButton btnNovomenuContasPagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditarMenuContasPagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExcluirMenuContasPagar;
        private System.Windows.Forms.GroupBox grpContasPagar;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPesquisaContasPagar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dataAteVencimento;
        private System.Windows.Forms.DateTimePicker dataAtePagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataDePagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton optDataVencimento;
        private System.Windows.Forms.RadioButton optDataPagamento;
        private System.Windows.Forms.DataGridView grdContasPagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dataDeVencimento;
        private System.Windows.Forms.GroupBox grpSituacao;
        private System.Windows.Forms.RadioButton optApagar;
        private System.Windows.Forms.RadioButton optPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Situacao;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.DateTimePicker dataPagamento;
    }
}