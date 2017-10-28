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
    public partial class FormRelatorioContasReceber : Form
    {
        public FormRelatorioContasReceber()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if ((optData.Checked == false) && (optDeposito.Checked == false) && (optPagamento.Checked == false))
            {
                MessageBox.Show("Selecione uma das opções de filtro", "Filtros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (optData.Checked)
                {
                    this.DataTable2TableAdapter.FillData(this.jmbeckerDataSet.DataTable2, dataDe.Value.ToString("dd-MM-yyyy"), dataAte.Value.ToString("dd-MM-yyyy"));
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    if (optDeposito.Checked)
                    {
                        this.DataTable2TableAdapter.FillDeposito(this.jmbeckerDataSet.DataTable2, dataDeDeposito.Value.ToString("dd-MM-yyyy"), dataAteDeposito.Value.ToString("dd-MM-yyyy"));
                        this.reportViewer1.RefreshReport();
                    }
                    else
                    {
                        this.DataTable2TableAdapter.FillPagamento(this.jmbeckerDataSet.DataTable2, dataDePagamento.Value.ToString("dd-MM-yyyy"), dataAtePagamento.Value.ToString("dd-MM-yyyy"));
                        this.reportViewer1.RefreshReport();
                    }
                }
            }
        }
    }
}