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
    public partial class FormContasPagar : Form
    {
        private Boolean editar = false;
        private int id = 0;

        public FormContasPagar()
        {
            InitializeComponent();
            layoutInicial();
        }

        //Clique do botão Novo
        private void btnNovomenuContasPagar_Click(object sender, EventArgs e)
        {
            layoutNovo();
        }

        //Clique do botão Editar
        private void btnEditarMenuContasPagar_Click(object sender, EventArgs e)
        {
            editar = true;
            grpContasPagar.Enabled = true;
            grpSituacao.Enabled = true;
            grpPesquisaContasPagar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            if(optApagar.Checked)
            {
                dataVencimento.Enabled = true;
            }
            else
            {
                dataPagamento.Enabled = true;
            }

            ContasPagar contasPagar = new ContasPagar();

            contasPagar.Valor = SqlDecimal.Parse(mskValor.Text.Replace(",", "."));
            contasPagar.Descricao = txtDescricao.Text;
            contasPagar.Observacoes = txtObservacoes.Text;

            if (optPago.Checked)
            {
                contasPagar.Situacao = 1;
                contasPagar.DataPagamento = dataPagamento.Value.Date;
            }
            else
            {
                contasPagar.Situacao = 2;
                contasPagar.DataVencimento = dataVencimento.Value.Date;
            }

            id = ContasPagarDAO.retornaId(contasPagar);
        }

        //Clique do botão Excluir
        private void btnExcluirMenuContasPagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se a conta for excluída, os dados não poderão ser recuperados. Deseja continuar?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ContasPagar contasPagar = new ContasPagar();

                contasPagar.Valor = SqlDecimal.Parse(mskValor.Text.Replace(",", "."));
                contasPagar.Descricao = txtDescricao.Text;
                contasPagar.Observacoes = txtObservacoes.Text;

                if (optPago.Checked)
                {
                    contasPagar.Situacao = 1;
                    contasPagar.DataPagamento = dataPagamento.Value.Date;
                }
                else
                {
                    contasPagar.Situacao = 2;
                    contasPagar.DataVencimento = dataVencimento.Value.Date;
                }

                ContasPagarDAO.excluirContaPagar(ContasPagarDAO.retornaId(contasPagar));
                MessageBox.Show("Conta excluída com sucesso", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                layoutInicial();
            }
        }

        //Clique do botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(optDataVencimento.Checked)
            {
                ContasPagarDAO.preencherGridDataVencimento(grdContasPagar, dataDeVencimento.Value.Date, dataAteVencimento.Value.Date);
            }
            else
            {
                ContasPagarDAO.preencherGridDataPagamento(grdContasPagar, dataDePagamento.Value.Date, dataAtePagamento.Value.Date);
            }
        }

        //Ao clicar em uma das linhas da grid
        private void grdContasPagar_Click(object sender, EventArgs e)
        {
            try
            {
                ContasPagar cp = new ContasPagar();

                btnEditarMenuContasPagar.Enabled = true;
                btnExcluirMenuContasPagar.Enabled = true;

                mskValor.Text = grdContasPagar.CurrentRow.Cells[0].Value.ToString().Replace("R$", "");
                txtDescricao.Text = grdContasPagar.CurrentRow.Cells[2].Value.ToString();

                cp.Valor = SqlDecimal.Parse(mskValor.Text.Replace(",", "."));
                cp.Descricao = txtDescricao.Text;

                if (grdContasPagar.Columns[1].HeaderText.Equals("Data do vencimento"))
                {
                    optApagar.Checked = true;
                    dataVencimento.Text = grdContasPagar.CurrentRow.Cells[1].Value.ToString();
                    cp.Situacao = 2;
                    cp.DataVencimento = dataVencimento.Value.Date;
                }
                else
                {
                    optPago.Checked = true;
                    dataPagamento.Text = grdContasPagar.CurrentRow.Cells[1].Value.ToString();
                    cp.Situacao = 1;
                    cp.DataPagamento = dataPagamento.Value.Date;
                }

                txtObservacoes.Text = ContasPagarDAO.retornaObservacao(cp);
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Não há nenhuma informação para ser selecionada", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Clique do botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskValor.Text.Equals(""))
                {
                    MessageBox.Show("Digite o valor da conta", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if(txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Digite a descrição da conta", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if ((optPago.Checked) || (optApagar.Checked))
                        {
                            ContasPagar contasPagar = new ContasPagar();

                            contasPagar.Valor = SqlDecimal.Parse(mskValor.Text.Replace(",", "."));
                            contasPagar.Descricao = txtDescricao.Text;
                            contasPagar.Observacoes = txtObservacoes.Text;

                            if (optPago.Checked)
                            {
                                contasPagar.Situacao = 1;
                                contasPagar.DataPagamento = dataPagamento.Value.Date;
                            }
                            else
                            {
                                contasPagar.Situacao = 2;
                                contasPagar.DataVencimento = dataVencimento.Value.Date;
                            }

                            if (editar)
                            {
                                ContasPagarDAO.atualizarContaPagar(contasPagar, id);
                                editar = false;
                                layoutInicial();
                            }
                            else
                            {
                                ContasPagarDAO.inserirContaPagar(contasPagar);
                                layoutInicial();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecione a situação da conta", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar salvar a Conta a Pagar", "Erro - Contas Pagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Clique do botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((mskValor.Text != "") || (txtDescricao.Text != "") || (txtObservacoes.Text != ""))
            {
                if (MessageBox.Show("As informações não salvas serão perdidas. Deseja continuar?", "Contas Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    layoutInicial();
                }
            }
            else
            {
                layoutInicial();
            }
        }

        //Clique do botão relatório
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioContasPagar formRelatorioContasPagar = new FormRelatorioContasPagar();
            formRelatorioContasPagar.ShowDialog();
        }

        //Clique da opção "Data do pagamento"
        private void optDataPagamento_Click(object sender, EventArgs e)
        {
            dataDePagamento.Enabled = true;
            dataAtePagamento.Enabled = true;
            dataDeVencimento.Enabled = false;
            dataAteVencimento.Enabled = false;
        }

        //Clique da opção "Vencimento"
        private void optDataVencimento_Click(object sender, EventArgs e)
        {
            dataDePagamento.Enabled = false;
            dataAtePagamento.Enabled = false;
            dataDeVencimento.Enabled = true;
            dataAteVencimento.Enabled = true;
        }

        //Layout exibido ao abrir o form
        private void layoutInicial()
        {
            btnEditarMenuContasPagar.Enabled = false;
            btnExcluirMenuContasPagar.Enabled = false;
            grpContasPagar.Enabled = false;
            grpSituacao.Enabled = false;
            grdContasPagar.Rows.Clear();
            dataDePagamento.Enabled = false;
            dataAtePagamento.Enabled = false;
            dataDeVencimento.Enabled = true;
            dataAteVencimento.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovomenuContasPagar.Enabled = true;
            grpPesquisaContasPagar.Enabled = true;
            btnRelatorio.Enabled = true;
            mskValor.Clear();
            txtDescricao.Clear();
            txtObservacoes.Clear();
            dataPagamento.Enabled = false;
            dataVencimento.Enabled = false;
            optDataVencimento.Checked = true;
            optPago.Checked = false;
            optApagar.Checked = false;
            dataPagamento.Value = DateTime.Today;
            dataVencimento.Value = DateTime.Today;
            dataDePagamento.Value = DateTime.Today;
            dataAtePagamento.Value = DateTime.Today;
            dataDeVencimento.Value = DateTime.Today;
            dataAteVencimento.Value = DateTime.Today;
            grdContasPagar.AllowUserToAddRows = false;
        }

        //Layout exibido ao abrir o form
        private void layoutNovo()
        {
            btnNovomenuContasPagar.Enabled = false;
            grpContasPagar.Enabled = true;
            grpSituacao.Enabled = true;
            grpPesquisaContasPagar.Enabled = false;
            grdContasPagar.Rows.Clear();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnRelatorio.Enabled = false;
            mskValor.Clear();
            txtDescricao.Clear();
            txtObservacoes.Clear();
            optPago.Checked = false;
            optApagar.Checked = false;
            dataPagamento.Value = DateTime.Today;
            dataVencimento.Value = DateTime.Today;
        }

        //Clique da opção Pago
        private void optPago_Click(object sender, EventArgs e)
        {
            dataPagamento.Enabled = true;
            dataVencimento.Enabled = false;
        }

        //Clique da opção A Pagar
        private void optApagar_Click(object sender, EventArgs e)
        {
            dataPagamento.Enabled = false;
            dataVencimento.Enabled = true;
        }

        //Ao digitar valores no campo valor
        private void mskValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite somente a entrada de números ou de vírgula
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }
    }
}