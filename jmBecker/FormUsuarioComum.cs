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
    public partial class FormUsuarioComum : Form
    {
        public FormUsuarioComum()
        {
            InitializeComponent();
        }

        //Clique do botão confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Login login = LoginDAO.consultaLogin(FormPrincipal.nomeUsuario);

            if(confereSenhaAtual(login))
            {
                if(confereSenhasNovas())
                {
                    LoginDAO.alterarSenha(login.Usuario, mskNovaSenha.Text);
                    this.Close();
                }
            }
        }

        //Compara senha atual digitada com a senha do banco de dados
        private Boolean confereSenhaAtual(Login login)
        {
            Boolean igual = false;

            if (mskSenhaAtual.Text.Equals(login.Senha))
            {
                igual = true;
            }
            else
            {
                MessageBox.Show("A senha atual está incorreta", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskSenhaAtual.Clear();
                mskNovaSenha.Clear();
                mskConfirmaSenha.Clear();
            }

            return igual;
        }

        //Compara nova senha com a sua confirmação
        private Boolean confereSenhasNovas()
        {
            Boolean igual = false;

            if(mskNovaSenha.Text.Equals(mskConfirmaSenha.Text))
            {
                igual = true;
            }
            else
            {
                MessageBox.Show("A nova senha e a confirmação não conferem", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskNovaSenha.Clear();
                mskConfirmaSenha.Clear();
            }

            return igual;
        }
    }
}