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
    public partial class FormRelatorioOrdemServico : Form
    {
        public FormRelatorioOrdemServico()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if ((optNumOs.Checked == false) && (optData.Checked == false))
            {
                MessageBox.Show("Selecione uma das opções de filtro", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((optNumOs.Checked) && (txtNumOs.Text.Equals("")))
                {
                    MessageBox.Show("Digite o número da ordem de serviço", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (optNumOs.Checked)
                    {
                        this.DataTable1TableAdapter.FillNum(this.jmbeckerDataSet.DataTable1, int.Parse(txtNumOs.Text));
                        this.reportViewer1.RefreshReport();
                    }
                    else
                    {
                        this.DataTable1TableAdapter.FillData(this.jmbeckerDataSet.DataTable1, dataDe.Value.ToString("dd-MM-yyyy"), dataAte.Value.ToString("dd-MM-yyyy"));
                        this.reportViewer1.RefreshReport();
                    }
                }
            }
        }
    }
}