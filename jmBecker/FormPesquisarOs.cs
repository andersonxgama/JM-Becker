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
    public partial class FormPesquisarOs : Form
    {
        public FormPesquisarOs()
        {
            InitializeComponent();
            layoutInicial();
        }

        //Clique do botão pesquisar (nome do cliente - lupa)
        private void btnPesquisaClienteOs_Click(object sender, EventArgs e)
        {
            ClienteDAO.pesquisaNomeCliente(cmbPesquisaClienteOs, txtPesquisaClienteOs.Text);
            optPesquisarOsCliente.Checked = true;
        }

        //Executa o método quando o cursor está no campo "Pesquisar cliente" e a tecla ENTER é pressionada
        private void txtPesquisaClienteOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ClienteDAO.pesquisaNomeCliente(cmbPesquisaClienteOs, txtPesquisaClienteOs.Text);
                optPesquisarOsCliente.Checked = true;
            }
        }

        //Clique do botão pesquisar (preencher grid)
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((optPesquisarOsCliente.Checked) && (cmbPesquisaClienteOs.SelectedIndex == -1))
            {
                MessageBox.Show("É necessário selecionar um cliente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((optPesquisarOsNumOs.Checked) && (txtPesquisarOsNumOs.Text.Equals("")))
                {
                    MessageBox.Show("É necessário digitar o número de uma Ordem de serviço", "Nº. O.S.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (optPesquisarOsCliente.Checked)
                    {
                        if (ClienteDAO.pesquisaTipoCliente(cmbPesquisaClienteOs.SelectedItem.ToString()) == 1)//Verifica se o cliente é PF ou PJ
                        {
                            grdPesquisarOs.Rows.Clear();
                            OrdemServicoDAO.preencherGridOsIdCliente(grdPesquisarOs, PessoaFisicaDAO.consultaIdPessoaFisica(cmbPesquisaClienteOs.SelectedItem.ToString()));
                        }
                        else
                        {
                            grdPesquisarOs.Rows.Clear();
                            OrdemServicoDAO.preencherGridOsIdCliente(grdPesquisarOs, PessoaJuridicaDAO.consultaIdPessoaJuridica(cmbPesquisaClienteOs.SelectedItem.ToString()));
                        }
                    }
                    else
                    {
                        if (optPesquisarOsData.Checked == true)
                        {
                            grdPesquisarOs.Rows.Clear();
                            OrdemServicoDAO.preencherGridPorData(grdPesquisarOs, dataPesquisarOsDe.Value.Date, dataPesquisarOsAte.Value.Date);
                        }
                        else
                        {
                            grdPesquisarOs.Rows.Clear();
                            OrdemServicoDAO.preencherGridPorNumeroOs(grdPesquisarOs, int.Parse(txtPesquisarOsNumOs.Text));
                        }
                    }
                }
            }
        }

        //Ao dar um duplo clique em uma das linhas da grid
        private void grdPesquisarOs_DoubleClick(object sender, EventArgs e)
        {
            OrdemServico os = new OrdemServico();
            FormContasReceber formContasReceber = new FormContasReceber();

            if (optPesquisarOsCliente.Checked)//Se a opção selecionada for "Cliente"
            {
                int teste = int.Parse(grdPesquisarOs.CurrentRow.Cells[0].Value.ToString());
                os.Id = teste;
                os.Data = DateTime.Parse(grdPesquisarOs.CurrentRow.Cells[1].Value.ToString());
                os.Valor = SqlDecimal.Parse(grdPesquisarOs.CurrentRow.Cells[2].Value.ToString().Replace("R$", "").Replace(",", "."));
                os.Descricao = grdPesquisarOs.CurrentRow.Cells[3].Value.ToString();

                this.Hide();

                formContasReceber.textoNumOs = os.Id.ToString();
                formContasReceber.dataDataConta = os.Data;
                formContasReceber.textoCmbClienteContasReceber = cmbPesquisaClienteOs.Text;
                formContasReceber.textoMskValorConta = os.Valor.ToString().Replace(".", ",");
                formContasReceber.ShowDialog();

                this.Close();
            }
            else//Se a opção selecionada for "Data" ou "Nº O.S."
            {
                os.Id = int.Parse(grdPesquisarOs.CurrentRow.Cells[0].Value.ToString());
                os.Data = DateTime.Parse(grdPesquisarOs.CurrentRow.Cells[1].Value.ToString());
                os.Valor = SqlDecimal.Parse(grdPesquisarOs.CurrentRow.Cells[2].Value.ToString().Replace("R$", "").Replace(",", "."));
                os.Descricao = grdPesquisarOs.CurrentRow.Cells[3].Value.ToString();

                this.Hide();

                formContasReceber.textoNumOs = os.Id.ToString();
                formContasReceber.dataDataConta = os.Data;
                formContasReceber.textoCmbClienteContasReceber = grdPesquisarOs.CurrentRow.Cells[4].Value.ToString();
                formContasReceber.textoMskValorConta = os.Valor.ToString().Replace(".", ",");
                formContasReceber.ShowDialog();

                this.Close();
            }
        }

        //Layout exibido ao abrir o form
        public void layoutInicial()
        {
            optPesquisarOsCliente.Checked = false;
            optPesquisarOsData.Checked = false;
            optPesquisarOsNumOs.Checked = false;
            dataPesquisarOsDe.Enabled = false;
            dataPesquisarOsAte.Enabled = false;
            txtPesquisarOsNumOs.Enabled = false;
            btnPesquisar.Enabled = false;
            ClienteDAO.carregarComboClientes(cmbPesquisaClienteOs);
        }

        //Clique da opção Cliente
        private void optPesquisarOsCliente_Click(object sender, EventArgs e)
        {
            txtPesquisaClienteOs.Enabled = true;
            btnPesquisaClienteOs.Enabled = true;
            cmbPesquisaClienteOs.Enabled = true;
            dataPesquisarOsDe.Enabled = false;
            dataPesquisarOsAte.Enabled = false;
            txtPesquisarOsNumOs.Enabled = false;
            btnPesquisar.Enabled = true;
            grdPesquisarOs.Rows.Clear();
            txtPesquisarOsNumOs.Clear();
        }

        //Clique da opção Data
        private void optPesquisarOsData_Click(object sender, EventArgs e)
        {
            txtPesquisaClienteOs.Enabled = false;
            btnPesquisaClienteOs.Enabled = false;
            cmbPesquisaClienteOs.Enabled = false;
            dataPesquisarOsDe.Enabled = true;
            dataPesquisarOsAte.Enabled = true;
            txtPesquisarOsNumOs.Enabled = false;
            btnPesquisar.Enabled = true;
            cmbPesquisaClienteOs.SelectedIndex = -1;
            grdPesquisarOs.Rows.Clear();
            txtPesquisarOsNumOs.Clear();
        }

        //Clique da opção Nº. O.S.
        private void optPesquisarOsNumOs_Click(object sender, EventArgs e)
        {
            txtPesquisaClienteOs.Enabled = false;
            btnPesquisaClienteOs.Enabled = false;
            cmbPesquisaClienteOs.Enabled = false;
            dataPesquisarOsDe.Enabled = false;
            dataPesquisarOsAte.Enabled = false;
            txtPesquisarOsNumOs.Enabled = true;
            btnPesquisar.Enabled = true;
            cmbPesquisaClienteOs.SelectedIndex = -1;
            grdPesquisarOs.Rows.Clear();
        }

        //Evento que ocorre na troca de valor da combo
        private void cmbPesquisaClienteOs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPesquisaClienteOs.SelectedIndex != -1)
            {
                optPesquisarOsCliente.Checked = true;
                grdPesquisarOs.Rows.Clear();
                btnPesquisar.Enabled = true;
            }
        }
    }
}