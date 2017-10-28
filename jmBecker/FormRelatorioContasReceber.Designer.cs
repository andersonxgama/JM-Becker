namespace jmBecker
{
    partial class FormRelatorioContasReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioContasReceber));
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jmbeckerDataSet = new jmBecker.jmbeckerDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dataAteDeposito = new System.Windows.Forms.DateTimePicker();
            this.dataAtePagamento = new System.Windows.Forms.DateTimePicker();
            this.dataAte = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataDeDeposito = new System.Windows.Forms.DateTimePicker();
            this.dataDePagamento = new System.Windows.Forms.DateTimePicker();
            this.dataDe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optDeposito = new System.Windows.Forms.RadioButton();
            this.optPagamento = new System.Windows.Forms.RadioButton();
            this.optData = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable2TableAdapter = new jmBecker.jmbeckerDataSetTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmbeckerDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.jmbeckerDataSet;
            // 
            // jmbeckerDataSet
            // 
            this.jmbeckerDataSet.DataSetName = "jmbeckerDataSet";
            this.jmbeckerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.dataAteDeposito);
            this.groupBox1.Controls.Add(this.dataAtePagamento);
            this.groupBox1.Controls.Add(this.dataAte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataDeDeposito);
            this.groupBox1.Controls.Add(this.dataDePagamento);
            this.groupBox1.Controls.Add(this.dataDe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optDeposito);
            this.groupBox1.Controls.Add(this.optPagamento);
            this.groupBox1.Controls.Add(this.optData);
            this.groupBox1.Location = new System.Drawing.Point(110, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(574, 51);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(115, 33);
            this.btnGerar.TabIndex = 15;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dataAteDeposito
            // 
            this.dataAteDeposito.CustomFormat = "dd/MM/yyyy";
            this.dataAteDeposito.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAteDeposito.Location = new System.Drawing.Point(408, 92);
            this.dataAteDeposito.Name = "dataAteDeposito";
            this.dataAteDeposito.Size = new System.Drawing.Size(95, 20);
            this.dataAteDeposito.TabIndex = 14;
            // 
            // dataAtePagamento
            // 
            this.dataAtePagamento.CustomFormat = "dd/MM/yyyy";
            this.dataAtePagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAtePagamento.Location = new System.Drawing.Point(408, 57);
            this.dataAtePagamento.Name = "dataAtePagamento";
            this.dataAtePagamento.Size = new System.Drawing.Size(95, 20);
            this.dataAtePagamento.TabIndex = 13;
            // 
            // dataAte
            // 
            this.dataAte.CustomFormat = "dd/MM/yyyy";
            this.dataAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAte.Location = new System.Drawing.Point(408, 22);
            this.dataAte.Name = "dataAte";
            this.dataAte.Size = new System.Drawing.Size(95, 20);
            this.dataAte.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Até:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Até:";
            // 
            // dataDeDeposito
            // 
            this.dataDeDeposito.CustomFormat = "dd/MM/yyyy";
            this.dataDeDeposito.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDeDeposito.Location = new System.Drawing.Point(236, 92);
            this.dataDeDeposito.Name = "dataDeDeposito";
            this.dataDeDeposito.Size = new System.Drawing.Size(95, 20);
            this.dataDeDeposito.TabIndex = 8;
            // 
            // dataDePagamento
            // 
            this.dataDePagamento.CustomFormat = "dd/MM/yyyy";
            this.dataDePagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDePagamento.Location = new System.Drawing.Point(236, 57);
            this.dataDePagamento.Name = "dataDePagamento";
            this.dataDePagamento.Size = new System.Drawing.Size(95, 20);
            this.dataDePagamento.TabIndex = 7;
            // 
            // dataDe
            // 
            this.dataDe.CustomFormat = "dd/MM/yyyy";
            this.dataDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDe.Location = new System.Drawing.Point(236, 22);
            this.dataDe.Name = "dataDe";
            this.dataDe.Size = new System.Drawing.Size(95, 20);
            this.dataDe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // optDeposito
            // 
            this.optDeposito.AutoSize = true;
            this.optDeposito.Location = new System.Drawing.Point(80, 94);
            this.optDeposito.Name = "optDeposito";
            this.optDeposito.Size = new System.Drawing.Size(91, 17);
            this.optDeposito.TabIndex = 2;
            this.optDeposito.TabStop = true;
            this.optDeposito.Text = "Data depósito";
            this.optDeposito.UseVisualStyleBackColor = true;
            // 
            // optPagamento
            // 
            this.optPagamento.AutoSize = true;
            this.optPagamento.Location = new System.Drawing.Point(80, 59);
            this.optPagamento.Name = "optPagamento";
            this.optPagamento.Size = new System.Drawing.Size(104, 17);
            this.optPagamento.TabIndex = 1;
            this.optPagamento.TabStop = true;
            this.optPagamento.Text = "Data pagamento";
            this.optPagamento.UseVisualStyleBackColor = true;
            // 
            // optData
            // 
            this.optData.AutoSize = true;
            this.optData.Location = new System.Drawing.Point(80, 24);
            this.optData.Name = "optData";
            this.optData.Size = new System.Drawing.Size(48, 17);
            this.optData.TabIndex = 0;
            this.optData.TabStop = true;
            this.optData.Text = "Data";
            this.optData.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "jmBecker.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 148);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(950, 368);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Contas a Receber";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmbeckerDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DateTimePicker dataAteDeposito;
        private System.Windows.Forms.DateTimePicker dataAtePagamento;
        private System.Windows.Forms.DateTimePicker dataAte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataDeDeposito;
        private System.Windows.Forms.DateTimePicker dataDePagamento;
        private System.Windows.Forms.DateTimePicker dataDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optDeposito;
        private System.Windows.Forms.RadioButton optPagamento;
        private System.Windows.Forms.RadioButton optData;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private jmbeckerDataSet jmbeckerDataSet;
        private jmbeckerDataSetTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
    }
}