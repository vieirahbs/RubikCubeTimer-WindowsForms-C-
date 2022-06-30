using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RubikCubeTimer.Entities;

namespace RubikCubeTimer
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty.Trim() || txtSenha.Text == string.Empty.Trim())
            {
                MessageBox.Show("Fill in all the fields.", "Rubik's Cube Timer - Login");
                return;
            }
            else
            {
                Usuario usuarioDB = Usuario.ValidaUsuario(txtLogin.Text, txtSenha.Text);

                if (usuarioDB.Login != null)
                {
                    TimerForm timerForm = new TimerForm();
                    timerForm.Usuario = usuarioDB;
                    this.Hide();
                    timerForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Rubik's Cube Timer - Login");
                    return;
                }
            }            
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnLogin_Click(btnLogin, new EventArgs());
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnLogin_Click(btnLogin, new EventArgs());
            }
        }

    }
}
