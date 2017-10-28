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
using System.Data.SqlTypes;

namespace jmBecker
{
    public partial class FormOrdemServico : Form
    {
        private Boolean editar = false;

        public FormOrdemServico()
        {
            InitializeComponent();
            ClienteDAO.carregarComboClientes(cmbClienteOs);
        }

        //Ao carregar o Form
        private void FormOrdemServico_Load(object sender, EventArgs e)
        {
            layoutInicial();
        }

        //Clique do botão novo
        private void btnMenuOsNovo_Click(object sender, EventArgs e)
        {
            layoutBtnNovo();
        }

        //Clique do botão editar
        private void btnMenuOsEditar_Click(object sender, EventArgs e)
        {
            grdOs.Enabled = false;
            grpInfoOs.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnMenuOsNovo.Enabled = false;
            btnMenuOsEditar.Enabled = false;
            btnMenuOsExcluir.Enabled = false;
            editar = true;
        }

        //Clique do botão excluir
        private void btnMenuOsExcluir_Click(object sender, EventArgs e)
        {
            OrdemServicoDAO.excluirOrdemDeServico(int.Parse(txtNumOs.Text));

            if (MessageBox.Show("Se a O.S. for excluída, os dados não poderão ser recuperados. Deseja continuar?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                OrdemServicoDAO.excluirOrdemDeServico(int.Parse(txtNumOs.Text));

                if (ClienteDAO.pesquisaTipoCliente(cmbClienteOs.SelectedItem.ToString()) == 1)
                {
                    OrdemServicoDAO.preencherGridOsIdCliente(grdOs, PessoaFisicaDAO.consultaIdPessoaFisica(cmbClienteOs.SelectedItem.ToString()));
                }
                else
                {
                    OrdemServicoDAO.preencherGridOsIdCliente(grdOs, PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbClienteOs.SelectedItem.ToString()));
                }

                limparCamposInfoOs();
                btnMenuOsEditar.Enabled = false;
                btnMenuOsExcluir.Enabled = false;
            }
        }

        //Ao trocar o valor da combo
        private void cmbClienteOs_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((mskValor.Text != "") && (mskValor.Enabled == true))
            {
                if ((MessageBox.Show("Os dados ainda não salvos serão perdidos. Deseja continuar?", "Dados - O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                {
                    limparCamposInfoOs();
                    carregaDadosCliente();
                    btnMenuOsEditar.Enabled = false;
                    btnMenuOsExcluir.Enabled = false;
                }
            }
            else
            {
                limparCamposInfoOs();
                carregaDadosCliente();
                btnMenuOsEditar.Enabled = false;
                btnMenuOsExcluir.Enabled = false;
                btnCancelar.Enabled = true;
            }
        }

        //Ao clicar no botão buscar (lupa)
        private void btnBuscarClienteOs_Click(object sender, EventArgs e)
        {
            limparCamposDadosCliente();
            ClienteDAO.pesquisaNomeCliente(cmbClienteOs, txtPesquisaCliente.Text);
            grdOs.Rows.Clear();
            limparCamposInfoOs();
        }

        //Ao clicar no botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(optNumOs.Checked == true)
            {
                grdOs.Rows.Clear();
                OrdemServicoDAO.preencherGridPorNumeroOs(grdOs, int.Parse(txtPesqNumOs.Text));
            }
            else
            {
                grdOs.Rows.Clear();
                OrdemServicoDAO.preencherGridPorData(grdOs, dataDeOs.Value.Date, dataAteOs.Value.Date);
            }
        }

        //Preenche os campos de acordo com o valor que é mudado na combo
        private void carregaDadosCliente()
        {
            if (ClienteDAO.pesquisaTipoCliente(cmbClienteOs.SelectedItem.ToString()) == 1)//Pesquisando uma pessoa física
            {
                limparCamposDadosCliente();

                PessoaFisica pessoaFisica = PessoaFisicaDAO.pesquisarPessaoFisica(cmbClienteOs.SelectedItem.ToString());

                txtCliente.Text = pessoaFisica.Nome;
                mskFoneResidencialOs.Text = pessoaFisica.TelefoneResidencial;
                mskFoneComercialOs.Text = pessoaFisica.TelefoneComercial;
                mskCelularOs.Text = pessoaFisica.Celular;
                txtEmailOs.Text = pessoaFisica.Email;
                OrdemServicoDAO.preencherGridOsIdCliente(grdOs, PessoaFisicaDAO.consultaIdPessoaFisica(cmbClienteOs.SelectedItem.ToString()));
            }
            else
            {
                limparCamposDadosCliente();

                PessoaJuridica pessoaJuridica = PessoaJuridicaDAO.pesquisarPessaoJuridica(cmbClienteOs.SelectedItem.ToString());//Pesquisando uma pessoa jurídica

                txtCliente.Text = pessoaJuridica.NomeFantasia;
                txtResponsavel.Text = pessoaJuridica.Representante;
                mskFoneResidencialOs.Text = pessoaJuridica.TelefoneResidencial;
                mskFoneComercialOs.Text = pessoaJuridica.TelefoneComercial;
                mskCelularOs.Text = pessoaJuridica.Celular;
                txtEmailOs.Text = pessoaJuridica.Email;
                OrdemServicoDAO.preencherGridOsIdCliente(grdOs, PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbClienteOs.SelectedItem.ToString()));
            }
        }

        //Evento que ocorre ao fechar o form
        private void FormOrdemServico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((txtNumOs.Text != "") && (mskValor.Enabled == true))
            {
                DialogResult resposta = MessageBox.Show("Todos os dados não salvos serão perdidos. Deseja continuar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //Clique do botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(editar)//Ao clicar no botão editar - Parte que faz o UPDATE
                {
                    OrdemServico os = new OrdemServico();

                    String nome = grdOs.CurrentRow.Cells[4].Value.ToString();

                    os.Id = int.Parse(txtNumOs.Text);  
                    os.Valor = SqlDecimal.Parse(mskValor.Text.Replace(",","."));
                    os.Data = dataDataOs.Value.Date;
                    os.Descricao = txtDescricao.Text;
                    os.Observacoes = txtObservacoes.Text;

                    OrdemServicoDAO.atualizarOrdemDeServico(os);
                    grdOs.Rows.Clear();
                    editar = false;

                    if(cmbClienteOs.Text.Equals(""))
                    {
                        if (optNumOs.Checked == true)//Edita os dados ao fazer uma pesquisa por Número de O.S, atualizando na grid somente a O.S. em questão
                        {
                            if (ClienteDAO.pesquisaTipoCliente(nome) == 1)
                            {
                                OrdemServicoDAO.preencherGridPorNumeroOs(grdOs, int.Parse(txtPesqNumOs.Text));
                            }
                            else
                            {
                                OrdemServicoDAO.preencherGridPorNumeroOs(grdOs, int.Parse(txtPesqNumOs.Text));
                            }
                        }
                        else//Edita os dados ao fazer uma pesquisa por Data, atualizando na grid somente a O.S. em questão
                        {
                            if (ClienteDAO.pesquisaTipoCliente(nome) == 1)
                            {
                                OrdemServicoDAO.preencherGridPorData(grdOs, dataDeOs.Value.Date, dataAteOs.Value.Date);
                            }
                            else
                            {
                                OrdemServicoDAO.preencherGridPorData(grdOs, dataDeOs.Value.Date, dataAteOs.Value.Date);
                            }
                        }
                    }
                    else//Edita os dados de O.S. ao fazer uma pesquisa por Número de O.S, atualizando na grid todas O.S's. do cliente selecionado na combo
                    {
                        if (ClienteDAO.pesquisaTipoCliente(cmbClienteOs.SelectedItem.ToString()) == 1)
                        {
                            PessoaFisica pessoaFisica = new PessoaFisica();
                            pessoaFisica.Id = PessoaFisicaDAO.consultaIdPessoaFisica(cmbClienteOs.SelectedItem.ToString());
                            OrdemServicoDAO.preencherGridOsIdCliente(grdOs, pessoaFisica.Id);
                        }
                        else
                        {
                            PessoaJuridica pessoaJuridica = new PessoaJuridica();
                            pessoaJuridica.Id = PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbClienteOs.SelectedItem.ToString());
                            OrdemServicoDAO.preencherGridOsIdCliente(grdOs, pessoaJuridica.Id);
                        }
                    }

                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    limparCamposInfoOs();
                    grdOs.Enabled = true;
                }
                else//Ao clicar no botão editar - Parte que faz o INSERT
                {
                    if (mskValor.Text.Equals("") || (txtDescricao.Text.Equals("")))
                    {
                        MessageBox.Show("Preencha todos os dados referentes a O.S.", "O.S. - Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        OrdemServico ordemServico = new OrdemServico();

                        if (mskValor.Text.Contains(","))
                        {
                            ordemServico.Valor = SqlDecimal.Parse(mskValor.Text.Replace(",", "."));
                        }
                        else
                        {
                            ordemServico.Valor = SqlDecimal.Parse(mskValor.Text);
                        }

                        ordemServico.Data = dataDataOs.Value.Date;
                        ordemServico.Descricao = txtDescricao.Text;
                        ordemServico.Observacoes = txtObservacoes.Text;

                        if (ClienteDAO.pesquisaTipoCliente(cmbClienteOs.SelectedItem.ToString()) == 1)
                        {
                            PessoaFisica pessoaFisica = new PessoaFisica();
                            pessoaFisica.Id = PessoaFisicaDAO.consultaIdPessoaFisica(cmbClienteOs.SelectedItem.ToString());
                            OrdemServicoDAO.incluirOsPessoaFisica(ordemServico, cmbClienteOs.SelectedItem.ToString());
                            OrdemServicoDAO.preencherGridOsIdCliente(grdOs, pessoaFisica.Id);
                        }
                        else
                        {
                            PessoaJuridica pessoaJuridica = new PessoaJuridica();
                            pessoaJuridica.Id = PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbClienteOs.SelectedItem.ToString());
                            OrdemServicoDAO.incluirOsPessoaJuridica(ordemServico, cmbClienteOs.SelectedItem.ToString());
                            OrdemServicoDAO.preencherGridOsIdCliente(grdOs, pessoaJuridica.Id);
                        }

                        limparCamposInfoOs();
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir a O.S.!\n" + ex.Message, "Erro - O.S.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clique do botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((mskValor.Text != "") || (txtDescricao.Text != "") || (txtObservacoes.Text != ""))
                {
                    if ((MessageBox.Show("Os dados de O.S. já digitados referentes a este cliente serão perdidos. Continuar?", "Dados - O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                    {
                        limparCamposInfoOs();
                        carregaDadosCliente();
                        limparCamposDadosCliente();
                        cmbClienteOs.SelectedIndex = -1;
                        grdOs.Enabled = true;
                        editar = false;
                        btnMenuOsNovo.Enabled = true;
                    }
                }
                else
                {
                    limparCamposInfoOs();
                    carregaDadosCliente();
                    limparCamposDadosCliente();
                    cmbClienteOs.SelectedIndex = -1;
                    grdOs.Enabled = true;
                    editar = false;
                }
            }
            catch(NullReferenceException nre)
            {
                cmbClienteOs.SelectedIndex = -1;
                txtPesquisaCliente.Clear();
                grdOs.Rows.Clear();
                grdOs.Enabled = true;
                btnMenuOsNovo.Enabled = true;
                editar = false;
            }

            layoutInicial();
        }

        //Ao digitar valores no campo valor
        private void mskValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite somente a entrada de números ou de vírgula
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        //Ao clicar em uma das linhas da grid
        private void grdOs_Click(object sender, EventArgs e)
        {
            txtNumOs.Text = grdOs.CurrentRow.Cells[0].Value.ToString();
            dataDataOs.Text = grdOs.CurrentRow.Cells[1].Value.ToString();
            mskValor.Text = grdOs.CurrentRow.Cells[2].Value.ToString().Replace("R$", "");
            txtDescricao.Text = grdOs.CurrentRow.Cells[3].Value.ToString();

            if (grdOs.Columns[4].HeaderText == "Cliente")
            {
                txtObservacoes.Text = OrdemServicoDAO.carregarObservacao(Convert.ToInt32(grdOs.CurrentRow.Cells[0].Value));
            }
            else
            {
                txtObservacoes.Text = grdOs.CurrentRow.Cells[4].Value.ToString();
            }

            btnMenuOsEditar.Enabled = true;
            btnMenuOsExcluir.Enabled = true;
        }

        //Clique da opção Número da O.S.
        private void optNumOs_Click(object sender, EventArgs e)
        {
            dataDeOs.Enabled = false;
            dataAteOs.Enabled = false;
            dataDeOs.Value = DateTime.Now;
            dataAteOs.Value = DateTime.Now;
            txtPesqNumOs.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        //Clique da opção Data
        private void optData_Click(object sender, EventArgs e)
        {
            txtPesqNumOs.Enabled = false;
            txtPesqNumOs.Clear();
            dataDeOs.Enabled = true;
            dataAteOs.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        //Layout inicial
        private void layoutInicial()
        {
            grpInfoOs.Enabled = false;
            grpDadosClienteOs.Enabled = false;
            btnRelatorio.Enabled = false;
            btnMenuOsEditar.Enabled = false;
            btnMenuOsExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            dataDataOs.Value = DateTime.Now;
            dataDeOs.Value = DateTime.Now;
            dataAteOs.Value = DateTime.Now;
            dataDeOs.Enabled = false;
            dataAteOs.Enabled = false;
            txtPesqNumOs.Clear();
            txtPesqNumOs.Enabled = false;
            btnPesquisar.Enabled = false;
            optNumOs.Checked = false;
            optData.Checked = false;
            grdOs.AllowUserToAddRows = false;
            btnRelatorio.Enabled = true;
        }

        //Layout apresentado ao clicar no botão novo
        private void layoutBtnNovo()
        {
            if (txtCliente.Text.Equals(""))
            {
                MessageBox.Show("Só é possível gerar uma nova O.S. após selecionar um cliente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                grpInfoOs.Enabled = true;
                mskValor.Enabled = true;
                dataDataOs.Enabled = true;
                txtDescricao.Enabled = true;
                txtObservacoes.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                grpPesquisaOs.Enabled = false;
                txtNumOs.Clear();
                mskValor.Clear();
                dataDataOs.Value = DateTime.Now;
                txtDescricao.Clear();
                txtObservacoes.Clear();
                btnMenuOsNovo.Enabled = false;
            }
        }

        //Limpa os campos de dados do cliente
        private void limparCamposDadosCliente()
        {
            txtCliente.Clear();
            txtResponsavel.Clear();
            mskFoneResidencialOs.Clear();
            mskFoneComercialOs.Clear();
            mskCelularOs.Clear();
            txtEmailOs.Clear();
        }

        //Limpa e desabilita os campos de informações da O.S.
        private void limparCamposInfoOs()
        {
            grpInfoOs.Enabled = false;
            txtNumOs.Clear();
            mskValor.Clear();
            txtDescricao.Clear();
            txtObservacoes.Clear();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioOrdemServico fros = new FormRelatorioOrdemServico();
            fros.ShowDialog();
        }
    }
}