using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jmBecker
{
    public partial class FormClientes : Form
    {
        private bool editar = false;

        public FormClientes()
        {
            InitializeComponent();
        }

        //Ao carregar o FormClientes
        private void FormClientes_Load(object sender, EventArgs e)
        {
            layoutInicial();
            ClienteDAO.carregarComboClientes(cmbCliente);
        }

        //Clique do botão novo
        private void btnMenuClientesNovo_Click(object sender, EventArgs e)
        {
            layoutBtnNovo();
        }

        //Clique do botão editar
        private void btnMenuClientesEditar_Click(object sender, EventArgs e)
        {
            editar = true;

            if(optPessoaFisica.Checked == true)
            {
                grpPessoaFisica.Enabled = true;
                grpDados.Enabled = true;
            }
            else
            {
                grpPessoaJuridica.Enabled = true;
                grpDados.Enabled = true;
            }

            btnMenuClientesNovo.Enabled = false;
            btnMenuClientesEditar.Enabled = false;
            btnMenuClientesExcluir.Enabled = false;
            grpComboClientes.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //Clique do botão excluir
        private void btnMenuClientesExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se o cliente for excluído, os dados não poderão ser recuperados. Deseja continuar?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (optPessoaFisica.Checked == true)
                {
                    PessoaFisicaDAO.excluirPessoaFisica(cmbCliente.SelectedItem.ToString());
                }
                else
                {
                    PessoaJuridicaDAO.excluirPessoaJuridica(cmbCliente.SelectedItem.ToString());
                }

                MessageBox.Show("Cliente excluído com sucesso", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClienteDAO.carregarComboClientes(cmbCliente);
                layoutInicial();
            }
        }

        //Clique do botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (optPessoaFisica.Checked == true)
                {
                    if (txtNome.Text.Equals(""))
                    {
                        MessageBox.Show("É necessário preencher o campo \"Nome\"", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        PessoaFisica pessoaFisica = new PessoaFisica();

                        pessoaFisica.Nome = txtNome.Text;
                        pessoaFisica.Cpf = mskCpf.Text;
                        pessoaFisica.Rg = mskRg.Text;
                        pessoaFisica.Endereco = txtEndereco.Text;
                        pessoaFisica.Numero = txtNumero.Text;
                        pessoaFisica.Complemento = txtComplemento.Text;
                        pessoaFisica.Cep = mskCep.Text;
                        pessoaFisica.Bairro = txtBairro.Text;
                        pessoaFisica.Cidade = txtCidade.Text;
                        pessoaFisica.Uf = cmbUf.Text;
                        pessoaFisica.TelefoneResidencial = mskFoneResidencial.Text;
                        pessoaFisica.TelefoneComercial = mskFoneComercial.Text;
                        pessoaFisica.Celular = mskCelular.Text;
                        pessoaFisica.Email = txtEmail.Text;
                        pessoaFisica.Tipo = 1;
                        pessoaFisica.Observacoes = txtObservacoes.Text;

                        if (editar)
                        {
                            PessoaFisicaDAO.atualizarPessoaFisica(pessoaFisica, cmbCliente.SelectedItem.ToString());
                        }
                        else
                        {
                            PessoaFisicaDAO.incluirPessoaFisica(pessoaFisica);
                        }
                    }

                    ClienteDAO.carregarComboClientes(cmbCliente);
                    layoutInicial();
                    editar = false;
                }
                else
                {
                    if (txtNomeFantasia.Text.Equals(""))
                    {
                        MessageBox.Show("É necessário preencher o campo \"Nome fantasia\"", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        PessoaJuridica pessoaJuridica = new PessoaJuridica();

                        pessoaJuridica.RazaoSocial = txtRazaoSocial.Text;
                        pessoaJuridica.NomeFantasia = txtNomeFantasia.Text;
                        pessoaJuridica.Representante = txtRepresentante.Text;
                        pessoaJuridica.Cnpj = mskCnpj.Text;
                        pessoaJuridica.Endereco = txtEndereco.Text;
                        pessoaJuridica.Numero = txtNumero.Text;
                        pessoaJuridica.Complemento = txtComplemento.Text;
                        pessoaJuridica.Cep = mskCep.Text;
                        pessoaJuridica.Bairro = txtBairro.Text;
                        pessoaJuridica.Cidade = txtCidade.Text;
                        pessoaJuridica.Uf = cmbUf.Text;
                        pessoaJuridica.TelefoneResidencial = mskFoneResidencial.Text;
                        pessoaJuridica.TelefoneComercial = mskFoneComercial.Text;
                        pessoaJuridica.Celular = mskCelular.Text;
                        pessoaJuridica.Email = txtEmail.Text;
                        pessoaJuridica.Tipo = 2;
                        pessoaJuridica.Observacoes = txtObservacoes.Text;

                        if (editar)
                        {
                            PessoaJuridicaDAO.atualizarPessoaJuridica(pessoaJuridica, cmbCliente.SelectedItem.ToString());
                        }
                        else
                        {
                            PessoaJuridicaDAO.incluirPessoaJuridica(pessoaJuridica);
                        }
                    }

                    ClienteDAO.carregarComboClientes(cmbCliente);
                    layoutInicial();
                    editar = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao incluir/atualizar o cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clique do botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") || (txtNomeFantasia.Text != "") || (txtRazaoSocial.Text != ""))
            {
                if ((txtNome.Enabled == true) || (txtNomeFantasia.Enabled == true))
                {
                    DialogResult resposta = MessageBox.Show("Todos os dados não salvos serão perdidos. Deseja continuar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resposta == DialogResult.Yes)
                    {
                        ClienteDAO.carregarComboClientes(cmbCliente);
                        layoutInicial();
                    }
                }
                else
                {
                    ClienteDAO.carregarComboClientes(cmbCliente);
                    layoutInicial();
                }
            }
            else
            {
                ClienteDAO.carregarComboClientes(cmbCliente);
                layoutInicial();
            }

            editar = false;
        }

        //Clique do botão pesquisar (lupa)
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            desabilitaTodosGrupos();
            ClienteDAO.pesquisaNomeCliente(cmbCliente, txtPesquisarCliente.Text);
        }

        //Ao trocar o valor da combo
        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ClienteDAO.pesquisaTipoCliente(cmbCliente.SelectedItem.ToString()) == 1)
                {
                    //Pesquisando uma pessoa física
                    optPessoaFisica.Checked = true;
                    desabilitarPessoaJuridica();

                    PessoaFisica pessoaFisica = PessoaFisicaDAO.pesquisarPessaoFisica(cmbCliente.SelectedItem.ToString());

                    txtNome.Text = pessoaFisica.Nome;
                    mskCpf.Text = pessoaFisica.Cpf;
                    mskRg.Text = pessoaFisica.Rg;
                    txtEndereco.Text = pessoaFisica.Endereco;
                    txtNumero.Text = pessoaFisica.Numero;
                    txtComplemento.Text = pessoaFisica.Complemento;
                    mskCep.Text = pessoaFisica.Cep;
                    txtBairro.Text = pessoaFisica.Bairro;
                    txtCidade.Text = pessoaFisica.Cidade;
                    cmbUf.Text = pessoaFisica.Uf;
                    mskFoneResidencial.Text = pessoaFisica.TelefoneResidencial;
                    mskFoneComercial.Text = pessoaFisica.TelefoneComercial;
                    mskCelular.Text = pessoaFisica.Celular;
                    txtEmail.Text = pessoaFisica.Email;
                    txtObservacoes.Text = pessoaFisica.Observacoes;
                }
                else
                {
                    //Pesquisando uma pessoa jurídica
                    optPessoaJuridica.Checked = true;
                    desabilitarPessoaFisica();

                    PessoaJuridica pessoaJuridica = PessoaJuridicaDAO.pesquisarPessaoJuridica(cmbCliente.SelectedItem.ToString());

                    txtRazaoSocial.Text = pessoaJuridica.RazaoSocial;
                    txtNomeFantasia.Text = pessoaJuridica.NomeFantasia;
                    txtRepresentante.Text = pessoaJuridica.Representante;
                    mskCnpj.Text = pessoaJuridica.Cnpj;
                    txtEndereco.Text = pessoaJuridica.Endereco;
                    txtNumero.Text = pessoaJuridica.Numero;
                    txtComplemento.Text = pessoaJuridica.Complemento;
                    mskCep.Text = pessoaJuridica.Cep;
                    txtBairro.Text = pessoaJuridica.Bairro;
                    txtCidade.Text = pessoaJuridica.Cidade;
                    cmbUf.Text = pessoaJuridica.Uf;
                    mskFoneResidencial.Text = pessoaJuridica.TelefoneResidencial;
                    mskFoneComercial.Text = pessoaJuridica.TelefoneComercial;
                    mskCelular.Text = pessoaJuridica.Celular;
                    txtEmail.Text = pessoaJuridica.Email;
                    txtObservacoes.Text = pessoaJuridica.Observacoes;
                }

                btnMenuClientesEditar.Enabled = true;
                btnMenuClientesExcluir.Enabled = true;
            }
            catch(NullReferenceException nre)
            {
                cmbCliente.SelectedIndex = -1;
                txtPesquisarCliente.Clear();
            }
        }

        //Ao fechar o Form
        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((txtNome.Text != "") || (txtNomeFantasia.Text != ""))
            {
                if((grpPessoaFisica.Enabled == true) || (grpPessoaJuridica.Enabled == true))
                {
                    DialogResult resposta = MessageBox.Show("Todos os dados não salvos serão perdidos. Deseja continuar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resposta == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        //Layout inicial do form
        public void layoutInicial()
        {
            btnMenuClientesNovo.Enabled = true;
            btnMenuClientesEditar.Enabled = false;
            btnMenuClientesExcluir.Enabled = false;
            grpComboClientes.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            grpTipoCliente.Enabled = false;
            grpPessoaJuridica.Enabled = false;
            cmbCliente.SelectedIndex = -1;
            txtPesquisarCliente.Clear();
            desabilitaTodosGrupos();
        }

        //Layout apresentado no form ao clicar no botão novo
        public void layoutBtnNovo()
        {
            cmbCliente.SelectedIndex = -1;
            btnMenuClientesNovo.Enabled = false;
            btnMenuClientesEditar.Enabled = false;
            btnMenuClientesExcluir.Enabled = false;
            txtPesquisarCliente.Clear();
            btnCancelar.Enabled = true;
            grpComboClientes.Enabled = false;
            grpTipoCliente.Enabled = true;
            optPessoaFisica.Checked = false;
            optPessoaJuridica.Checked = false;
            desabilitaTodosGrupos();
        }

        //Desabilita grupo pessoa física, pessoa jurídica, dados e limpa seus respectivos campos
        public void desabilitaTodosGrupos()
        {
            desabilitarPessoaFisica();
            desabilitarPessoaJuridica();
            desabilitarDados();
        }

        //Desabilita grupo Pessoa física e limpa seus campos
        public void desabilitarPessoaFisica()
        {
            optPessoaFisica.Checked = false;
            grpPessoaFisica.Enabled = false;
            txtNome.Clear();
            mskCpf.Clear();
            mskRg.Clear();
        }

        //Desabilita grupo Pessoa jurídica e limpa seus campos
        public void desabilitarPessoaJuridica()
        {
            optPessoaJuridica.Checked = false;
            grpPessoaJuridica.Enabled = false;
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtRepresentante.Clear();
            mskCnpj.Clear();
        }

        //Desabilita grupo Dados e limpa seus campos
        private void desabilitarDados()
        {
            grpDados.Enabled = false;
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            mskCep.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cmbUf.SelectedIndex = -1;
            mskFoneResidencial.Clear();
            mskFoneComercial.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            txtObservacoes.Clear();
        }

        //Clique da opção pessoa física
        private void optPessoaFisica_Click(object sender, EventArgs e)
        {
            grpPessoaFisica.Enabled = true;
            desabilitarPessoaJuridica();
            desabilitarDados();
            grpDados.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        
        //Clique da opção pessoa jurídica
        private void optPessoaJuridica_Click(object sender, EventArgs e)
        {
            grpPessoaJuridica.Enabled = true;
            desabilitarPessoaFisica();
            desabilitarDados();
            grpDados.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //Estes métodos fazem o cursor se posicionar no começo de campos maskTextBox
        private void mskCnpj_Click(object sender, EventArgs e)
        {
            mskCnpj.SelectionStart = 0;
        }

        private void mskCpf_Click(object sender, EventArgs e)
        {
            mskCpf.SelectionStart = 0;
        }

        private void mskRg_Click(object sender, EventArgs e)
        {
            mskRg.SelectionStart = 0;
        }

        private void mskCep_Click(object sender, EventArgs e)
        {
            mskCep.SelectionStart = 0;
        }

        private void mskFoneResidencial_Click(object sender, EventArgs e)
        {
            mskFoneResidencial.SelectionStart = 0;
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            mskCelular.SelectionStart = 0;
        }

        private void mskFoneComercial_Click(object sender, EventArgs e)
        {
            mskFoneComercial.SelectionStart = 0;
        }
    }
}