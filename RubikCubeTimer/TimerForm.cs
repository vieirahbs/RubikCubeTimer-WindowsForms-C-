using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;
using RubikCubeTimer.Entities;
using System.ComponentModel.DataAnnotations;

namespace RubikCubeTimer
{
    public partial class TimerForm : Form
    {
        public Usuario Usuario { get; set; }
        private TimeSpan TempoTotal { get; set; }

        private int Contador = 0;
        private Stopwatch stopwatch;
        bool isActive;
        bool isReset;

        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            #region Timer

            string[] nomeVect = Usuario.Nome.Split(' ');
            lblNome.Text = $"Hello, {nomeVect[0]}!";
            stopwatch = new Stopwatch();
            btnStartStop.Focus();
            isActive = false;
            isReset = true;
            StartTimerList();
            Contador = 0;
            TempoTotal = new TimeSpan();
            lblMelhorTempo.Text = ObtemRecordAtual();
            lblAvarage.Text = "Average: 00:00:000";
            lblTimer.Text = "00:00:000";

            #endregion

            #region My account
            lblID.Text = Usuario.Id.ToString();
            lblLogin.Text = Usuario.Login;
            txtName.Text = Usuario.Nome;
            pnlAlterarSenha.Visible = false;
            txtName.Enabled = false;
            btnCancelNameEdit.Visible = false;
            btnCancelSenhaEdit.Visible = false;
            #endregion

            #region My records
            cbxCubeTypes.Items.Add("2x2");
            cbxCubeTypes.Items.Add("3x3");
            cbxCubeTypes.Items.Add("4x4");
            cbxCubeTypes.Items.Add("5x5");
            cbxCubeTypes.Items.Add("Megaminx");
            cbxCubeTypes.Items.Add("Piraminx");
            cbxCubeTypes.Items.Add("Mirror Blocks");
            StartRecodList();
            cbxCubeTypes.SelectedIndex = 1;

            
            #endregion
        }

        private void CalculaMedia(string time)
        {
            string[] recordString = time.ToString().Split(':');
            int minuto = int.Parse(recordString[0]);
            int segundo = int.Parse(recordString[1]);
            int centezimo = int.Parse(recordString[2]);
            TimeSpan tempo = new TimeSpan(0, 0, minuto, segundo, centezimo);

            Contador++;
            TempoTotal += tempo;

            TimeSpan media = TempoTotal / Contador;
            lblAvarage.Text = $"Average: {string.Format("{0:mm\\:ss\\:fff} ", media)}";
        }

        private void StartTimerList()
        {
            lstTimes.Clear();
            lstTimes.Columns.Insert(0, "", 45, HorizontalAlignment.Center);
            lstTimes.Columns.Insert(1, "", 120, HorizontalAlignment.Center);
        }

        private void StartRecodList()
        {
            lstMyRecords.Clear();
            lstMyRecords.Columns.Insert(0, "", 45, HorizontalAlignment.Center);
            lstMyRecords.Columns.Insert(1, "Time", 120, HorizontalAlignment.Center);
            lstMyRecords.Columns.Insert(2, "Date", 150, HorizontalAlignment.Center);
        }

        private void timerRubik_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                lblTimer.Text = string.Format("{0:mm\\:ss\\:fff}", stopwatch.Elapsed);
            }
        }

        private string ObtemRecordAtual()
        {
            Record recordATual = Record.RecuperaRecordAtual(Usuario.Id);

            if (recordATual.Id != 0)
            {
                if (recordATual.TipoCubo == CubeType.C2x2 ||
                    recordATual.TipoCubo == CubeType.C3x3 ||
                    recordATual.TipoCubo == CubeType.C4x4 ||
                    recordATual.TipoCubo == CubeType.C5x5)
                {
                    string tipoCubo = recordATual.TipoCubo.ToString().Substring(1);

                    return $"Best time in {tipoCubo}: {string.Format("{0:mm\\:ss\\:fff} ", recordATual.MelhorTempo)}- " +
                                    $"{recordATual.Data.ToString("dd/MMM/yyyy")}";
                }
                else
                {
                    string tipoCubo = recordATual.TipoCubo.ToString().Substring(1);

                    return $"Best time in {recordATual.TipoCubo}: {string.Format("{0:mm\\:ss\\:fff} ", recordATual.MelhorTempo)}- " +
                                    $"{recordATual.Data.ToString("dd/MMM/yyyy")}";
                }
            }
            else
            {
                return $"Best time: None.";
            }

        }

        private bool VerificaRecord(string tempo)
        {
            bool retorno = false;

            string[] tempoVect = tempo.ToString().Split(':');
            int minuto = int.Parse(tempoVect[0]);
            int segundo = int.Parse(tempoVect[1]);
            int centezimo = int.Parse(tempoVect[2]);
            TimeSpan tempoTS = new TimeSpan(0, 0, minuto, segundo, centezimo);

            List<Record> records = Record.RecuperaRecords(Usuario.Id);

            if (records.Count == 0)
            {
                string mensagem = "Do you want to save your first best time?";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(mensagem, this.Text, botoes);
                if (resultado == DialogResult.Yes)
                {
                    retorno = Record.CreateNovoRecord(Usuario.Id, tempo, DateTime.Now.ToString("dd/MM/yyyy"));
                    lblMelhorTempo.Text = $"Best time: {lblTimer.Text} - {DateTime.Now.ToString("dd/MMM/yyyy")}";
                }
            }
            else
            {
                Record recordAtual = Record.RecuperaRecordAtual(Usuario.Id);


                if (tempoTS < recordAtual.MelhorTempo)
                {
                    string mensagem = "Well done! You beat your record! Do you want to save it?";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    DialogResult resultado;
                    resultado = MessageBox.Show(mensagem, this.Text, botoes);
                    if (resultado == DialogResult.Yes)
                    {
                        retorno = Record.CreateNovoRecord(Usuario.Id, tempo, DateTime.Now.ToString("dd/MM/yyyy"));
                        lblMelhorTempo.Text = $"Best time: {lblTimer.Text} - {DateTime.Now.ToString("dd/MMM/yyyy")}";
                    }
                }

            }

            return retorno;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isActive == false && isReset == true)
            {
                stopwatch.Start();
                isActive = true;
                isReset = false;
            }
            else if (isActive)
            {
                stopwatch.Stop();
                isActive = false;
                ListViewItem timesList = lstTimes.Items.Add((Contador + 1).ToString() + "-");
                timesList.SubItems.Add(new ListViewItem.ListViewSubItem(null, lblTimer.Text));
                VerificaRecord(lblTimer.Text);
                CalculaMedia(lblTimer.Text);
            }
            else if (isActive == false && isReset == false)
            {
                stopwatch.Reset();
                isActive = false;
                isReset = true;
                stopwatch.Start();
                isActive = true;
                isReset = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btmReset_Click(object sender, EventArgs e)
        {
            TimerForm_Load(this, new EventArgs());
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            btnStartStop.Focus();
        }
        private void btnEditarSalvarNome_Click(object sender, EventArgs e)
        {
            if (btnEditarSalvarNome.Text == "Edit name")
            {
                txtName.Enabled = true;
                btnEditarSalvarNome.Text = "Save name";
                btnEditarSalvarNome.BackColor = Color.LightSeaGreen;
                btnCancelNameEdit.Visible = true;
            }
            else
            {
                if (txtName.Text == string.Empty.Trim())
                {
                    MessageBox.Show("The name field cannot be empty!", this.Text);
                    return;
                }

                bool nomeAtualizado = Usuario.UpdateUsuario(Usuario.Id, txtName.Text);

                if (nomeAtualizado)
                {
                    txtName.Enabled = false;
                    btnEditarSalvarNome.Text = "Edit name";
                    btnEditarSalvarNome.BackColor = Color.DodgerBlue;
                    btnCancelNameEdit.Visible = false;
                    string[] nomeVect = txtName.Text.Split(' ');
                    lblNome.Text = $"Hello, {nomeVect[0]}!";
                    MessageBox.Show("Name updated successfully!", this.Text);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred. The name was not updated!", this.Text);
                    return;
                }
            }

        }
        private void btnAlterarSalvarSenha_Click(object sender, EventArgs e)
        {
            if (btnAlterarSalvarSenha.Text == "Change password")
            {
                pnlAlterarSenha.Visible = true;
                btnAlterarSalvarSenha.Text = "Save new password";
                btnAlterarSalvarSenha.BackColor = Color.LightSeaGreen;
                btnCancelSenhaEdit.Visible = true;
            }
            else
            {
                if (txtSenhaAtual.Text == string.Empty.Trim() ||
                    txtNovaSenha.Text == string.Empty.Trim() ||
                    txtConfimaNovaSenha.Text == string.Empty.Trim())
                {
                    MessageBox.Show("Fill in all the fields!", this.Text);
                    return;
                }
                else if (txtNovaSenha.Text != txtConfimaNovaSenha.Text)
                {
                    MessageBox.Show("'New password' and 'Confirm new password' must match!", this.Text);
                    return;
                }

                Usuario usuarioDB = Usuario.ValidaUsuario(Usuario.Login, txtSenhaAtual.Text);

                if (usuarioDB.Login == null)
                {
                    MessageBox.Show("The current password informed is not correct.", this.Text);
                    return;
                }
                else
                {
                    bool senhaAtualizada = Usuario.UpdateUsuario(Usuario.Id, "", txtNovaSenha.Text);

                    if (senhaAtualizada)
                    {
                        pnlAlterarSenha.Visible = false;
                        btnAlterarSalvarSenha.Text = "Change password";
                        btnAlterarSalvarSenha.BackColor = Color.DodgerBlue;
                        btnCancelSenhaEdit.Visible = false;
                        txtSenhaAtual.Text = string.Empty;
                        txtNovaSenha.Text = string.Empty;
                        txtConfimaNovaSenha.Text = string.Empty;
                        MessageBox.Show("Password updated successfully", this.Text);
                        return;
                    }
                }
            }
        }

        private void btnCancelNameEdite_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            btnEditarSalvarNome.Text = "Edit name";
            btnEditarSalvarNome.BackColor = Color.DodgerBlue;
            btnCancelNameEdit.Visible = false;
        }

        private void btnCancelSenhaEdit_Click(object sender, EventArgs e)
        {
            pnlAlterarSenha.Visible = false;
            btnAlterarSalvarSenha.Text = "Change password";
            btnAlterarSalvarSenha.BackColor = Color.DodgerBlue;
            btnCancelSenhaEdit.Visible = false;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnEditarSalvarNome_Click(btnEditarSalvarNome, new EventArgs());
            }
        }

        private void txtSenhaAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnAlterarSalvarSenha_Click(btnAlterarSalvarSenha, new EventArgs());
            }
        }

        private void txtNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnAlterarSalvarSenha_Click(btnAlterarSalvarSenha, new EventArgs());
            }
        }

        private void txtConfimaNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnAlterarSalvarSenha_Click(btnAlterarSalvarSenha, new EventArgs());
            }
        }

        private void cbxCubeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMyRecords.Clear();
            StartRecodList();
            List<Record> records = Record.RecuperaRecords(Usuario.Id);
            if (cbxCubeTypes.SelectedIndex == 1)
            {
                int count = 1;

                foreach (Record record in records)
                {
                    string tempo = string.Format("{0:mm\\:ss\\:fff}", record.MelhorTempo);
                    ListViewItem recordList = lstMyRecords.Items.Add((count).ToString() + "-");
                    recordList.SubItems.Add(new ListViewItem.ListViewSubItem(null, tempo.ToString()));
                    recordList.SubItems.Add(new ListViewItem.ListViewSubItem(null, record.Data.ToString("dd/MM/yyyy")));
                    count++;
                }
            }
            else
            {
                int count = 1;

                foreach (Record record in records)
                {
                    string tempo = string.Format("{0:mm\\:ss\\:fff}", record.MelhorTempo);
                    ListViewItem recordList = lstMyRecords.Items.Add("");
                    recordList.SubItems.Add(new ListViewItem.ListViewSubItem(null, ""));
                    recordList.SubItems.Add(new ListViewItem.ListViewSubItem(null, ""));
                    count++;
                }
            }
        }
    }
}
