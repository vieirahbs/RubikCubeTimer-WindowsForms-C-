
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Times");
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
            this.btnCancelDeletion = new System.Windows.Forms.Button();
            this.pnlDeleteMyAccount = new System.Windows.Forms.Panel();
            this.txtDeleteAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelSenhaEdit = new System.Windows.Forms.Button();
            this.btnCancelNameEdit = new System.Windows.Forms.Button();
            this.btnEditarSalvarNome = new System.Windows.Forms.Button();
            this.pnlAlterarSenha = new System.Windows.Forms.Panel();
            this.txtConfimaNovaSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterarSalvarSenha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMyRecords = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxCubeTypes = new System.Windows.Forms.ComboBox();
            this.lstMyRecords = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRubikImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.tabMyAccount.SuspendLayout();
            this.pnlDeleteMyAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAlterarSenha.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMyRecords.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(204, 270);
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
            this.radio2x2.CheckedChanged += new System.EventHandler(this.radio2x2_CheckedChanged);
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
            this.radio3x3.CheckedChanged += new System.EventHandler(this.radio3x3_CheckedChanged);
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
            this.lblMelhorTempo.Location = new System.Drawing.Point(6, 669);
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
            this.tabControl.Controls.Add(this.tabMyRecords);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1297, 749);
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
            this.tabTimer.Size = new System.Drawing.Size(1289, 701);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // tabMyAccount
            // 
            this.tabMyAccount.Controls.Add(this.btnCancelDeletion);
            this.tabMyAccount.Controls.Add(this.pnlDeleteMyAccount);
            this.tabMyAccount.Controls.Add(this.btnDelete);
            this.tabMyAccount.Controls.Add(this.panel3);
            this.tabMyAccount.Controls.Add(this.label3);
            this.tabMyAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabMyAccount.Location = new System.Drawing.Point(4, 44);
            this.tabMyAccount.Name = "tabMyAccount";
            this.tabMyAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyAccount.Size = new System.Drawing.Size(1289, 701);
            this.tabMyAccount.TabIndex = 1;
            this.tabMyAccount.Text = "My account";
            this.tabMyAccount.UseVisualStyleBackColor = true;
            // 
            // btnCancelDeletion
            // 
            this.btnCancelDeletion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelDeletion.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelDeletion.FlatAppearance.BorderSize = 0;
            this.btnCancelDeletion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDeletion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelDeletion.ForeColor = System.Drawing.Color.White;
            this.btnCancelDeletion.Location = new System.Drawing.Point(962, 632);
            this.btnCancelDeletion.Name = "btnCancelDeletion";
            this.btnCancelDeletion.Size = new System.Drawing.Size(120, 31);
            this.btnCancelDeletion.TabIndex = 36;
            this.btnCancelDeletion.Text = "Cancel";
            this.btnCancelDeletion.UseVisualStyleBackColor = false;
            this.btnCancelDeletion.Click += new System.EventHandler(this.btnCancelDeletion_Click);
            // 
            // pnlDeleteMyAccount
            // 
            this.pnlDeleteMyAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDeleteMyAccount.Controls.Add(this.txtDeleteAccount);
            this.pnlDeleteMyAccount.Controls.Add(this.label8);
            this.pnlDeleteMyAccount.Location = new System.Drawing.Point(955, 548);
            this.pnlDeleteMyAccount.Name = "pnlDeleteMyAccount";
            this.pnlDeleteMyAccount.Size = new System.Drawing.Size(292, 78);
            this.pnlDeleteMyAccount.TabIndex = 41;
            // 
            // txtDeleteAccount
            // 
            this.txtDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeleteAccount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtDeleteAccount.Location = new System.Drawing.Point(7, 36);
            this.txtDeleteAccount.Name = "txtDeleteAccount";
            this.txtDeleteAccount.Size = new System.Drawing.Size(277, 37);
            this.txtDeleteAccount.TabIndex = 39;
            this.txtDeleteAccount.UseSystemPasswordChar = true;
            this.txtDeleteAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeleteAccount_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(7, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 27);
            this.label8.TabIndex = 40;
            this.label8.Text = "Inform your password";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(1088, 632);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 31);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete my account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelSenhaEdit);
            this.panel3.Controls.Add(this.btnCancelNameEdit);
            this.panel3.Controls.Add(this.btnEditarSalvarNome);
            this.panel3.Controls.Add(this.pnlAlterarSenha);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnAlterarSalvarSenha);
            this.panel3.Location = new System.Drawing.Point(6, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 554);
            this.panel3.TabIndex = 36;
            // 
            // btnCancelSenhaEdit
            // 
            this.btnCancelSenhaEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelSenhaEdit.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelSenhaEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelSenhaEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSenhaEdit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelSenhaEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelSenhaEdit.Location = new System.Drawing.Point(246, 234);
            this.btnCancelSenhaEdit.Name = "btnCancelSenhaEdit";
            this.btnCancelSenhaEdit.Size = new System.Drawing.Size(116, 37);
            this.btnCancelSenhaEdit.TabIndex = 7;
            this.btnCancelSenhaEdit.Text = "Cancel";
            this.btnCancelSenhaEdit.UseVisualStyleBackColor = false;
            this.btnCancelSenhaEdit.Click += new System.EventHandler(this.btnCancelSenhaEdit_Click);
            // 
            // btnCancelNameEdit
            // 
            this.btnCancelNameEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelNameEdit.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelNameEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelNameEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNameEdit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelNameEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelNameEdit.Location = new System.Drawing.Point(246, 15);
            this.btnCancelNameEdit.Name = "btnCancelNameEdit";
            this.btnCancelNameEdit.Size = new System.Drawing.Size(116, 37);
            this.btnCancelNameEdit.TabIndex = 2;
            this.btnCancelNameEdit.Text = "Cancel";
            this.btnCancelNameEdit.UseVisualStyleBackColor = false;
            this.btnCancelNameEdit.Click += new System.EventHandler(this.btnCancelNameEdite_Click);
            // 
            // btnEditarSalvarNome
            // 
            this.btnEditarSalvarNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditarSalvarNome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarSalvarNome.FlatAppearance.BorderSize = 0;
            this.btnEditarSalvarNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSalvarNome.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarSalvarNome.ForeColor = System.Drawing.Color.White;
            this.btnEditarSalvarNome.Location = new System.Drawing.Point(370, 15);
            this.btnEditarSalvarNome.Name = "btnEditarSalvarNome";
            this.btnEditarSalvarNome.Size = new System.Drawing.Size(244, 37);
            this.btnEditarSalvarNome.TabIndex = 0;
            this.btnEditarSalvarNome.Text = "Edit name";
            this.btnEditarSalvarNome.UseVisualStyleBackColor = false;
            this.btnEditarSalvarNome.Click += new System.EventHandler(this.btnEditarSalvarNome_Click);
            // 
            // pnlAlterarSenha
            // 
            this.pnlAlterarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlterarSenha.Controls.Add(this.txtConfimaNovaSenha);
            this.pnlAlterarSenha.Controls.Add(this.label5);
            this.pnlAlterarSenha.Controls.Add(this.txtNovaSenha);
            this.pnlAlterarSenha.Controls.Add(this.label2);
            this.pnlAlterarSenha.Controls.Add(this.txtSenhaAtual);
            this.pnlAlterarSenha.Controls.Add(this.lblPassword);
            this.pnlAlterarSenha.Location = new System.Drawing.Point(12, 278);
            this.pnlAlterarSenha.Name = "pnlAlterarSenha";
            this.pnlAlterarSenha.Size = new System.Drawing.Size(602, 273);
            this.pnlAlterarSenha.TabIndex = 35;
            // 
            // txtConfimaNovaSenha
            // 
            this.txtConfimaNovaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfimaNovaSenha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConfimaNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtConfimaNovaSenha.Location = new System.Drawing.Point(20, 214);
            this.txtConfimaNovaSenha.Name = "txtConfimaNovaSenha";
            this.txtConfimaNovaSenha.Size = new System.Drawing.Size(563, 37);
            this.txtConfimaNovaSenha.TabIndex = 6;
            this.txtConfimaNovaSenha.UseSystemPasswordChar = true;
            this.txtConfimaNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfimaNovaSenha_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(20, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Confirm your new password";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovaSenha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtNovaSenha.Location = new System.Drawing.Point(20, 140);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(563, 37);
            this.txtNovaSenha.TabIndex = 5;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            this.txtNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovaSenha_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Inform your new password";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaAtual.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtSenhaAtual.Location = new System.Drawing.Point(20, 42);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(563, 37);
            this.txtSenhaAtual.TabIndex = 4;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            this.txtSenhaAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaAtual_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPassword.Location = new System.Drawing.Point(20, 12);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(290, 27);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Inform your current password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(12, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 149);
            this.panel2.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblID.Location = new System.Drawing.Point(121, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 27);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "Id";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(82, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "Id:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUsername.Location = new System.Drawing.Point(13, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 27);
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Username:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtName.Location = new System.Drawing.Point(120, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 37);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLogin.Location = new System.Drawing.Point(121, 52);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(102, 27);
            this.lblLogin.TabIndex = 26;
            this.lblLogin.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name:";
            // 
            // btnAlterarSalvarSenha
            // 
            this.btnAlterarSalvarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlterarSalvarSenha.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterarSalvarSenha.FlatAppearance.BorderSize = 0;
            this.btnAlterarSalvarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSalvarSenha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarSalvarSenha.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSalvarSenha.Location = new System.Drawing.Point(370, 233);
            this.btnAlterarSalvarSenha.Name = "btnAlterarSalvarSenha";
            this.btnAlterarSalvarSenha.Size = new System.Drawing.Size(244, 39);
            this.btnAlterarSalvarSenha.TabIndex = 3;
            this.btnAlterarSalvarSenha.Text = "Change password";
            this.btnAlterarSalvarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSalvarSenha.Click += new System.EventHandler(this.btnAlterarSalvarSenha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 49);
            this.label3.TabIndex = 29;
            this.label3.Text = "My information";
            // 
            // tabMyRecords
            // 
            this.tabMyRecords.Controls.Add(this.panel4);
            this.tabMyRecords.Controls.Add(this.label6);
            this.tabMyRecords.Location = new System.Drawing.Point(4, 44);
            this.tabMyRecords.Name = "tabMyRecords";
            this.tabMyRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyRecords.Size = new System.Drawing.Size(1289, 701);
            this.tabMyRecords.TabIndex = 2;
            this.tabMyRecords.Text = "My records";
            this.tabMyRecords.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxCubeTypes);
            this.panel4.Controls.Add(this.lstMyRecords);
            this.panel4.Location = new System.Drawing.Point(73, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 529);
            this.panel4.TabIndex = 31;
            // 
            // cbxCubeTypes
            // 
            this.cbxCubeTypes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbxCubeTypes.FormattingEnabled = true;
            this.cbxCubeTypes.Location = new System.Drawing.Point(0, 0);
            this.cbxCubeTypes.Name = "cbxCubeTypes";
            this.cbxCubeTypes.Size = new System.Drawing.Size(316, 43);
            this.cbxCubeTypes.TabIndex = 2;
            this.cbxCubeTypes.SelectedIndexChanged += new System.EventHandler(this.cbxCubeTypes_SelectedIndexChanged);
            // 
            // lstMyRecords
            // 
            this.lstMyRecords.BackColor = System.Drawing.Color.White;
            this.lstMyRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMyRecords.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstMyRecords.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lstMyRecords.FullRowSelect = true;
            this.lstMyRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMyRecords.HideSelection = false;
            this.lstMyRecords.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstMyRecords.Location = new System.Drawing.Point(0, 49);
            this.lstMyRecords.Name = "lstMyRecords";
            this.lstMyRecords.Size = new System.Drawing.Size(503, 529);
            this.lstMyRecords.TabIndex = 1;
            this.lstMyRecords.UseCompatibleStateImageBehavior = false;
            this.lstMyRecords.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(73, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 49);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cube type";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 749);
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
            this.tabMyAccount.ResumeLayout(false);
            this.tabMyAccount.PerformLayout();
            this.pnlDeleteMyAccount.ResumeLayout(false);
            this.pnlDeleteMyAccount.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlAlterarSenha.ResumeLayout(false);
            this.pnlAlterarSenha.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMyRecords.ResumeLayout(false);
            this.tabMyRecords.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnEditarSalvarNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAlterarSalvarSenha;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlAlterarSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfimaNovaSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelSenhaEdit;
        private System.Windows.Forms.Button btnCancelNameEdit;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabMyRecords;
        private System.Windows.Forms.ListView lstMyRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCubeTypes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelDeletion;
        private System.Windows.Forms.Panel pnlDeleteMyAccount;
    }
}