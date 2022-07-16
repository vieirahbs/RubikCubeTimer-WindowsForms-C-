using System;
using System.Windows.Forms;
using RubikCubeTimer.Entities;

namespace RubikCubeTimer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty.Trim() || txtLogin.Text == string.Empty.Trim() ||
                txtSenha.Text == string.Empty.Trim())
            {
                MessageBox.Show("Fill in all the fields.", "Create your account");
                return;
            }
            else
            {
                string loginJaExistente = Usuario.ConsultaLogin(txtLogin.Text);

                if (loginJaExistente == string.Empty)
                {
                    bool cadastroCriado = Usuario.CreateUsuario(txtName.Text, txtLogin.Text, txtSenha.Text);
                    if (cadastroCriado)
                    {
                        MessageBox.Show("Account created successfully!", "Rubik's Cube Timer - Create your account");
                        this.Close();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Account not created! Username already registered!", "Rubik's Cube Timer - Create your account");
                    txtLogin.Focus();
                    return;
                }


            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnRegister_Click(btnRegister, new EventArgs());
            }

        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnRegister_Click(btnRegister, new EventArgs());
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnRegister_Click(btnRegister, new EventArgs());
            }
        }

        private void btnHideUnhide_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                btnHideUnhide.BackgroundImage = Properties.Resources.EyeHidden;
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Focus();
            }
            else
            {
                btnHideUnhide.BackgroundImage = Properties.Resources.EyeOpened;
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.Focus();
            }
        }
    }
}
