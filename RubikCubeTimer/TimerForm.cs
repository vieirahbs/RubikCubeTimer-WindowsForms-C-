using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;

namespace RubikCubeTimer
{
    public partial class TimerForm : Form
    {
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
            stopwatch = new Stopwatch();
            btnStartStop.Focus();
            isActive = false;
            isReset = true;
            StartTimerList();
        }

        private void StartTimerList()
        {
            lstTimes.Clear();
            lstTimes.Columns.Insert(0, "", 200, HorizontalAlignment.Center);

        }


        private void timerRubik_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = string.Format("{0:mm\\:ss\\:ff}", stopwatch.Elapsed);
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

    }
}
