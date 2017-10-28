namespace jmBecker
{
    partial class FormRelatorioOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioOrdemServico));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jmbeckerDataSet = new jmBecker.jmbeckerDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtNumOs = new System.Windows.Forms.TextBox();
            this.dataAte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.optData = new System.Windows.Forms.RadioButton();
            this.optNumOs = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdemDeServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdemDeServicoTableAdapter = new jmBecker.jmbeckerDataSetTableAdapters.OrdemDeServicoTableAdapter();
            this.DataTable1TableAdapter = new jmBecker.jmbeckerDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmbeckerDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemDeServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.jmbeckerDataSet;
            // 
            // jmbeckerDataSet
            // 
            this.jmbeckerDataSet.DataSetName = "jmbeckerDataSet";
            this.jmbeckerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.txtNumOs);
            this.groupBox1.Controls.Add(this.dataAte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataDe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optData);
            this.groupBox1.Controls.Add(this.optNumOs);
            this.groupBox1.Location = new System.Drawing.Point(61, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(559, 39);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(110, 32);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtNumOs
            // 
            this.txtNumOs.Location = new System.Drawing.Point(194, 26);
            this.txtNumOs.Name = "txtNumOs";
            this.txtNumOs.Size = new System.Drawing.Size(96, 20);
            this.txtNumOs.TabIndex = 6;
            // 
            // dataAte
            // 
            this.dataAte.CustomFormat = "dd/MM/yyyy";
            this.dataAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAte.Location = new System.Drawing.Point(357, 64);
            this.dataAte.Name = "dataAte";
            this.dataAte.Size = new System.Drawing.Size(96, 20);
            this.dataAte.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Até:";
            // 
            // dataDe
            // 
            this.dataDe.CustomFormat = "dd/MM/yyyy";
            this.dataDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDe.Location = new System.Drawing.Point(194, 64);
            this.dataDe.Name = "dataDe";
            this.dataDe.Size = new System.Drawing.Size(96, 20);
            this.dataDe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // optData
            // 
            this.optData.AutoSize = true;
            this.optData.Location = new System.Drawing.Point(85, 66);
            this.optData.Name = "optData";
            this.optData.Size = new System.Drawing.Size(51, 17);
            this.optData.TabIndex = 1;
            this.optData.TabStop = true;
            this.optData.Text = "Data:";
            this.optData.UseVisualStyleBackColor = true;
            // 
            // optNumOs
            // 
            this.optNumOs.AutoSize = true;
            this.optNumOs.Location = new System.Drawing.Point(85, 28);
            this.optNumOs.Name = "optNumOs";
            this.optNumOs.Size = new System.Drawing.Size(64, 17);
            this.optNumOs.TabIndex = 0;
            this.optNumOs.TabStop = true;
            this.optNumOs.Text = "Nº O.S.:";
            this.optNumOs.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "jmBecker.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 125);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(853, 391);
            this.reportViewer1.TabIndex = 1;
            // 
            // OrdemDeServicoBindingSource
            // 
            this.OrdemDeServicoBindingSource.DataMember = "OrdemDeServico";
            this.OrdemDeServicoBindingSource.DataSource = this.jmbeckerDataSet;
            // 
            // OrdemDeServicoTableAdapter
            // 
            this.OrdemDeServicoTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 528);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - O.S.";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmbeckerDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemDeServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optData;
        private System.Windows.Forms.RadioButton optNumOs;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtNumOs;
        private System.Windows.Forms.DateTimePicker dataAte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource OrdemDeServicoBindingSource;
        private jmbeckerDataSet jmbeckerDataSet;
        private jmbeckerDataSetTableAdapters.OrdemDeServicoTableAdapter OrdemDeServicoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private jmbeckerDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}