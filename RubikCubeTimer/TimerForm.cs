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
        private Record Record { get; set; }
        private CubeType TipoCubo { get; set; }
        private List<Record> Records { get; set; } = new List<Record>();
        private TimeSpan TempoTotal { get; set; }
        private Media5 Media5 { get; set; }
        private List<Media5> Medias5 { get; set; } = new List<Media5>();
        
        


        private int Contador = 0;
        private int ContadorMedia5 = 0;
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
            ContadorMedia5 = 0;
            radio3x3.Checked = true;
            TempoTotal = new TimeSpan();
            lblMelhorTempo.Text = ObtemRecordAtual();
            lblMelhorMedia5.Text = ObtemMedia5Atual();
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
            pnlDeleteMyAccount.Visible = false;
            btnCancelDeletion.Visible = false;
            #endregion

            #region My records
            cbxCubeTypes.Items.Clear();
            cbxCubeTypes.Items.Add("2x2");
            cbxCubeTypes.Items.Add("3x3");
            cbxCubeTypes.Items.Add("4x4");
            cbxCubeTypes.Items.Add("5x5");
            cbxCubeTypes.Items.Add("Megaminx");
            cbxCubeTypes.Items.Add("Piraminx");
            cbxCubeTypes.Items.Add("Mirror Blocks");
            StartRecordList();
            cbxCubeTypes.SelectedIndex = 1;

            StartMedia5List();

            #endregion
        }

        #region Métodos de Record
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

        private void StartRecordList()
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
            Record = Record.RecuperaRecordAtual(Usuario.Id, TipoCubo);

            if (Record.Id != 0)
            {
                if (Record.TipoCubo == CubeType.C2x2 ||
                    Record.TipoCubo == CubeType.C3x3 ||
                    Record.TipoCubo == CubeType.C4x4 ||
                    Record.TipoCubo == CubeType.C5x5)
                {
                    string tipoCubo = Record.TipoCubo.ToString().Substring(1);

                    return $"Best time in {tipoCubo}: {string.Format("{0:mm\\:ss\\:fff} ", Record.MelhorTempo)}- " +
                                    $"{Record.Data.ToString("dd/MMM/yyyy")}";
                }
                else
                {
                    string tipoCubo = Record.TipoCubo.ToString().Substring(1);

                    return $"Best time in {Record.TipoCubo}: {string.Format("{0:mm\\:ss\\:fff} ", Record.MelhorTempo)}- " +
                                    $"{Record.Data.ToString("dd/MMM/yyyy")}";
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
            //List<Record> records = new List<Record>();

            Records = Record.RecuperaRecords(Usuario.Id, TipoCubo);

            if (Records.Count == 0)
            {
                string mensagem = "Do you want to save your first best time?";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(mensagem, this.Text, botoes);
                if (resultado == DialogResult.Yes)
                {
                    retorno = Record.CreateNovoRecord(Usuario.Id, TipoCubo, tempo, DateTime.Now.ToString("dd/MM/yyyy"));

                    lblMelhorTempo.Text = ObtemRecordAtual();
                    
                }
            }
            else
            {
                if (tempoTS < Record.MelhorTempo)
                {
                    string mensagem = "Well done! You beat your record! Do you want to save it?";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    DialogResult resultado;
                    resultado = MessageBox.Show(mensagem, this.Text, botoes);
                    if (resultado == DialogResult.Yes)
                    {
                        retorno = Record.CreateNovoRecord(Usuario.Id, TipoCubo, tempo, DateTime.Now.ToString("dd/MM/yyyy"));

                        lblMelhorTempo.Text = ObtemRecordAtual();
                    }
                }

            }

            return retorno;
        }

        #endregion

        #region Métodos de Média

        private void StartMedia5List()
        {
            lstMedia5.Clear();
            lstMedia5.Columns.Insert(0, "", 45, HorizontalAlignment.Center);
            lstMedia5.Columns.Insert(1, "Time", 120, HorizontalAlignment.Center);
            lstMedia5.Columns.Insert(2, "Date", 150, HorizontalAlignment.Center);

            Medias5 = Media5.RecuperaMelhoresMedia5(Usuario.Id, CubeType.C3x3);
            int count = 1;
            
            foreach (Media5 item in Medias5)
            {
                string media5String = string.Format("{0:mm\\:ss\\:fff} ", item.MelhorMedia);
                
                ListViewItem media5List = lstMedia5.Items.Add((count).ToString() + "-");
                media5List.SubItems.Add(new ListViewItem.ListViewSubItem(null, media5String));
                media5List.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Data.ToString("dd/MM/yyyy")));
                count++;
            }
            

        }

        private bool VerificaMelhorMedia5(string lblMedia5)
        {
            bool retorno = false;

            string media5 = lblMedia5.Substring(9);
            string[] tempoVect = media5.ToString().Split(':');
            int minuto = int.Parse(tempoVect[0]);
            int segundo = int.Parse(tempoVect[1]);
            int centezimo = int.Parse(tempoVect[2]);
            TimeSpan media5TS = new TimeSpan(0, 0, minuto, segundo, centezimo);

            Medias5 = Media5.RecuperaMelhoresMedia5(Usuario.Id, TipoCubo);

            if (Medias5.Count == 0)
            {
                string mensagem = "Do you want to save your first best average of 5 in 3x3?";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(mensagem, this.Text, botoes);
                if (resultado == DialogResult.Yes)
                {
                    retorno = Media5.CreateNovaMelhorMedia5(Usuario.Id, TipoCubo, media5, DateTime.Now.ToString("dd/MM/yyyy"));

                    lblMelhorMedia5.Text = ObtemMedia5Atual();

                }
            }
            else
            {                
                if (media5TS < Media5.MelhorMedia)
                {
                    string mensagem = "Well done! You beat your average of 5 in 3x3! Do you want to save it?";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    DialogResult resultado;
                    resultado = MessageBox.Show(mensagem, this.Text, botoes);
                    if (resultado == DialogResult.Yes)
                    {
                        retorno = Media5.CreateNovaMelhorMedia5(Usuario.Id, TipoCubo, media5, DateTime.Now.ToString("dd/MM/yyyy"));

                        lblMelhorMedia5.Text = ObtemMedia5Atual();
                    }
                }

            }

            return retorno;
        }

        private string ObtemMedia5Atual()
        {
            Media5 = Media5.RecuperaMedia5Atual(Usuario.Id, TipoCubo);

            if (Media5.Id != 0)
            {
                if (Media5.TipoCubo == CubeType.C2x2 ||
                    Media5.TipoCubo == CubeType.C3x3 ||
                    Media5.TipoCubo == CubeType.C4x4 ||
                    Media5.TipoCubo == CubeType.C5x5)
                {
                    string tipoCubo = Media5.TipoCubo.ToString().Substring(1);

                    return $"Best Average of 5 in {tipoCubo}: {string.Format("{0:mm\\:ss\\:fff} ", Media5.MelhorMedia)}- " +
                                    $"{Media5.Data.ToString("dd/MMM/yyyy")}";
                }
                else
                {
                    string tipoCubo = Media5.TipoCubo.ToString().Substring(1);

                    return $"Best Average of 5 in: {Media5.TipoCubo}: {string.Format("{0:mm\\:ss\\:fff} ", Media5.MelhorMedia)}- " +
                                    $"{Media5.Data.ToString("dd/MMM/yyyy")}";
                }
            }
            else
            {
                return $"Best Average of 5 in 3x3: None.";
            }

        }

        #endregion

        #region Eventos de componentes

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
                ContadorMedia5++;
                if (ContadorMedia5 == 5)
                {
                    VerificaMelhorMedia5(lblAvarage.Text);
                    ContadorMedia5 = 0;
                }
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
                    txtName.Focus();
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
                    txtNovaSenha.Text = string.Empty;
                    txtConfimaNovaSenha.Text = string.Empty;
                    txtNovaSenha.Focus();
                    return;
                }

                Usuario usuarioDB = Usuario.ValidaUsuario(Usuario.Login, txtSenhaAtual.Text);

                if (usuarioDB.Login == null)
                {
                    MessageBox.Show("The current password informed is not correct.", this.Text);
                    txtSenhaAtual.Text = string.Empty;
                    txtSenhaAtual.Focus();
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
            StartRecordList();

            #region Verifica qual combobox está selecionado
            if (cbxCubeTypes.SelectedIndex == 0)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.C2x2);
            }
            else if (cbxCubeTypes.SelectedIndex == 1)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.C3x3);
            }
            else if (cbxCubeTypes.SelectedIndex == 2)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.C4x4);
            }
            else if (cbxCubeTypes.SelectedIndex == 3)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.C5x5);
            }
            else if (cbxCubeTypes.SelectedIndex == 4)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.Megaminx);
            }
            else if (cbxCubeTypes.SelectedIndex == 5)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.Piraminx);
            }
            else if (cbxCubeTypes.SelectedIndex == 6)
            {
                Records = Record.RecuperaRecords(Usuario.Id, CubeType.MirrorBlocks);
            }
            #endregion

            int count = 1;
            foreach (Record record in Records)
            {
                string tempo = string.Format("{0:mm\\:ss\\:fff}", record.MelhorTempo);
                ListViewItem recordList = lstMyRecords.Items.Add((count).ToString() + "-");
                recordList.SubItems.Add(new ListViewItem.ListViewSubItem(null, tempo.ToString()));
                recordList.SubItems.Add(new ListViewItem.ListViewSubItem(null, record.Data.ToString("dd/MM/yyyy")));
                count++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete my account")
            {
                btnDelete.Text = "Confirm deletion";
                pnlDeleteMyAccount.Visible = true;
                btnCancelDeletion.Visible = true;
            }
            else if (btnDelete.Text == "Confirm deletion")
            {
                if (txtDeleteAccount.Text == string.Empty.Trim())
                {
                    MessageBox.Show("Inform your password to proceed.", this.Text);
                    return;
                }
                string mensagem = "Are you sure you want to delete your account?";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(mensagem, this.Text, botoes);
                if (resultado == DialogResult.Yes)
                {
                    bool contaDeletada = Usuario.DeleteUsuario(Usuario.Id, Usuario.Login, txtDeleteAccount.Text);
                    if (contaDeletada)
                    {
                        MessageBox.Show("Your account was deleted successfully.", this.Text);
                        btnLogout_Click(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.", this.Text);
                        txtDeleteAccount.Text = string.Empty;
                        txtDeleteAccount.Focus();
                        return;
                    }
                }
            }
        }

        private void txtDeleteAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnDelete_Click(btnDelete, new EventArgs());
            }
        }

        private void btnCancelDeletion_Click(object sender, EventArgs e)
        {
            btnDelete.Text = "Delete my account";
            pnlDeleteMyAccount.Visible = false;
            btnCancelDeletion.Visible = false;
        }

        private void radio2x2_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.Cubo2x2;
            TipoCubo = CubeType.C2x2;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }

        private void radio3x3_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.RubikCube;
            TipoCubo = CubeType.C3x3;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }

        private void radio4x4_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.Cubo4x4;
            TipoCubo = CubeType.C4x4;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }

        private void radio5x5_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.Cubo5x5;
            TipoCubo = CubeType.C5x5;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }

        private void radioMegaminx_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.Megaminx;
            TipoCubo = CubeType.Megaminx;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }

        private void radioPyraminx_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.Pyraminx;
            TipoCubo = CubeType.Piraminx;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }

        private void radioMirrorBlocks_CheckedChanged(object sender, EventArgs e)
        {
            StartTimerList();
            pctLogo.BackgroundImage = Properties.Resources.MirrorBlocks;
            TipoCubo = CubeType.MirrorBlocks;
            lblMelhorTempo.Text = ObtemRecordAtual();
            btnStartStop.Focus();
        }
        #endregion
    }
}
