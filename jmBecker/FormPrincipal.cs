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
    public partial class FormPrincipal : Form
    {
        public static String nomeUsuario = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Ao iniciar o form
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //Faz o form começar maximizado
        }

        //Get e Set para o botão Usuários/Alterar senha, que será alterado de acordo com o tipo do usuário logado no sistema
        public string textoBotao
        {
            get
            {
                return this.btnMenuPrincipalAdmin.Text;
            }
            set
            {
                this.btnMenuPrincipalAdmin.Text = value;
            }
        }

        //Get e Set para a label que exibirá o nome do usuário logado no sistema
        public string textoLabel
        {
            get
            {
                return this.lblNomeUsuarioAtual.Text;
            }
            set
            {
                this.lblNomeUsuarioAtual.Text = value;
            }
        }

        //Faz os Forms abrirem ao clicar nos respectivos forms
        //O "ShowDialog()" faz com que o FormPrincipal fique bloqueado enquanto os outros forms não forem fechados
        private void btnMenuPrincipalClientes_Click(object sender, EventArgs e)
        {
            FormClientes fc = new FormClientes();
            fc.ShowDialog();
        }

        private void btnMenuPrincipalOs_Click(object sender, EventArgs e)
        {
            FormOrdemServico fos = new FormOrdemServico();
            fos.ShowDialog();
        }

        private void btnMenuPrincipalPagar_Click(object sender, EventArgs e)
        {
            FormContasPagar fcp = new FormContasPagar();
            fcp.ShowDialog();
        }

        private void btnMenuPrincipalReceber_Click(object sender, EventArgs e)
        {
            FormContasReceber fcr = new FormContasReceber();
            fcr.ShowDialog();
        }

        private void btnMenuPrincipalAdmin_Click(object sender, EventArgs e)
        {
            if(btnMenuPrincipalAdmin.Text.Equals("&Usuários"))
            {
                FormUsuarioAdministrador formUsuarioAdministrador = new FormUsuarioAdministrador();
                formUsuarioAdministrador.ShowDialog();
            }
            else
            {
                FormUsuarioComum formUsuarioComum = new FormUsuarioComum();
                formUsuarioComum.ShowDialog();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            nomeUsuario = "";
        }
    }
}