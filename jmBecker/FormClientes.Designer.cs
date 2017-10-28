namespace jmBecker
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.menuClientes = new System.Windows.Forms.ToolStrip();
            this.btnMenuClientesNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuClientesEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuClientesExcluir = new System.Windows.Forms.ToolStripButton();
            this.grpComboClientes = new System.Windows.Forms.GroupBox();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTipoCliente = new System.Windows.Forms.GroupBox();
            this.optPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.optPessoaFisica = new System.Windows.Forms.RadioButton();
            this.grpPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPessoaFisica = new System.Windows.Forms.GroupBox();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mskFoneComercial = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mskFoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuClientes.SuspendLayout();
            this.grpComboClientes.SuspendLayout();
            this.grpTipoCliente.SuspendLayout();
            this.grpPessoaJuridica.SuspendLayout();
            this.grpPessoaFisica.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuClientes
            // 
            this.menuClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuClientesNovo,
            this.toolStripSeparator2,
            this.btnMenuClientesEditar,
            this.toolStripSeparator1,
            this.btnMenuClientesExcluir});
            this.menuClientes.Location = new System.Drawing.Point(0, 0);
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(579, 25);
            this.menuClientes.TabIndex = 0;
            this.menuClientes.Text = "toolStrip1";
            // 
            // btnMenuClientesNovo
            // 
            this.btnMenuClientesNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuClientesNovo.Image")));
            this.btnMenuClientesNovo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuClientesNovo.Name = "btnMenuClientesNovo";
            this.btnMenuClientesNovo.Size = new System.Drawing.Size(56, 22);
            this.btnMenuClientesNovo.Text = "&Novo";
            this.btnMenuClientesNovo.Click += new System.EventHandler(this.btnMenuClientesNovo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenuClientesEditar
            // 
            this.btnMenuClientesEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuClientesEditar.Image")));
            this.btnMenuClientesEditar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuClientesEditar.Name = "btnMenuClientesEditar";
            this.btnMenuClientesEditar.Size = new System.Drawing.Size(57, 22);
            this.btnMenuClientesEditar.Text = "&Editar";
            this.btnMenuClientesEditar.Click += new System.EventHandler(this.btnMenuClientesEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMenuClientesExcluir
            // 
            this.btnMenuClientesExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuClientesExcluir.Image")));
            this.btnMenuClientesExcluir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnMenuClientesExcluir.Name = "btnMenuClientesExcluir";
            this.btnMenuClientesExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnMenuClientesExcluir.Text = "E&xcluir";
            this.btnMenuClientesExcluir.Click += new System.EventHandler(this.btnMenuClientesExcluir_Click);
            // 
            // grpComboClientes
            // 
            this.grpComboClientes.Controls.Add(this.txtPesquisarCliente);
            this.grpComboClientes.Controls.Add(this.label21);
            this.grpComboClientes.Controls.Add(this.btnBuscarCliente);
            this.grpComboClientes.Controls.Add(this.cmbCliente);
            this.grpComboClientes.Controls.Add(this.label1);
            this.grpComboClientes.Location = new System.Drawing.Point(12, 28);
            this.grpComboClientes.Name = "grpComboClientes";
            this.grpComboClientes.Size = new System.Drawing.Size(553, 89);
            this.grpComboClientes.TabIndex = 1;
            this.grpComboClientes.TabStop = false;
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Location = new System.Drawing.Point(148, 19);
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(307, 20);
            this.txtPesquisarCliente.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Pesquisar cliente:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(466, 14);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(99, 54);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(407, 21);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // grpTipoCliente
            // 
            this.grpTipoCliente.Controls.Add(this.optPessoaJuridica);
            this.grpTipoCliente.Controls.Add(this.optPessoaFisica);
            this.grpTipoCliente.Location = new System.Drawing.Point(81, 120);
            this.grpTipoCliente.Name = "grpTipoCliente";
            this.grpTipoCliente.Size = new System.Drawing.Size(419, 49);
            this.grpTipoCliente.TabIndex = 2;
            this.grpTipoCliente.TabStop = false;
            this.grpTipoCliente.Text = "Tipo do cliente";
            // 
            // optPessoaJuridica
            // 
            this.optPessoaJuridica.AutoSize = true;
            this.optPessoaJuridica.Location = new System.Drawing.Point(255, 20);
            this.optPessoaJuridica.Name = "optPessoaJuridica";
            this.optPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.optPessoaJuridica.TabIndex = 5;
            this.optPessoaJuridica.TabStop = true;
            this.optPessoaJuridica.Text = "Pessoa Jurídica";
            this.optPessoaJuridica.UseVisualStyleBackColor = true;
            this.optPessoaJuridica.Click += new System.EventHandler(this.optPessoaJuridica_Click);
            // 
            // optPessoaFisica
            // 
            this.optPessoaFisica.AutoSize = true;
            this.optPessoaFisica.Location = new System.Drawing.Point(63, 20);
            this.optPessoaFisica.Name = "optPessoaFisica";
            this.optPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.optPessoaFisica.TabIndex = 4;
            this.optPessoaFisica.TabStop = true;
            this.optPessoaFisica.Text = "Pessoa Física";
            this.optPessoaFisica.UseVisualStyleBackColor = true;
            this.optPessoaFisica.Click += new System.EventHandler(this.optPessoaFisica_Click);
            // 
            // grpPessoaJuridica
            // 
            this.grpPessoaJuridica.Controls.Add(this.txtRazaoSocial);
            this.grpPessoaJuridica.Controls.Add(this.label20);
            this.grpPessoaJuridica.Controls.Add(this.mskCnpj);
            this.grpPessoaJuridica.Controls.Add(this.label4);
            this.grpPessoaJuridica.Controls.Add(this.txtRepresentante);
            this.grpPessoaJuridica.Controls.Add(this.label3);
            this.grpPessoaJuridica.Controls.Add(this.txtNomeFantasia);
            this.grpPessoaJuridica.Controls.Add(this.label2);
            this.grpPessoaJuridica.Location = new System.Drawing.Point(12, 170);
            this.grpPessoaJuridica.Name = "grpPessoaJuridica";
            this.grpPessoaJuridica.Size = new System.Drawing.Size(553, 109);
            this.grpPessoaJuridica.TabIndex = 3;
            this.grpPessoaJuridica.TabStop = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(99, 19);
            this.txtRazaoSocial.MaxLength = 80;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(430, 20);
            this.txtRazaoSocial.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Razão social:";
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(422, 79);
            this.mskCnpj.Mask = "99.999.999/9999-99";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(107, 20);
            this.mskCnpj.TabIndex = 9;
            this.mskCnpj.Click += new System.EventHandler(this.mskCnpj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CNPJ:";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Location = new System.Drawing.Point(99, 79);
            this.txtRepresentante.MaxLength = 50;
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(220, 20);
            this.txtRepresentante.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Representante:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(99, 49);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(430, 20);
            this.txtNomeFantasia.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome fantasia:";
            // 
            // grpPessoaFisica
            // 
            this.grpPessoaFisica.Controls.Add(this.mskRg);
            this.grpPessoaFisica.Controls.Add(this.mskCpf);
            this.grpPessoaFisica.Controls.Add(this.label7);
            this.grpPessoaFisica.Controls.Add(this.label6);
            this.grpPessoaFisica.Controls.Add(this.txtNome);
            this.grpPessoaFisica.Controls.Add(this.label5);
            this.grpPessoaFisica.Location = new System.Drawing.Point(12, 276);
            this.grpPessoaFisica.Name = "grpPessoaFisica";
            this.grpPessoaFisica.Size = new System.Drawing.Size(553, 50);
            this.grpPessoaFisica.TabIndex = 4;
            this.grpPessoaFisica.TabStop = false;
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(454, 17);
            this.mskRg.Mask = "0.000.000 0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(75, 20);
            this.mskRg.TabIndex = 12;
            this.mskRg.Click += new System.EventHandler(this.mskRg_Click);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(312, 17);
            this.mskCpf.Mask = "000.000.000 00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(87, 20);
            this.mskCpf.TabIndex = 11;
            this.mskCpf.Click += new System.EventHandler(this.mskCpf_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 17);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtObservacoes);
            this.grpDados.Controls.Add(this.label19);
            this.grpDados.Controls.Add(this.txtEmail);
            this.grpDados.Controls.Add(this.label18);
            this.grpDados.Controls.Add(this.mskFoneComercial);
            this.grpDados.Controls.Add(this.mskCelular);
            this.grpDados.Controls.Add(this.label17);
            this.grpDados.Controls.Add(this.label16);
            this.grpDados.Controls.Add(this.mskFoneResidencial);
            this.grpDados.Controls.Add(this.cmbUf);
            this.grpDados.Controls.Add(this.label15);
            this.grpDados.Controls.Add(this.txtCidade);
            this.grpDados.Controls.Add(this.label14);
            this.grpDados.Controls.Add(this.txtBairro);
            this.grpDados.Controls.Add(this.label13);
            this.grpDados.Controls.Add(this.label12);
            this.grpDados.Controls.Add(this.mskCep);
            this.grpDados.Controls.Add(this.label11);
            this.grpDados.Controls.Add(this.txtComplemento);
            this.grpDados.Controls.Add(this.label10);
            this.grpDados.Controls.Add(this.txtNumero);
            this.grpDados.Controls.Add(this.label9);
            this.grpDados.Controls.Add(this.txtEndereco);
            this.grpDados.Controls.Add(this.label8);
            this.grpDados.Location = new System.Drawing.Point(12, 324);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(553, 231);
            this.grpDados.TabIndex = 5;
            this.grpDados.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(91, 134);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(438, 80);
            this.txtObservacoes.TabIndex = 24;
            this.txtObservacoes.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Observações:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 101);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "E-mail:";
            // 
            // mskFoneComercial
            // 
            this.mskFoneComercial.Location = new System.Drawing.Point(443, 73);
            this.mskFoneComercial.Mask = "(00)0000-0000";
            this.mskFoneComercial.Name = "mskFoneComercial";
            this.mskFoneComercial.Size = new System.Drawing.Size(86, 20);
            this.mskFoneComercial.TabIndex = 22;
            this.mskFoneComercial.Click += new System.EventHandler(this.mskFoneComercial_Click);
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(251, 73);
            this.mskCelular.Mask = "(00)0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(86, 20);
            this.mskCelular.TabIndex = 21;
            this.mskCelular.Click += new System.EventHandler(this.mskCelular_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Telefone (Com.)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Celular:";
            // 
            // mskFoneResidencial
            // 
            this.mskFoneResidencial.Location = new System.Drawing.Point(98, 73);
            this.mskFoneResidencial.Mask = "(00)0000-0000";
            this.mskFoneResidencial.Name = "mskFoneResidencial";
            this.mskFoneResidencial.Size = new System.Drawing.Size(86, 20);
            this.mskFoneResidencial.TabIndex = 20;
            this.mskFoneResidencial.Click += new System.EventHandler(this.mskFoneResidencial_Click);
            // 
            // cmbUf
            // 
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(490, 45);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(39, 21);
            this.cmbUf.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(461, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(352, 45);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(94, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(305, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(176, 45);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(107, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Telefone (Res.):";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(53, 45);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(64, 20);
            this.mskCep.TabIndex = 16;
            this.mskCep.Click += new System.EventHandler(this.mskCep_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(470, 14);
            this.txtComplemento.MaxLength = 10;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(59, 20);
            this.txtComplemento.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Compl.:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(350, 14);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(59, 20);
            this.txtNumero.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nº:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(71, 14);
            this.txtEndereco.MaxLength = 80;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(231, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Endereço:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(119, 571);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 31);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(349, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 31);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 617);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpTipoCliente);
            this.Controls.Add(this.grpComboClientes);
            this.Controls.Add(this.menuClientes);
            this.Controls.Add(this.grpPessoaJuridica);
            this.Controls.Add(this.grpPessoaFisica);
            this.Controls.Add(this.grpDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.menuClientes.ResumeLayout(false);
            this.menuClientes.PerformLayout();
            this.grpComboClientes.ResumeLayout(false);
            this.grpComboClientes.PerformLayout();
            this.grpTipoCliente.ResumeLayout(false);
            this.grpTipoCliente.PerformLayout();
            this.grpPessoaJuridica.ResumeLayout(false);
            this.grpPessoaJuridica.PerformLayout();
            this.grpPessoaFisica.ResumeLayout(false);
            this.grpPessoaFisica.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuClientes;
        private System.Windows.Forms.ToolStripButton btnMenuClientesNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMenuClientesEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMenuClientesExcluir;
        private System.Windows.Forms.GroupBox grpComboClientes;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTipoCliente;
        private System.Windows.Forms.RadioButton optPessoaJuridica;
        private System.Windows.Forms.RadioButton optPessoaFisica;
        private System.Windows.Forms.GroupBox grpPessoaJuridica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.GroupBox grpPessoaFisica;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mskFoneComercial;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskFoneResidencial;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.Label label21;
    }
}