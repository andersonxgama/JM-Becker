using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace jmBecker
{
    public partial class FormContasReceber : Form
    {
        Boolean editar = false;
        int id = 0;

        public FormContasReceber()
        {
            InitializeComponent();
            layoutInicial();
        }

        //Clique do botão novo
        private void btnMenuContasReceberNovo_Click(object sender, EventArgs e)
        {
            layoutNovo();
        }

        //Clique do botão editar
        private void btnMenuContasReceberEditar_Click(object sender, EventArgs e)
        {
            try
            {
                editar = true;
                btnSalvar.Enabled = true;
                dataConta.Enabled = true;
                mskValorConta.Enabled = true;
                txtPesquisarCliente.Enabled = true;
                btnBuscarCliente.Enabled = true;
                cmbClienteContasReceber.Enabled = true;
                txtDescricao.Enabled = true;
                txtObservacoes.Enabled = true;
                grpFormaPagamento.Enabled = true;
                grpSituacao.Enabled = true;

                ContasReceber contasReceber = new ContasReceber();

                contasReceber.Data = DateTime.Parse(dataConta.Text);
                contasReceber.Valor = SqlDecimal.Parse(mskValorConta.Text.Replace(",", "."));
                contasReceber.FormaPagamento = verificaFormaPagamento();
                contasReceber.Situacao = verificaSituacao();
                contasReceber.IdOs = ContasReceberDAO.retornaIdOsContaReceber(contasReceber);

                id = ContasReceberDAO.retornaIdContaReceber(contasReceber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível editar a conta", "Erro - Contas a receber", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Clique do botão excluir
        private void btnMenuContasReceberExcluir_Click(object sender, EventArgs e)
        {
            ContasReceber contasReceber = new ContasReceber();

            try
            {
                contasReceber.IdOs = int.Parse(txtNumOs.Text);
                contasReceber.Data = DateTime.Parse(dataConta.Text);
                contasReceber.Valor = SqlDecimal.Parse(mskValorConta.Text.Replace(",","."));
                contasReceber.FormaPagamento = verificaFormaPagamento();
                contasReceber.Situacao = verificaSituacao();
                ContasReceberDAO.excluirContaReceber(ContasReceberDAO.retornaIdContaReceber(contasReceber));
                MessageBox.Show("Conta excluída com sucesso", "Contas a receber", MessageBoxButtons.OK, MessageBoxIcon.Information);
                layoutInicial();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível excluir a conta", "Erro - Contas a receber", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Clique do botão pesquisar por nº da O.S. (ícone  O.S.)
        private void btnPesquisarNumOs_Click(object sender, EventArgs e)
        {
            FormPesquisarOs fpo = new FormPesquisarOs();
            fpo.ShowDialog();
        }

        //Clique do botão pesquisar por nome do cliente. (ícone lupa)
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ClienteDAO.pesquisaNomeCliente(cmbClienteContasReceber, txtPesquisarCliente.Text);
        }

        //Clique da opção "Cheque pré-datado"
        private void optChequePre_Click(object sender, EventArgs e)
        {
            dataDeposito.Enabled = true;
        }

        //Na mudança do foco da opção cheque pré-datado (ao perder o foco)
        private void optChequePre_CheckedChanged(object sender, EventArgs e)
        {
            dataDeposito.Enabled = false;
        }

        //Verifica qual botão de forma de pagamento está selecionado
        private int verificaFormaPagamento()
        {
            int formaPagamento = 0;

            if (optDinheiro.Checked == true)
            {
                formaPagamento = 1;
            }
            else
            {
                if (optDebito.Checked == true)
                {
                    formaPagamento = 2;
                }
                else
                {
                    if (optCredito.Checked == true)
                    {
                        formaPagamento = 3;
                    }
                    else
                    {
                        if (optCheque.Checked == true)
                        {
                            formaPagamento = 4;
                        }
                        else
                        {
                            if (optChequePre.Checked == true)
                            {
                                formaPagamento = 5;
                            }
                        }
                    }
                }
            }

            return formaPagamento;
        }

        //Seleciona o botão de forma de pagamento de acordo com a opção do número passado por parametro
        private void selecionarFormaPagamento(String opcao)
        {
            if (opcao.Equals("Dinheiro"))
            {
                optDinheiro.Checked = true;
            }
            else
            {
                if (opcao.Equals("Débito"))
                {
                    optDebito.Checked = true;
                }
                else
                {
                    if (opcao.Equals("Crédito"))
                    {
                        optCredito.Checked = true;
                    }
                    else
                    {
                        if (opcao.Equals("Cheque"))
                        {
                            optCheque.Checked = true;
                        }
                        else
                        {
                            optChequePre.Checked = true;
                        }
                    }
                }
            }
        }

        //Retorna a forma de pagamento (int) de acordo com o a String passada por parametro
        private int retornaFormaPagamento(String opcao)
        {
            int formaPagamento = 0;

            if (opcao.Equals("Dinheiro"))
            {
                formaPagamento = 1;
            }
            else
            {
                if (opcao.Equals("Débito"))
                {
                    formaPagamento = 2;
                }
                else
                {
                    if (opcao.Equals("Crédito"))
                    {
                        formaPagamento = 3;
                    }
                    else
                    {
                        if (opcao.Equals("Cheque"))
                        {
                            formaPagamento = 4;
                        }
                        else
                        {
                            formaPagamento = 5;
                        }
                    }
                }
            }

            return formaPagamento;
        }

        //Verifica qual botão de situação está selecionado
        private int verificaSituacao()
        {
            int situacao = 0;

            if(optPago.Checked)
            {
                situacao = 1;
            }
            else
            {
                if (optApagar.Checked)
                {
                    situacao = 2;
                }
            }

            return situacao;
        }

        //Retorna a situação (int) de acordo com a String passada por parametro
        private int retornaSituacao(String opcao)
        {
            int situacao = 0;

            if (opcao.Equals("Pago"))
            {
                situacao = 1;
            }
            else
            {
                situacao = 2;
            }

            return situacao;
        }

        //Seleciona o botão de situação de acordo com a opção do número passado por parametro
        private void selecionaSituacao(String opcao)
        {
            if (opcao.Equals("Pago"))
            {
                optPago.Checked = true;
            }
            else
            {
                optApagar.Checked = true;
            }
        }

        //Ao trocar o valor da combo
        private void cmbClienteContasReceber_SelectedValueChanged(object sender, EventArgs e)
        {
            if (editar)
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos. Deseja continuar?", "Contas a receber", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    carregaDadosCliente();
                    //limparCampos();
                }
            }
            else
            {
                carregaDadosCliente();
                //limparCampos();
            }
        }

        //Preenche os campos de acordo com o valor que é mudado na combo
        private void carregaDadosCliente()
        {
            try
            {
                if (ClienteDAO.pesquisaTipoCliente(cmbClienteContasReceber.SelectedItem.ToString()) == 1)//Pesquisando uma pessoa física
                {
                    ContasReceberDAO.preencherGridContasReceberIdCliente(grdContasReceber, PessoaFisicaDAO.consultaIdPessoaFisica(cmbClienteContasReceber.SelectedItem.ToString()));
                }
                else
                {
                    ContasReceberDAO.preencherGridContasReceberIdCliente(grdContasReceber, PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbClienteContasReceber.SelectedItem.ToString()));
                }
            }
            catch (NullReferenceException ex)
            {
                layoutInicial();
            }
        }

        //Clique do botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ContasReceber contasReceber = new ContasReceber();

                contasReceber.Id = id;
                contasReceber.IdOs = int.Parse(txtNumOs.Text);
                contasReceber.Data = dataConta.Value.Date;
                contasReceber.Valor = SqlDecimal.Parse(mskValorConta.Text.Replace(",", "."));

                if (ClienteDAO.pesquisaTipoCliente(cmbClienteContasReceber.SelectedItem.ToString()) == 1)
                {
                    contasReceber.IdCliente = PessoaFisicaDAO.consultaIdPessoaFisica(cmbClienteContasReceber.SelectedItem.ToString());
                }
                else
                {
                    contasReceber.IdCliente = PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbClienteContasReceber.SelectedItem.ToString());
                }

                contasReceber.Descricao = txtDescricao.Text;
                contasReceber.Observacoes = txtObservacoes.Text;
                contasReceber.FormaPagamento = verificaFormaPagamento();

                if (contasReceber.FormaPagamento == 5)
                {
                    contasReceber.DataDeposito = dataDeposito.Value.Date;
                }

                contasReceber.Situacao = verificaSituacao();

                if (contasReceber.Situacao == 1)
                {
                    contasReceber.DataPagamento = dataPagamento.Value.Date;
                }

                if (contasReceber.FormaPagamento == 0)
                {
                    MessageBox.Show("Selecione a forma de pagamento", "Forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (contasReceber.Situacao == 0)
                    {
                        MessageBox.Show("Selecione a situação da conta", "Situação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtDescricao.Text.Equals(""))
                        {
                            MessageBox.Show("É necessário preencher a descrição", "Descrição", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if(mskValorConta.Text.Equals(""))
                            {
                                MessageBox.Show("É necessário preencher a descrição", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if(editar)
                                {
                                    editar = false;
                                    ContasReceberDAO.atualizarContaReceber(contasReceber);
                                    layoutInicial();
                                }
                                else
                                {
                                    ContasReceberDAO.inserirContaReceber(contasReceber);
                                    layoutInicial();
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar salvar a Conta a Receber\n" + ex.Message, "Erro - Contas a Receber", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Clique do botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            layoutInicial();
        }

        //Clique do botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((optSituacao.Checked) && cmbSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a situação a ser pesquisada", "Situação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (optSituacao.Checked)//Pesquisa por situação
                {
                    grdContasReceber.Rows.Clear();

                    if (cmbSituacao.SelectedIndex == 0)
                    {
                        ContasReceberDAO.preencherGridSituacao(grdContasReceber, 1);
                    }
                    else
                    {
                        ContasReceberDAO.preencherGridSituacao(grdContasReceber, 2);
                    }
                }
                else
                {
                    if (optDataConta.Checked)//Pesquisa por data de criação
                    {
                        grdContasReceber.Rows.Clear();
                        ContasReceberDAO.preencherGridData(grdContasReceber, dataDeContasReceber.Value.Date, dataAteContasReceber.Value.Date);
                    }
                    else
                    {
                        if (optDataDeposito.Checked)//Pesquisa por data de depósito
                        {
                            grdContasReceber.Rows.Clear();
                            ContasReceberDAO.preencherGridDataDeposito(grdContasReceber, dataDeDeposito.Value.Date, dataAteDeposito.Value.Date);
                        }
                        else//Pesquisa por data de pagamento
                        {
                            grdContasReceber.Rows.Clear();
                            ContasReceberDAO.preencherGridDataPagamento(grdContasReceber, dataDePgto.Value.Date, dataAtePgto.Value.Date);
                        }
                    }
                }
            }
        }

        //Ao clicar em uma das linhas da grid
        private void grdContasReceber_Click(object sender, EventArgs e)
        {
            ContasReceber contasReceber = new ContasReceber();

            dataConta.Text = grdContasReceber.CurrentRow.Cells[0].Value.ToString();
            contasReceber.Data = DateTime.Parse(grdContasReceber.CurrentRow.Cells[0].Value.ToString());

            if (grdContasReceber.CurrentRow.Cells[3].Value.ToString().Equals("Pago"))
            {
                dataPagamento.Text = grdContasReceber.CurrentRow.Cells[4].Value.ToString();
            }

            if (grdContasReceber.CurrentRow.Cells[5].Value.ToString().Equals("Cheque pré-datado"))
            {
                dataDeposito.Text = grdContasReceber.CurrentRow.Cells[6].Value.ToString();
            }

            if (grdContasReceber.Columns[2].HeaderText.Equals("Descrição"))//Se a coluna estiver de o título "Descrição", o campo Descrição é preenchido com o valor da grid
            {
                txtDescricao.Text = grdContasReceber.CurrentRow.Cells[2].Value.ToString();
                contasReceber.Descricao = grdContasReceber.CurrentRow.Cells[2].Value.ToString();
            }
            else//Se a coluna estiver de o título "Cliente", a combo Cliente é preenchida com o valor da grid
            {
                cmbClienteContasReceber.Text = grdContasReceber.CurrentRow.Cells[2].Value.ToString();
            }

            //Seleciona o botão de forma de pagamento
            String formaPagamento = grdContasReceber.CurrentRow.Cells[5].Value.ToString();
            selecionarFormaPagamento(formaPagamento);
            contasReceber.FormaPagamento = retornaFormaPagamento(grdContasReceber.CurrentRow.Cells[5].Value.ToString());

            //Seleciona o botão de situação
            selecionaSituacao(grdContasReceber.CurrentRow.Cells[3].Value.ToString());
            contasReceber.Situacao = retornaSituacao(grdContasReceber.CurrentRow.Cells[3].Value.ToString());

            mskValorConta.Text = grdContasReceber.CurrentRow.Cells[1].Value.ToString().Replace("R$", "");
            contasReceber.Valor = SqlDecimal.Parse(grdContasReceber.CurrentRow.Cells[1].Value.ToString().Replace("R$", "").Replace(",", "."));
            contasReceber.IdOs = ContasReceberDAO.retornaIdOsContaReceber(contasReceber);
            txtNumOs.Text = contasReceber.IdOs.ToString();
            txtDescricao.Text = ContasReceberDAO.retornaDescricaoContasReceber(ContasReceberDAO.retornaIdContaReceber(contasReceber));
            txtObservacoes.Text = ContasReceberDAO.retornaObservacaoContasReceber(ContasReceberDAO.retornaIdContaReceber(contasReceber));

            grdContasReceber.Rows.Clear();

            layoutDesabilitarCliqueGrid();
        }

        //Clique da opção "Situação"
        private void optSituacao_Click(object sender, EventArgs e)
        {
            cmbSituacao.Enabled = true;
            dataDeDeposito.Enabled = false;
            dataAteDeposito.Enabled = false;
            dataDeContasReceber.Enabled = false;
            dataAteContasReceber.Enabled = false;
            dataDePgto.Enabled = false;
            dataAtePgto.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        //Clique da opção "Data"
        private void optDataConta_Click(object sender, EventArgs e)
        {
            cmbSituacao.Enabled = false;
            cmbSituacao.SelectedIndex = -1;
            dataDeContasReceber.Enabled = true;
            dataAteContasReceber.Enabled = true;
            dataDeDeposito.Enabled = false;
            dataAteDeposito.Enabled = false;
            dataDePgto.Enabled = false;
            dataAtePgto.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        //Clique da opção "Data p/ depósito"
        private void optDataDeposito_Click(object sender, EventArgs e)
        {
            cmbSituacao.Enabled = false;
            cmbSituacao.SelectedIndex = -1;
            dataDeDeposito.Enabled = true;
            dataAteDeposito.Enabled = true;
            dataDeContasReceber.Enabled = false;
            dataAteContasReceber.Enabled = false;
            dataDePgto.Enabled = false;
            dataAtePgto.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        //Clique da opção "Data pagamento"
        private void optDataPgto_Click(object sender, EventArgs e)
        {
            cmbSituacao.Enabled = false;
            cmbSituacao.SelectedIndex = -1;
            dataDeDeposito.Enabled = false;
            dataAteDeposito.Enabled = false;
            dataDeContasReceber.Enabled = false;
            dataAteContasReceber.Enabled = false;
            dataDePgto.Enabled = true;
            dataAtePgto.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        //Get e Set para a propriedade texto do txtNumOs
        public string textoNumOs
        {
            get
            {
                return this.txtNumOs.Text;
            }
            set
            {
                this.txtNumOs.Text = value;
            }
        }

        //Get e Set para o campo de dataConta
        public DateTime dataDataConta
        {
            get
            {
                return this.dataConta.Value.Date;
            }
            set
            {
                this.dataConta.Text = value.ToString();
            }
        }

        //Get e Set para a propriedade texto do mskValorConta
        public string textoMskValorConta
        {
            get
            {
                return this.mskValorConta.Text;
            }
            set
            {
                this.mskValorConta.Text = value;
            }
        }

        //Get e Set para a propriedade texto da cmbClienteContasReceber
        public string textoCmbClienteContasReceber
        {
            get
            {
                return this.cmbClienteContasReceber.Text;
            }
            set
            {
                this.cmbClienteContasReceber.Text = value;
            }
        }

        //Limpa campos ao trocar a combo
        private void limparCampos()
        {
            txtNumOs.Clear();
            dataConta.Value = DateTime.Today;
            mskValorConta.Clear();
            txtPesquisarCliente.Clear();
            txtDescricao.Clear();
            txtObservacoes.Clear();
            desabilitaFormaPagamento();
            desabilitaSituacao();
        }

        //Layout apresentado ao abrir o form
        private void layoutInicial()
        {
            desabilitarCamposConta();
            btnMenuContasReceberNovo.Enabled = true;
            btnMenuContasReceberEditar.Enabled = false;
            btnMenuContasReceberExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            desabilitaFormaPagamento();
            cmbSituacao.Enabled = false;
            dataDeDeposito.Enabled = false;
            dataAteDeposito.Enabled = false;
            dataDeContasReceber.Enabled = false;
            dataAteContasReceber.Enabled = false;
            dataDePgto.Enabled = false;
            dataAtePgto.Enabled = false;
            btnPesquisar.Enabled = false;
            grpPesquisaContasReceber.Enabled = true;
            dataConta.Value = DateTime.Today;
            mskValorConta.Clear();
            txtPesquisarCliente.Clear();
            cmbClienteContasReceber.SelectedIndex = -1;
            txtDescricao.Clear();
            txtObservacoes.Clear();
            desabilitaSituacao();
            ClienteDAO.carregarComboClientes(cmbClienteContasReceber);
            grdContasReceber.AllowUserToAddRows = false;
            grdContasReceber.Rows.Clear();
            btnPesquisarNumOs.Enabled = true;
            txtPesquisarCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            cmbClienteContasReceber.Enabled = true;
            txtNumOs.Clear();
        }

        //Layout apresentado ao clicar no botão novo
        private void layoutNovo()
        {
            grpFormaPagamento.Enabled = true;
            grpSituacao.Enabled = true;
            dataDeposito.Enabled = false;
            btnMenuContasReceberNovo.Enabled = false;
            btnRelatorio.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            grpPesquisaContasReceber.Enabled = false;
            grdContasReceber.Rows.Clear();
            dataPagamento.Enabled = false;
            dataConta.Enabled = true;
            mskValorConta.Enabled = true;
            txtPesquisarCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            cmbClienteContasReceber.Enabled = true;
            txtDescricao.Enabled = true;
            txtObservacoes.Enabled = true;
        }

        //Desabilita o grupo Situação e desmarca as opções
        private void desabilitaSituacao()
        {
            grpSituacao.Enabled = false;
            optApagar.Checked = false;
            optPago.Checked = false;
            dataPagamento.Value = DateTime.Today;
        }

        //Desabilita o grupo Forma de pagamento e desmarca as opções
        private void desabilitaFormaPagamento()
        {
            grpFormaPagamento.Enabled = false;
            grpSituacao.Enabled = false;
            optDinheiro.Checked = false;
            optDebito.Checked = false;
            optCredito.Checked = false;
            optCheque.Checked = false;
            optChequePre.Checked = false;
        }

        //Desabilita os campos do grpDadosContasReceber, menos o botão de pesquisa de O.S.
        private void desabilitarCamposConta()
        {
            dataConta.Enabled = false;
            mskValorConta.Enabled = false;
            //txtPesquisarCliente.Enabled = false;
            //btnBuscarCliente.Enabled = false;
            //cmbClienteContasReceber.Enabled = false;
            txtDescricao.Enabled = false;
            txtObservacoes.Enabled = false;
        }

        //Layout exibido ao clicar em uma das linhas da grid
        private void layoutDesabilitarCliqueGrid()
        {
            btnMenuContasReceberNovo.Enabled = false;
            btnMenuContasReceberEditar.Enabled = true;
            btnMenuContasReceberExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisarNumOs.Enabled = false;
            btnRelatorio.Enabled = false;
            txtPesquisarCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            cmbClienteContasReceber.Enabled = false;
        }

        //Ao digitar valores no campo valor
        private void mskValorConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite somente a entrada de números ou de vírgula
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        //Clique da opção Pago (Situação)
        private void optPago_Click(object sender, EventArgs e)
        {
            dataPagamento.Enabled = true;
        }

        //Clique da opção A Pagar (situação)
        private void optApagar_Click(object sender, EventArgs e)
        {
            dataPagamento.Enabled = false;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioContasReceber frcr = new FormRelatorioContasReceber();
            frcr.ShowDialog();
        }
    }
}