namespace jmBecker
{
    partial class FormOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdemServico));
            this.menuOs = new System.Windows.Forms.ToolStrip();
            this.btnMenuOsNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuOsEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuOsExcluir = new System.Windows.Forms.ToolStripButton();
            this.grpDadosClienteOs = new System.Windows.Forms.GroupBox();
            this.mskCelularOs = new System.Windows.Forms.MaskedTextBox();
            this.mskFoneComercialOs = new System.Windows.Forms.MaskedTextBox();
            this.mskFoneResidencialOs = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailOs = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpInfoOs = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.txtNumOs = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataDataOs = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpCmbClienteOs = new System.Windows.Forms.GroupBox();
            this.txtPesquisaCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscarClienteOs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClienteOs = new System.Windows.Forms.ComboBox();
            this.grpPesquisaOs = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataAteOs = new System.Windows.Forms.DateTimePicker();
            this.dataDeOs = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPesqNumOs = new System.Windows.Forms.TextBox();
            this.optData = new System.Windows.Forms.RadioButton();
            this.optNumOs = new System.Windows.Forms.RadioButton();
            this.grdOs = new System.Windows.Forms.DataGridView();
            this.cl_numos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.menuOs.SuspendLayout();
            this.grpDadosClienteOs.SuspendLayout();
            this.grpInfoOs.SuspendLayout();
            this.grpCmbClienteOs.SuspendLayout();
            this.grpPesquisaOs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOs
            // 
            this.menuOs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuOsNovo,
            this.toolStripSeparator2,
            this.btnMenuOsEditar,
            this.toolStripSeparator1,
            this.btnMenuOsExcluir});
            this.menuOs.Location = new System.Drawing.Point(0, 0);
            this.menuOs.Name = "menuOs";
            this.menuOs.Size = new System.Drawing.Size(905, 25);
            this.menuOs.TabIndex = 0;
            this.menuOs.Text = "toolStrip1";
            // 
            // btnMenuOsNovo
            // 
            this.btnMenuOsNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuOsNovo.Image")));
            this.btnMenuOsNovo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuOsNovo.Name = "btnMenuOsNovo";
            this.btnMenuOsNovo.Size = new System.Drawing.Size(56, 22);
            this.btnMenuOsNovo.Text = "&Novo";
            this.btnMenuOsNovo.Click += new System.EventHandler(this.btnMenuOsNovo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenuOsEditar
            // 
            this.btnMenuOsEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuOsEditar.Image")));
            this.btnMenuOsEditar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuOsEditar.Name = "btnMenuOsEditar";
            this.btnMenuOsEditar.Size = new System.Drawing.Size(57, 22);
            this.btnMenuOsEditar.Text = "&Editar";
            this.btnMenuOsEditar.Click += new System.EventHandler(this.btnMenuOsEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenuOsExcluir
            // 
            this.btnMenuOsExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuOsExcluir.Image")));
            this.btnMenuOsExcluir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuOsExcluir.Name = "btnMenuOsExcluir";
            this.btnMenuOsExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnMenuOsExcluir.Text = "&Excluir";
            this.btnMenuOsExcluir.Click += new System.EventHandler(this.btnMenuOsExcluir_Click);
            // 
            // grpDadosClienteOs
            // 
            this.grpDadosClienteOs.Controls.Add(this.mskCelularOs);
            this.grpDadosClienteOs.Controls.Add(this.mskFoneComercialOs);
            this.grpDadosClienteOs.Controls.Add(this.mskFoneResidencialOs);
            this.grpDadosClienteOs.Controls.Add(this.txtEmailOs);
            this.grpDadosClienteOs.Controls.Add(this.txtResponsavel);
            this.grpDadosClienteOs.Controls.Add(this.label7);
            this.grpDadosClienteOs.Controls.Add(this.label6);
            this.grpDadosClienteOs.Controls.Add(this.label5);
            this.grpDadosClienteOs.Controls.Add(this.label4);
            this.grpDadosClienteOs.Controls.Add(this.label3);
            this.grpDadosClienteOs.Controls.Add(this.txtCliente);
            this.grpDadosClienteOs.Controls.Add(this.label2);
            this.grpDadosClienteOs.Location = new System.Drawing.Point(12, 111);
            this.grpDadosClienteOs.Name = "grpDadosClienteOs";
            this.grpDadosClienteOs.Size = new System.Drawing.Size(517, 163);
            this.grpDadosClienteOs.TabIndex = 1;
            this.grpDadosClienteOs.TabStop = false;
            // 
            // mskCelularOs
            // 
            this.mskCelularOs.Location = new System.Drawing.Point(75, 106);
            this.mskCelularOs.Mask = "(00)0000-0000";
            this.mskCelularOs.Name = "mskCelularOs";
            this.mskCelularOs.ReadOnly = true;
            this.mskCelularOs.Size = new System.Drawing.Size(100, 20);
            this.mskCelularOs.TabIndex = 8;
            // 
            // mskFoneComercialOs
            // 
            this.mskFoneComercialOs.Location = new System.Drawing.Point(364, 76);
            this.mskFoneComercialOs.Mask = "(00)0000-0000";
            this.mskFoneComercialOs.Name = "mskFoneComercialOs";
            this.mskFoneComercialOs.ReadOnly = true;
            this.mskFoneComercialOs.Size = new System.Drawing.Size(100, 20);
            this.mskFoneComercialOs.TabIndex = 7;
            // 
            // mskFoneResidencialOs
            // 
            this.mskFoneResidencialOs.Location = new System.Drawing.Point(112, 76);
            this.mskFoneResidencialOs.Mask = "(00)0000-0000";
            this.mskFoneResidencialOs.Name = "mskFoneResidencialOs";
            this.mskFoneResidencialOs.ReadOnly = true;
            this.mskFoneResidencialOs.Size = new System.Drawing.Size(100, 20);
            this.mskFoneResidencialOs.TabIndex = 6;
            // 
            // txtEmailOs
            // 
            this.txtEmailOs.Location = new System.Drawing.Point(75, 136);
            this.txtEmailOs.Name = "txtEmailOs";
            this.txtEmailOs.ReadOnly = true;
            this.txtEmailOs.Size = new System.Drawing.Size(389, 20);
            this.txtEmailOs.TabIndex = 9;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(105, 46);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(359, 20);
            this.txtResponsavel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone (Com.):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone (Res.):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Responsável:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(75, 16);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(389, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // grpInfoOs
            // 
            this.grpInfoOs.Controls.Add(this.txtObservacoes);
            this.grpInfoOs.Controls.Add(this.txtNumOs);
            this.grpInfoOs.Controls.Add(this.txtDescricao);
            this.grpInfoOs.Controls.Add(this.mskValor);
            this.grpInfoOs.Controls.Add(this.label12);
            this.grpInfoOs.Controls.Add(this.dataDataOs);
            this.grpInfoOs.Controls.Add(this.label11);
            this.grpInfoOs.Controls.Add(this.label10);
            this.grpInfoOs.Controls.Add(this.label9);
            this.grpInfoOs.Controls.Add(this.label8);
            this.grpInfoOs.Location = new System.Drawing.Point(530, 24);
            this.grpInfoOs.Name = "grpInfoOs";
            this.grpInfoOs.Size = new System.Drawing.Size(363, 250);
            this.grpInfoOs.TabIndex = 2;
            this.grpInfoOs.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(92, 108);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(251, 132);
            this.txtObservacoes.TabIndex = 14;
            this.txtObservacoes.Text = "";
            // 
            // txtNumOs
            // 
            this.txtNumOs.Location = new System.Drawing.Point(113, 16);
            this.txtNumOs.Name = "txtNumOs";
            this.txtNumOs.ReadOnly = true;
            this.txtNumOs.Size = new System.Drawing.Size(81, 20);
            this.txtNumOs.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(92, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(251, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(61, 46);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(91, 20);
            this.mskValor.TabIndex = 11;
            this.mskValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValor_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Data:";
            // 
            // dataDataOs
            // 
            this.dataDataOs.CustomFormat = "dd/MM/yyyy";
            this.dataDataOs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDataOs.Location = new System.Drawing.Point(247, 46);
            this.dataDataOs.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dataDataOs.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dataDataOs.Name = "dataDataOs";
            this.dataDataOs.Size = new System.Drawing.Size(96, 20);
            this.dataDataOs.TabIndex = 12;
            this.dataDataOs.Value = new System.DateTime(2013, 11, 13, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Observações:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Descrição:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número da O.S.:";
            // 
            // grpCmbClienteOs
            // 
            this.grpCmbClienteOs.Controls.Add(this.txtPesquisaCliente);
            this.grpCmbClienteOs.Controls.Add(this.label15);
            this.grpCmbClienteOs.Controls.Add(this.btnBuscarClienteOs);
            this.grpCmbClienteOs.Controls.Add(this.label1);
            this.grpCmbClienteOs.Controls.Add(this.cmbClienteOs);
            this.grpCmbClienteOs.Location = new System.Drawing.Point(12, 24);
            this.grpCmbClienteOs.Name = "grpCmbClienteOs";
            this.grpCmbClienteOs.Size = new System.Drawing.Size(517, 92);
            this.grpCmbClienteOs.TabIndex = 3;
            this.grpCmbClienteOs.TabStop = false;
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.Location = new System.Drawing.Point(128, 20);
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(307, 20);
            this.txtPesquisaCliente.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Pesquisar cliente:";
            // 
            // btnBuscarClienteOs
            // 
            this.btnBuscarClienteOs.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteOs.Image")));
            this.btnBuscarClienteOs.Location = new System.Drawing.Point(449, 15);
            this.btnBuscarClienteOs.Name = "btnBuscarClienteOs";
            this.btnBuscarClienteOs.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarClienteOs.TabIndex = 2;
            this.btnBuscarClienteOs.UseVisualStyleBackColor = true;
            this.btnBuscarClienteOs.Click += new System.EventHandler(this.btnBuscarClienteOs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // cmbClienteOs
            // 
            this.cmbClienteOs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClienteOs.FormattingEnabled = true;
            this.cmbClienteOs.Location = new System.Drawing.Point(77, 57);
            this.cmbClienteOs.Name = "cmbClienteOs";
            this.cmbClienteOs.Size = new System.Drawing.Size(402, 21);
            this.cmbClienteOs.TabIndex = 3;
            this.cmbClienteOs.SelectedValueChanged += new System.EventHandler(this.cmbClienteOs_SelectedValueChanged);
            // 
            // grpPesquisaOs
            // 
            this.grpPesquisaOs.Controls.Add(this.btnPesquisar);
            this.grpPesquisaOs.Controls.Add(this.dataAteOs);
            this.grpPesquisaOs.Controls.Add(this.dataDeOs);
            this.grpPesquisaOs.Controls.Add(this.label14);
            this.grpPesquisaOs.Controls.Add(this.label13);
            this.grpPesquisaOs.Controls.Add(this.txtPesqNumOs);
            this.grpPesquisaOs.Controls.Add(this.optData);
            this.grpPesquisaOs.Controls.Add(this.optNumOs);
            this.grpPesquisaOs.Location = new System.Drawing.Point(12, 273);
            this.grpPesquisaOs.Name = "grpPesquisaOs";
            this.grpPesquisaOs.Size = new System.Drawing.Size(881, 66);
            this.grpPesquisaOs.TabIndex = 4;
            this.grpPesquisaOs.TabStop = false;
            this.grpPesquisaOs.Text = "Pesquisar por";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(721, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataAteOs
            // 
            this.dataAteOs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAteOs.Location = new System.Drawing.Point(542, 27);
            this.dataAteOs.Name = "dataAteOs";
            this.dataAteOs.Size = new System.Drawing.Size(96, 20);
            this.dataAteOs.TabIndex = 19;
            // 
            // dataDeOs
            // 
            this.dataDeOs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDeOs.Location = new System.Drawing.Point(392, 27);
            this.dataDeOs.Name = "dataDeOs";
            this.dataDeOs.Size = new System.Drawing.Size(96, 20);
            this.dataDeOs.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(514, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Até:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "De:";
            // 
            // txtPesqNumOs
            // 
            this.txtPesqNumOs.Location = new System.Drawing.Point(162, 27);
            this.txtPesqNumOs.Name = "txtPesqNumOs";
            this.txtPesqNumOs.Size = new System.Drawing.Size(81, 20);
            this.txtPesqNumOs.TabIndex = 16;
            // 
            // optData
            // 
            this.optData.AutoSize = true;
            this.optData.Location = new System.Drawing.Point(299, 29);
            this.optData.Name = "optData";
            this.optData.Size = new System.Drawing.Size(48, 17);
            this.optData.TabIndex = 17;
            this.optData.TabStop = true;
            this.optData.Text = "Data";
            this.optData.UseVisualStyleBackColor = true;
            this.optData.Click += new System.EventHandler(this.optData_Click);
            // 
            // optNumOs
            // 
            this.optNumOs.AutoSize = true;
            this.optNumOs.Location = new System.Drawing.Point(59, 29);
            this.optNumOs.Name = "optNumOs";
            this.optNumOs.Size = new System.Drawing.Size(101, 17);
            this.optNumOs.TabIndex = 15;
            this.optNumOs.TabStop = true;
            this.optNumOs.Text = "Número da O.S.";
            this.optNumOs.UseVisualStyleBackColor = true;
            this.optNumOs.Click += new System.EventHandler(this.optNumOs_Click);
            // 
            // grdOs
            // 
            this.grdOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_numos,
            this.cl_Data,
            this.cl_Valor,
            this.cl_descricao,
            this.cl_observacoes});
            this.grdOs.Location = new System.Drawing.Point(12, 344);
            this.grdOs.Name = "grdOs";
            this.grdOs.Size = new System.Drawing.Size(881, 163);
            this.grdOs.TabIndex = 5;
            this.grdOs.Click += new System.EventHandler(this.grdOs_Click);
            // 
            // cl_numos
            // 
            this.cl_numos.HeaderText = "Nº O.S.";
            this.cl_numos.Name = "cl_numos";
            this.cl_numos.ReadOnly = true;
            this.cl_numos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_numos.Width = 70;
            // 
            // cl_Data
            // 
            this.cl_Data.HeaderText = "Data";
            this.cl_Data.Name = "cl_Data";
            this.cl_Data.ReadOnly = true;
            this.cl_Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_Data.Width = 70;
            // 
            // cl_Valor
            // 
            this.cl_Valor.HeaderText = "Valor";
            this.cl_Valor.Name = "cl_Valor";
            this.cl_Valor.ReadOnly = true;
            this.cl_Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_Valor.Width = 95;
            // 
            // cl_descricao
            // 
            this.cl_descricao.HeaderText = "Descrição";
            this.cl_descricao.Name = "cl_descricao";
            this.cl_descricao.ReadOnly = true;
            this.cl_descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_descricao.Width = 225;
            // 
            // cl_observacoes
            // 
            this.cl_observacoes.HeaderText = "Observações";
            this.cl_observacoes.Name = "cl_observacoes";
            this.cl_observacoes.ReadOnly = true;
            this.cl_observacoes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_observacoes.Width = 360;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(189, 526);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 36);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 36);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(603, 526);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(112, 36);
            this.btnRelatorio.TabIndex = 23;
            this.btnRelatorio.Text = "&Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 579);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grdOs);
            this.Controls.Add(this.grpCmbClienteOs);
            this.Controls.Add(this.grpInfoOs);
            this.Controls.Add(this.grpDadosClienteOs);
            this.Controls.Add(this.menuOs);
            this.Controls.Add(this.grpPesquisaOs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdemServico_FormClosing);
            this.Load += new System.EventHandler(this.FormOrdemServico_Load);
            this.menuOs.ResumeLayout(false);
            this.menuOs.PerformLayout();
            this.grpDadosClienteOs.ResumeLayout(false);
            this.grpDadosClienteOs.PerformLayout();
            this.grpInfoOs.ResumeLayout(false);
            this.grpInfoOs.PerformLayout();
            this.grpCmbClienteOs.ResumeLayout(false);
            this.grpCmbClienteOs.PerformLayout();
            this.grpPesquisaOs.ResumeLayout(false);
            this.grpPesquisaOs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuOs;
        private System.Windows.Forms.ToolStripButton btnMenuOsNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMenuOsEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMenuOsExcluir;
        private System.Windows.Forms.GroupBox grpDadosClienteOs;
        private System.Windows.Forms.GroupBox grpInfoOs;
        private System.Windows.Forms.GroupBox grpCmbClienteOs;
        private System.Windows.Forms.GroupBox grpPesquisaOs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClienteOs;
        private System.Windows.Forms.MaskedTextBox mskCelularOs;
        private System.Windows.Forms.MaskedTextBox mskFoneComercialOs;
        private System.Windows.Forms.MaskedTextBox mskFoneResidencialOs;
        private System.Windows.Forms.TextBox txtEmailOs;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumOs;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dataDataOs;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dataAteOs;
        private System.Windows.Forms.DateTimePicker dataDeOs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPesqNumOs;
        private System.Windows.Forms.RadioButton optData;
        private System.Windows.Forms.RadioButton optNumOs;
        private System.Windows.Forms.DataGridView grdOs;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnBuscarClienteOs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPesquisaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_numos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_observacoes;
    }
}