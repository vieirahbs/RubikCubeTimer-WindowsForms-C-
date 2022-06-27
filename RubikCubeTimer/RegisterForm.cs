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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtLogin.Text == string.Empty ||
                txtSenha.Text == string.Empty)
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
    }
}
