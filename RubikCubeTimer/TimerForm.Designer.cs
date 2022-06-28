
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.lstTimes = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerRubik = new System.Windows.Forms.Timer(this.components);
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioMirrorBlocks = new System.Windows.Forms.RadioButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.radioPyraminx = new System.Windows.Forms.RadioButton();
            this.btmReset = new System.Windows.Forms.Button();
            this.radioMegaminx = new System.Windows.Forms.RadioButton();
            this.lblAvarage = new System.Windows.Forms.Label();
            this.radio5x5 = new System.Windows.Forms.RadioButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.radio4x4 = new System.Windows.Forms.RadioButton();
            this.radio2x2 = new System.Windows.Forms.RadioButton();
            this.radio3x3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMelhorTempo = new System.Windows.Forms.Label();
            this.pnlRubikImage = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.tabMyAccount = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.pnlRubikImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTimer.SuspendLayout();
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
            this.lstTimes.Location = new System.Drawing.Point(3, 23);
            this.lstTimes.Name = "lstTimes";
            this.lstTimes.Size = new System.Drawing.Size(172, 544);
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
            this.btnLogout.Location = new System.Drawing.Point(934, 354);
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
            this.btnStartStop.Location = new System.Drawing.Point(295, 222);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(279, 50);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start/Stop";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioMirrorBlocks);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.radioPyraminx);
            this.panel1.Controls.Add(this.btmReset);
            this.panel1.Controls.Add(this.radioMegaminx);
            this.panel1.Controls.Add(this.lblAvarage);
            this.panel1.Controls.Add(this.radio5x5);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.radio4x4);
            this.panel1.Controls.Add(this.radio2x2);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.radio3x3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(204, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 427);
            this.panel1.TabIndex = 15;
            // 
            // radioMirrorBlocks
            // 
            this.radioMirrorBlocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioMirrorBlocks.AutoSize = true;
            this.radioMirrorBlocks.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radioMirrorBlocks.FlatAppearance.BorderSize = 2;
            this.radioMirrorBlocks.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioMirrorBlocks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioMirrorBlocks.Location = new System.Drawing.Point(627, 11);
            this.radioMirrorBlocks.Name = "radioMirrorBlocks";
            this.radioMirrorBlocks.Size = new System.Drawing.Size(153, 31);
            this.radioMirrorBlocks.TabIndex = 9;
            this.radioMirrorBlocks.Text = "Mirror Blocks";
            this.radioMirrorBlocks.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLogo.Location = new System.Drawing.Point(211, 346);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(453, 54);
            this.lblLogo.TabIndex = 22;
            this.lblLogo.Text = "Rubik\'s Cube Timer";
            // 
            // radioPyraminx
            // 
            this.radioPyraminx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioPyraminx.AutoSize = true;
            this.radioPyraminx.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radioPyraminx.FlatAppearance.BorderSize = 2;
            this.radioPyraminx.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioPyraminx.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioPyraminx.Location = new System.Drawing.Point(509, 11);
            this.radioPyraminx.Name = "radioPyraminx";
            this.radioPyraminx.Size = new System.Drawing.Size(112, 31);
            this.radioPyraminx.TabIndex = 8;
            this.radioPyraminx.Text = "Pyraminx";
            this.radioPyraminx.UseVisualStyleBackColor = true;
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
            this.btmReset.Location = new System.Drawing.Point(368, 282);
            this.btmReset.Name = "btmReset";
            this.btmReset.Size = new System.Drawing.Size(131, 37);
            this.btmReset.TabIndex = 1;
            this.btmReset.Text = "Reset All";
            this.btmReset.UseVisualStyleBackColor = false;
            this.btmReset.Click += new System.EventHandler(this.btmReset_Click);
            // 
            // radioMegaminx
            // 
            this.radioMegaminx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioMegaminx.AutoSize = true;
            this.radioMegaminx.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radioMegaminx.FlatAppearance.BorderSize = 2;
            this.radioMegaminx.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioMegaminx.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioMegaminx.Location = new System.Drawing.Point(383, 11);
            this.radioMegaminx.Name = "radioMegaminx";
            this.radioMegaminx.Size = new System.Drawing.Size(120, 31);
            this.radioMegaminx.TabIndex = 7;
            this.radioMegaminx.Text = "Megaminx";
            this.radioMegaminx.UseVisualStyleBackColor = true;
            // 
            // lblAvarage
            // 
            this.lblAvarage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvarage.AutoSize = true;
            this.lblAvarage.BackColor = System.Drawing.Color.Transparent;
            this.lblAvarage.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvarage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAvarage.Location = new System.Drawing.Point(276, 71);
            this.lblAvarage.Name = "lblAvarage";
            this.lblAvarage.Size = new System.Drawing.Size(307, 40);
            this.lblAvarage.TabIndex = 20;
            this.lblAvarage.Text = "Average: 00:00:000";
            // 
            // radio5x5
            // 
            this.radio5x5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio5x5.AutoSize = true;
            this.radio5x5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radio5x5.FlatAppearance.BorderSize = 2;
            this.radio5x5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio5x5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radio5x5.Location = new System.Drawing.Point(310, 11);
            this.radio5x5.Name = "radio5x5";
            this.radio5x5.Size = new System.Drawing.Size(65, 31);
            this.radio5x5.TabIndex = 6;
            this.radio5x5.Text = "5x5";
            this.radio5x5.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer.Location = new System.Drawing.Point(251, 129);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(367, 90);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "00:00:000";
            // 
            // radio4x4
            // 
            this.radio4x4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio4x4.AutoSize = true;
            this.radio4x4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radio4x4.FlatAppearance.BorderSize = 2;
            this.radio4x4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio4x4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radio4x4.Location = new System.Drawing.Point(241, 11);
            this.radio4x4.Name = "radio4x4";
            this.radio4x4.Size = new System.Drawing.Size(65, 31);
            this.radio4x4.TabIndex = 5;
            this.radio4x4.Text = "4x4";
            this.radio4x4.UseVisualStyleBackColor = true;
            // 
            // radio2x2
            // 
            this.radio2x2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio2x2.AutoSize = true;
            this.radio2x2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radio2x2.FlatAppearance.BorderSize = 2;
            this.radio2x2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio2x2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radio2x2.Location = new System.Drawing.Point(99, 11);
            this.radio2x2.Name = "radio2x2";
            this.radio2x2.Size = new System.Drawing.Size(65, 31);
            this.radio2x2.TabIndex = 3;
            this.radio2x2.Text = "2x2";
            this.radio2x2.UseVisualStyleBackColor = true;
            // 
            // radio3x3
            // 
            this.radio3x3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio3x3.AutoSize = true;
            this.radio3x3.Checked = true;
            this.radio3x3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.radio3x3.FlatAppearance.BorderSize = 2;
            this.radio3x3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio3x3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radio3x3.Location = new System.Drawing.Point(170, 11);
            this.radio3x3.Name = "radio3x3";
            this.radio3x3.Size = new System.Drawing.Size(65, 31);
            this.radio3x3.TabIndex = 4;
            this.radio3x3.TabStop = true;
            this.radio3x3.Text = "3x3";
            this.radio3x3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 15);
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
            this.lblMelhorTempo.Location = new System.Drawing.Point(8, 568);
            this.lblMelhorTempo.Name = "lblMelhorTempo";
            this.lblMelhorTempo.Size = new System.Drawing.Size(142, 27);
            this.lblMelhorTempo.TabIndex = 19;
            this.lblMelhorTempo.Text = "Melhor Tempo";
            // 
            // pnlRubikImage
            // 
            this.pnlRubikImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRubikImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlRubikImage.Controls.Add(this.lblNome);
            this.pnlRubikImage.Controls.Add(this.pctLogo);
            this.pnlRubikImage.Location = new System.Drawing.Point(204, 6);
            this.pnlRubikImage.Name = "pnlRubikImage";
            this.pnlRubikImage.Size = new System.Drawing.Size(1081, 205);
            this.pnlRubikImage.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNome.Location = new System.Drawing.Point(856, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 35);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome ";
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = global::RubikCubeTimer.Properties.Resources.RubikCube;
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.Location = new System.Drawing.Point(331, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(200, 200);
            this.pctLogo.TabIndex = 6;
            this.pctLogo.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTimer);
            this.tabControl.Controls.Add(this.tabMyAccount);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1297, 679);
            this.tabControl.TabIndex = 22;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.pnlRubikImage);
            this.tabTimer.Controls.Add(this.lblMelhorTempo);
            this.tabTimer.Controls.Add(this.panel1);
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.lstTimes);
            this.tabTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabTimer.Location = new System.Drawing.Point(4, 44);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(1289, 631);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // tabMyAccount
            // 
            this.tabMyAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabMyAccount.Location = new System.Drawing.Point(4, 44);
            this.tabMyAccount.Name = "tabMyAccount";
            this.tabMyAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyAccount.Size = new System.Drawing.Size(1289, 631);
            this.tabMyAccount.TabIndex = 1;
            this.tabMyAccount.Text = "My account";
            this.tabMyAccount.UseVisualStyleBackColor = true;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 679);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerForm";
            this.Text = "Rubik\'s Cube Timer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerForm_FormClosed);
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRubikImage.ResumeLayout(false);
            this.pnlRubikImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblAvarage;
        private System.Windows.Forms.Panel pnlRubikImage;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btmReset;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.RadioButton radio3x3;
        private System.Windows.Forms.RadioButton radio2x2;
        private System.Windows.Forms.RadioButton radio4x4;
        private System.Windows.Forms.RadioButton radio5x5;
        private System.Windows.Forms.RadioButton radioMegaminx;
        private System.Windows.Forms.RadioButton radioPyraminx;
        private System.Windows.Forms.RadioButton radioMirrorBlocks;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabMyAccount;
        private System.Windows.Forms.Label lblNome;
    }
}