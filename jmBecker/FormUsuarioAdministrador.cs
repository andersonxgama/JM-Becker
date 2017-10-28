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

namespace jmBecker
{
    public partial class FormUsuarioAdministrador : Form
    {
        public FormUsuarioAdministrador()
        {
            InitializeComponent();
        }

        //Ao carregar (abrir) o form
        private void FormUsuarioAdministrador_Load(object sender, EventArgs e)
        {
            layoutInicial();
        }

        //Clique do botão novo
        private void btnMenuUsuariosNovo_Click(object sender, EventArgs e)
        {
            layoutBtnNovo();
        }

        //Clique do botão editar
        private void btnMenuUsuariosEditar_Click(object sender, EventArgs e)
        {
            layoutBtnEditar();

            Login login = LoginDAO.consultaLogin(cmbUsuario.Text);

            if (login.Id == 1)
            {
                grpTipoUsuario.Enabled = false;
            }
        }

        //Clique do botão excluir
        private void btnMenuUsuariosExcluir_Click(object sender, EventArgs e)
        {
            Login login = LoginDAO.consultaLogin(cmbUsuario.Text);

            if(login.Id == 1)
            {
                MessageBox.Show("Não é permitido excluir o administrador principal", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    LoginDAO.excluirUsuario(cmbUsuario.Text);
                    MessageBox.Show("Usuário excluído com sucesso", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutInicial();
                }
            }
        }

        //Clique da opção Administrador 
        private void optAdministrador_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            grpSenha.Enabled = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //Clique da opção Comum
        private void optComum_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            grpSenha.Enabled = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //Clique do botão confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(cmbUsuario.Text.Equals("")) //Referente a inclusão de usuário
            {
                Login login = new Login();

                if ((txtUsuario.Text.Equals("")) || (mskSenha.Text.Equals("")) || (mskConfirmaSenha.Text.Equals("")))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "Novo usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (mskSenha.Text.Equals(mskConfirmaSenha.Text))
                    {
                        login.Usuario = txtUsuario.Text;
                        login.Senha = mskConfirmaSenha.Text;
                        login.Tipo = tipoUsuario();
                        LoginDAO.incluirLogin(login);
                        layoutInicial();
                    }
                    else
                    {
                        MessageBox.Show("As senhas digitadas não conferem. Digite-as novamente", "Novo usuário - Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparCamposSenha();
                    }
                }
            }
            else //Referente a alteração de usuário
            {
                Login login = LoginDAO.consultaLogin(cmbUsuario.Text);

                if (tipoUsuario().Equals(login.Tipo))
                {
                    alteraSenhaUsuario(login);
                }
                else
                {
                    alteraSenhaTipoUsuario(login, tipoUsuario());
                }
            }
        }

        //Clique do botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            layoutInicial();
        }

        //Ao trocar o valor da comboBox
        private void cmbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            Login login = LoginDAO.consultaLogin(cmbUsuario.Text);

            if (login.Tipo == 1)
            {
                optAdministrador.Checked = true;
            }
            else
            {
                optComum.Checked = true;
            }

            btnMenuUsuariosEditar.Enabled = true;
            btnMenuUsuariosExcluir.Enabled = true;
            txtUsuario.Text = login.Usuario;
        }

        //Método que verifica qual botão de opção (tipo do usuário) está selecionado e retorna o valor correspondente
        private int tipoUsuario()
        {
            int tipo;

            if (optAdministrador.Checked == true)
            {
                tipo = 1;
            }
            else
            {
                tipo = 2;
            }

            return tipo;
        }

        //Método que faz a alteração e verificação de segurança ao alterar a senha do usuário
        private void alteraSenhaUsuario(Login login)
        {
            if ((mskSenha.Text.Equals("")) || (mskConfirmaSenha.Text.Equals("")))
            {
                MessageBox.Show("Se deseja alterar a senha, digite e confirme uma nova." + "\nCaso contrário, clique no botão \"Cancelar\"", "Senhas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (mskSenha.Text.Equals(mskConfirmaSenha.Text))
                {
                    if (login.Senha.Equals(mskSenha.Text))
                    {
                        MessageBox.Show("A nova senha não pode ser igual a senha atual", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparCamposSenha();
                    }
                    else
                    {
                        LoginDAO.alterarSenha(login.Usuario, mskConfirmaSenha.Text);
                        layoutInicial();
                    }
                }
                else
                {
                    MessageBox.Show("As senhas digitadas não conferem. Digite-as novamente", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCamposSenha();
                }
            }
        }

        //Método que faz a alteração e verificação de segurança ao alterar a senha e tipo do usuário
        private void alteraSenhaTipoUsuario(Login login, int tipo)
        {
            if ((mskSenha.Text.Equals("")) || (mskConfirmaSenha.Text.Equals("")))
            {
                MessageBox.Show("Após alterar o tipo do usuário, é necessário especificar uma nova senha", "Senhas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (mskSenha.Text.Equals(mskConfirmaSenha.Text))
                {
                    if (login.Senha.Equals(mskSenha.Text))
                    {
                        MessageBox.Show("A nova senha não pode ser igual a senha atual", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparCamposSenha();
                    }
                    else
                    {
                        LoginDAO.alterarTipo(tipo, login.Usuario);
                        LoginDAO.alterarSenha(login.Usuario, mskConfirmaSenha.Text);
                        layoutInicial();
                    }
                }
                else
                {
                    MessageBox.Show("As senhas digitadas não conferem. Digite-as novamente", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCamposSenha();
                }
            }
        }

        //Layout inicial do form
        private void layoutInicial()
        {
            cmbUsuario.SelectedIndex = -1;
            grpTipoUsuario.Enabled = false;
            optAdministrador.Checked = false;
            optComum.Checked = false;
            grpSenha.Enabled = false;
            txtUsuario.Clear();
            mskSenha.Clear();
            mskConfirmaSenha.Clear();
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
            btnMenuUsuariosNovo.Enabled = true;
            btnMenuUsuariosEditar.Enabled = false;
            btnMenuUsuariosExcluir.Enabled = false;
            grpUsuario.Enabled = true;
            LoginDAO.carregarComboUsuarios(cmbUsuario);
        }

        //Layout do botão novo
        private void layoutBtnNovo()
        {
            cmbUsuario.SelectedIndex = -1;
            grpUsuario.Enabled = false;
            grpTipoUsuario.Enabled = true;
            grpSenha.Enabled = false;
            optAdministrador.Checked = false;
            optComum.Checked = false;
            txtUsuario.Clear();
            limparCamposSenha();
            btnMenuUsuariosNovo.Enabled = false;
            btnMenuUsuariosEditar.Enabled = false;
            btnMenuUsuariosExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        //Layout do botão editar
        private void layoutBtnEditar()
        {
            btnMenuUsuariosNovo.Enabled = false;
            btnMenuUsuariosEditar.Enabled = false;
            btnMenuUsuariosExcluir.Enabled = false;
            grpUsuario.Enabled = false;
            grpTipoUsuario.Enabled = true;
            grpSenha.Enabled = true;
            txtUsuario.Enabled = false;
            mskSenha.Clear();
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //Apaga os campos nova senha e confirma senha
        private void limparCamposSenha()
        {
            mskSenha.Clear();
            mskConfirmaSenha.Clear();
        }
    }
}