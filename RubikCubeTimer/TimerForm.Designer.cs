
namespace RubikCubeTimer
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Times");
            this.lstTimes = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerRubik = new System.Windows.Forms.Timer(this.components);
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btmReset = new System.Windows.Forms.Button();
            this.lblAvarage = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMelhorTempo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRubikImage = new System.Windows.Forms.Panel();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlRubikImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTimes
            // 
            this.lstTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTimes.BackColor = System.Drawing.Color.White;
            this.lstTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTimes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstTimes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lstTimes.FullRowSelect = true;
            this.lstTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTimes.HideSelection = false;
            this.lstTimes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstTimes.Location = new System.Drawing.Point(36, 23);
            this.lstTimes.Name = "lstTimes";
            this.lstTimes.Size = new System.Drawing.Size(172, 564);
            this.lstTimes.TabIndex = 0;
            this.lstTimes.UseCompatibleStateImageBehavior = false;
            this.lstTimes.View = System.Windows.Forms.View.Details;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.Location = new System.Drawing.Point(855, 302);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 42);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timerRubik
            // 
            this.timerRubik.Enabled = true;
            this.timerRubik.Interval = 10;
            this.timerRubik.Tick += new System.EventHandler(this.timerRubik_Tick);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(211, 178);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(279, 50);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start/Stop";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.btmReset);
            this.panel1.Controls.Add(this.lblAvarage);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(300, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 374);
            this.panel1.TabIndex = 15;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLogo.Location = new System.Drawing.Point(127, 302);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(453, 54);
            this.lblLogo.TabIndex = 22;
            this.lblLogo.Text = "Rubik\'s Cube Timer";
            // 
            // btmReset
            // 
            this.btmReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmReset.BackColor = System.Drawing.Color.White;
            this.btmReset.FlatAppearance.BorderSize = 2;
            this.btmReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btmReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btmReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmReset.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btmReset.Location = new System.Drawing.Point(284, 238);
            this.btmReset.Name = "btmReset";
            this.btmReset.Size = new System.Drawing.Size(131, 37);
            this.btmReset.TabIndex = 21;
            this.btmReset.Text = "Reset All";
            this.btmReset.UseVisualStyleBackColor = false;
            this.btmReset.Click += new System.EventHandler(this.btmReset_Click);
            // 
            // lblAvarage
            // 
            this.lblAvarage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvarage.AutoSize = true;
            this.lblAvarage.BackColor = System.Drawing.Color.Transparent;
            this.lblAvarage.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvarage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAvarage.Location = new System.Drawing.Point(195, 14);
            this.lblAvarage.Name = "lblAvarage";
            this.lblAvarage.Size = new System.Drawing.Size(307, 40);
            this.lblAvarage.TabIndex = 20;
            this.lblAvarage.Text = "Average: 00:00:000";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer.Location = new System.Drawing.Point(215, 108);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(274, 67);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "00:00:000";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Times          ";
            // 
            // lblMelhorTempo
            // 
            this.lblMelhorTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMelhorTempo.AutoSize = true;
            this.lblMelhorTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblMelhorTempo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelhorTempo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMelhorTempo.Location = new System.Drawing.Point(3, 599);
            this.lblMelhorTempo.Name = "lblMelhorTempo";
            this.lblMelhorTempo.Size = new System.Drawing.Size(142, 27);
            this.lblMelhorTempo.TabIndex = 19;
            this.lblMelhorTempo.Text = "Melhor Tempo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1107, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start/Stop";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlRubikImage
            // 
            this.pnlRubikImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRubikImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlRubikImage.Controls.Add(this.btnMyAccount);
            this.pnlRubikImage.Controls.Add(this.pctLogo);
            this.pnlRubikImage.Location = new System.Drawing.Point(300, 10);
            this.pnlRubikImage.Name = "pnlRubikImage";
            this.pnlRubikImage.Size = new System.Drawing.Size(995, 215);
            this.pnlRubikImage.TabIndex = 21;
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyAccount.BackColor = System.Drawing.Color.White;
            this.btnMyAccount.FlatAppearance.BorderSize = 2;
            this.btnMyAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnMyAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMyAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMyAccount.Location = new System.Drawing.Point(750, 25);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(220, 43);
            this.btnMyAccount.TabIndex = 23;
            this.btnMyAccount.Text = "My account";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = global::RubikCubeTimer.Properties.Resources.RubikCube;
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.Location = new System.Drawing.Point(241, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(200, 200);
            this.pctLogo.TabIndex = 6;
            this.pctLogo.TabStop = false;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 679);
            this.Controls.Add(this.pnlRubikImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMelhorTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTimes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TimerForm";
            this.Text = "Rubik\'s Cube Timer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerForm_FormClosed);
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRubikImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerRubik;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ListView lstTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMelhorTempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAvarage;
        private System.Windows.Forms.Panel pnlRubikImage;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btmReset;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMyAccount;
    }
}