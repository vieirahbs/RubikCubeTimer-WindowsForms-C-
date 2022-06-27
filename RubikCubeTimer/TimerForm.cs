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
            string[] nomeVect = Usuario.Nome.Split(' ');
            btnMyAccount.Text = $"{nomeVect[0]}'s account";
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
            lstTimes.Columns.Insert(0, "", 120, HorizontalAlignment.Center);
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
                return $"Best time: {string.Format("{0:mm\\:ss\\:fff} ", recordATual.MelhorTempo)} - " +
                                $"{recordATual.Data.ToString("dd/MMM/yyyy")}";
            }
            else
            {
                return $"Best time: None.";
            }

        }

        private bool VerificaRecord(string record)
        {
            bool retorno = false;

            string[] recordVect = record.ToString().Split(':');
            int minuto = int.Parse(recordVect[0]);
            int segundo = int.Parse(recordVect[1]);
            int centezimo = int.Parse(recordVect[2]);
            TimeSpan recordTS = new TimeSpan(0, minuto, segundo, centezimo);

            List<Record> records = Record.RecuperaRecords();

            if (records.Count == 0)
            {
                string mensagem = "Do you want to save your first best time?";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(mensagem, this.Text, botoes);
                if (resultado == DialogResult.Yes)
                {
                    retorno = Record.CreateNovoRecord(Usuario.Id, record, DateTime.Now.ToString("dd/MM/yyyy"));
                    lblMelhorTempo.Text = $"Best time: {lblTimer.Text} - {DateTime.Now.ToString("dd/MMM/yyyy")}";
                }
            }
            else
            {
                foreach (Record item in records)
                {
                    if (recordTS < item.MelhorTempo)
                    {
                        string mensagem = "Congratulation! You beat your record! Do you want to save it?";
                        MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                        DialogResult resultado;
                        resultado = MessageBox.Show(mensagem, this.Text, botoes);
                        if (resultado == DialogResult.Yes)
                        {
                            retorno = Record.CreateNovoRecord(Usuario.Id, record, DateTime.Now.ToString("dd/MM/yyyy"));
                            lblMelhorTempo.Text = $"Best time: {lblTimer.Text} - {DateTime.Now.ToString("dd/MMM/yyyy")}";
                        }
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
                ListViewItem timesList = lstTimes.Items.Add(lblTimer.Text);
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
    }
}
