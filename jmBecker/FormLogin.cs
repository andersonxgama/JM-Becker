using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace jmBecker
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            FormSplash fs = new FormSplash();

            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new FormSplash());
        }

        //Clique do botão confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            validarLogin(LoginDAO.consultaLogin(txtUsuario.Text));
        }

        //Clique do botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Faz a validação do usuário e senha
        private void validarLogin(Login login)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Digite o usuário", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                if (mskSenha.Text.Equals(""))
                {
                    MessageBox.Show("Digite a senha", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((txtUsuario.Text.Equals(login.Usuario)) && mskSenha.Text.Equals(login.Senha))
                    {
                        FormPrincipal formPrincipal = new FormPrincipal();

                        if(login.Tipo == 1)
                        {
                            formPrincipal.textoBotao = "&Usuários";
                        }
                        else
                        {
                            formPrincipal.textoBotao = "&Alterar senha";
                        }

                        this.Hide();
                        formPrincipal.textoLabel = login.Usuario;
                        FormPrincipal.nomeUsuario = login.Usuario;
                        formPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos. Digite novamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //Executa o método quando o cursor está no campo "senha". Faz o mesmo que clicar no botão confirmar
        private void mskSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                validarLogin(LoginDAO.consultaLogin(txtUsuario.Text));
            }
        }
    }
}