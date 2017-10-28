using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmBecker
{
    public partial class FormRelatorioContasPagar : Form
    {
        public FormRelatorioContasPagar()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if ((optPagamento.Checked == false) && (optVencimento.Checked == false))
            {
                MessageBox.Show("Selecione uma das opções de filtro", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (optVencimento.Checked)
                {
                    this.ContasPagarTableAdapter.FillVencimento(this.jmbeckerDataSet.ContasPagar, dataDeVencimentoPesquisa.Value.ToString("dd-MM-yyyy"), dataAteVencimentoPesquisa.Value.ToString("dd-MM-yyyy"));
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.ContasPagarTableAdapter.FillPagamento(this.jmbeckerDataSet.ContasPagar, dataDePagamentoPesquisa.Value.ToString("dd-MM-yyyy"), dataAtePagamentoPesquisa.Value.ToString("dd-MM-yyyy"));
                    this.reportViewer1.RefreshReport();
                }
            }
        }

        private void optVencimento_Click(object sender, EventArgs e)
        {
            dataDeVencimentoPesquisa.Enabled = true;
            dataAteVencimentoPesquisa.Enabled = true;
            dataDePagamentoPesquisa.Enabled = false;
            dataAtePagamentoPesquisa.Enabled = false;
        }

        private void optPagamento_Click(object sender, EventArgs e)
        {
            dataDeVencimentoPesquisa.Enabled = false;
            dataAteVencimentoPesquisa.Enabled = false;
            dataDePagamentoPesquisa.Enabled = true;
            dataAtePagamentoPesquisa.Enabled = true;
        }
    }
}