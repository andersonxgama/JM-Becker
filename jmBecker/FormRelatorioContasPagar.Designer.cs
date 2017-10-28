namespace jmBecker
{
    partial class FormRelatorioContasPagar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioContasPagar));
            this.ContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jmbeckerDataSet = new jmBecker.jmbeckerDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dataAteVencimentoPesquisa = new System.Windows.Forms.DateTimePicker();
            this.dataAtePagamentoPesquisa = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDePagamentoPesquisa = new System.Windows.Forms.DateTimePicker();
            this.dataDeVencimentoPesquisa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optPagamento = new System.Windows.Forms.RadioButton();
            this.optVencimento = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ContasPagarTableAdapter = new jmBecker.jmbeckerDataSetTableAdapters.ContasPagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ContasPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmbeckerDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContasPagarBindingSource
            // 
            this.ContasPagarBindingSource.DataMember = "ContasPagar";
            this.ContasPagarBindingSource.DataSource = this.jmbeckerDataSet;
            // 
            // jmbeckerDataSet
            // 
            this.jmbeckerDataSet.DataSetName = "jmbeckerDataSet";
            this.jmbeckerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.dataAteVencimentoPesquisa);
            this.groupBox1.Controls.Add(this.dataAtePagamentoPesquisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataDePagamentoPesquisa);
            this.groupBox1.Controls.Add(this.dataDeVencimentoPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optPagamento);
            this.groupBox1.Controls.Add(this.optVencimento);
            this.groupBox1.Location = new System.Drawing.Point(61, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(545, 39);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(142, 32);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dataAteVencimentoPesquisa
            // 
            this.dataAteVencimentoPesquisa.CustomFormat = "dd/MM/yyyy";
            this.dataAteVencimentoPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAteVencimentoPesquisa.Location = new System.Drawing.Point(364, 23);
            this.dataAteVencimentoPesquisa.Name = "dataAteVencimentoPesquisa";
            this.dataAteVencimentoPesquisa.Size = new System.Drawing.Size(97, 20);
            this.dataAteVencimentoPesquisa.TabIndex = 11;
            // 
            // dataAtePagamentoPesquisa
            // 
            this.dataAtePagamentoPesquisa.CustomFormat = "dd/MM/yyyy";
            this.dataAtePagamentoPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAtePagamentoPesquisa.Location = new System.Drawing.Point(364, 65);
            this.dataAtePagamentoPesquisa.Name = "dataAtePagamentoPesquisa";
            this.dataAtePagamentoPesquisa.Size = new System.Drawing.Size(97, 20);
            this.dataAtePagamentoPesquisa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Até:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Até:";
            // 
            // dataDePagamentoPesquisa
            // 
            this.dataDePagamentoPesquisa.CustomFormat = "dd/MM/yyyy";
            this.dataDePagamentoPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDePagamentoPesquisa.Location = new System.Drawing.Point(226, 65);
            this.dataDePagamentoPesquisa.Name = "dataDePagamentoPesquisa";
            this.dataDePagamentoPesquisa.Size = new System.Drawing.Size(97, 20);
            this.dataDePagamentoPesquisa.TabIndex = 6;
            // 
            // dataDeVencimentoPesquisa
            // 
            this.dataDeVencimentoPesquisa.CustomFormat = "dd/MM/yyyy";
            this.dataDeVencimentoPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDeVencimentoPesquisa.Location = new System.Drawing.Point(226, 23);
            this.dataDeVencimentoPesquisa.Name = "dataDeVencimentoPesquisa";
            this.dataDeVencimentoPesquisa.Size = new System.Drawing.Size(97, 20);
            this.dataDeVencimentoPesquisa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // optPagamento
            // 
            this.optPagamento.AutoSize = true;
            this.optPagamento.Location = new System.Drawing.Point(42, 67);
            this.optPagamento.Name = "optPagamento";
            this.optPagamento.Size = new System.Drawing.Size(119, 17);
            this.optPagamento.TabIndex = 2;
            this.optPagamento.TabStop = true;
            this.optPagamento.Text = "Data de pagamento";
            this.optPagamento.UseVisualStyleBackColor = true;
            this.optPagamento.Click += new System.EventHandler(this.optPagamento_Click);
            // 
            // optVencimento
            // 
            this.optVencimento.AutoSize = true;
            this.optVencimento.Location = new System.Drawing.Point(42, 25);
            this.optVencimento.Name = "optVencimento";
            this.optVencimento.Size = new System.Drawing.Size(121, 17);
            this.optVencimento.TabIndex = 1;
            this.optVencimento.TabStop = true;
            this.optVencimento.Text = "Data de vencimento";
            this.optVencimento.UseVisualStyleBackColor = true;
            this.optVencimento.Click += new System.EventHandler(this.optVencimento_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ContasPagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "jmBecker.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 125);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(853, 391);
            this.reportViewer1.TabIndex = 1;
            // 
            // ContasPagarTableAdapter
            // 
            this.ContasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(877, 528);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Contas a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.ContasPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmbeckerDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dataDePagamentoPesquisa;
        private System.Windows.Forms.DateTimePicker dataDeVencimentoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optPagamento;
        private System.Windows.Forms.RadioButton optVencimento;
        private System.Windows.Forms.DateTimePicker dataAteVencimentoPesquisa;
        private System.Windows.Forms.DateTimePicker dataAtePagamentoPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContasPagarBindingSource;
        private jmbeckerDataSet jmbeckerDataSet;
        private jmbeckerDataSetTableAdapters.ContasPagarTableAdapter ContasPagarTableAdapter;
    }
}