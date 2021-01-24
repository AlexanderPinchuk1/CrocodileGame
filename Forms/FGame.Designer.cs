namespace CrocodileGame.Forms
{
    partial class FGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.PanelForDrawing = new System.Windows.Forms.Panel();
            this.ButClean = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TrackBarSizePen = new System.Windows.Forms.TrackBar();
            this.PanelForCheck = new System.Windows.Forms.Panel();
            this.LabWidth = new System.Windows.Forms.Label();
            this.PanelForColors = new System.Windows.Forms.Panel();
            this.PicBoxAqua = new System.Windows.Forms.PictureBox();
            this.PicBoxBrown = new System.Windows.Forms.PictureBox();
            this.PicBoxWhite = new System.Windows.Forms.PictureBox();
            this.PictureBoxRed = new System.Windows.Forms.PictureBox();
            this.PicBoxSilver = new System.Windows.Forms.PictureBox();
            this.PicBoxYellow = new System.Windows.Forms.PictureBox();
            this.PicBoxOrange = new System.Windows.Forms.PictureBox();
            this.PicBoxGreen = new System.Windows.Forms.PictureBox();
            this.PicBoxBlack = new System.Windows.Forms.PictureBox();
            this.PicBoxPurple = new System.Windows.Forms.PictureBox();
            this.PicBoxBlue = new System.Windows.Forms.PictureBox();
            this.PanelForTools = new System.Windows.Forms.Panel();
            this.PicBoxBrush = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ButSend = new System.Windows.Forms.Button();
            this.TimerCheckMessage = new System.Windows.Forms.Timer(this.components);
            this.TimerCheckNewDots = new System.Windows.Forms.Timer(this.components);
            this.ListViewChat = new System.Windows.Forms.ListView();
            this.ColumnForIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnForMessageText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.LabTime = new System.Windows.Forms.Label();
            this.LabSec = new System.Windows.Forms.Label();
            this.LabUser = new System.Windows.Forms.Label();
            this.TimerGameTime = new System.Windows.Forms.Timer(this.components);
            this.PictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.PictureBoxUser = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNumUsers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelGameWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSizePen)).BeginInit();
            this.PanelForColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBlue)).BeginInit();
            this.PanelForTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForDrawing
            // 
            this.PanelForDrawing.BackColor = System.Drawing.Color.Snow;
            this.PanelForDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelForDrawing.Location = new System.Drawing.Point(23, 47);
            this.PanelForDrawing.Name = "PanelForDrawing";
            this.PanelForDrawing.Size = new System.Drawing.Size(688, 373);
            this.PanelForDrawing.TabIndex = 0;
            this.PanelForDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelForDrawing_MouseDown);
            this.PanelForDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelForDrawing_MouseMove);
            this.PanelForDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelForDrawing_MouseUp);
            // 
            // ButClean
            // 
            this.ButClean.BackColor = System.Drawing.Color.LightCoral;
            this.ButClean.FlatAppearance.BorderSize = 0;
            this.ButClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButClean.Image = ((System.Drawing.Image)(resources.GetObject("ButClean.Image")));
            this.ButClean.Location = new System.Drawing.Point(609, 32);
            this.ButClean.Name = "ButClean";
            this.ButClean.Size = new System.Drawing.Size(56, 50);
            this.ButClean.TabIndex = 1;
            this.ButClean.UseVisualStyleBackColor = false;
            this.ButClean.Click += new System.EventHandler(this.ButClean_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 604);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // TrackBarSizePen
            // 
            this.TrackBarSizePen.LargeChange = 1;
            this.TrackBarSizePen.Location = new System.Drawing.Point(279, 16);
            this.TrackBarSizePen.Maximum = 50;
            this.TrackBarSizePen.Minimum = 1;
            this.TrackBarSizePen.Name = "TrackBarSizePen";
            this.TrackBarSizePen.Size = new System.Drawing.Size(283, 56);
            this.TrackBarSizePen.TabIndex = 4;
            this.TrackBarSizePen.Value = 6;
            this.TrackBarSizePen.Scroll += new System.EventHandler(this.TrackBarSizePen_Scroll);
            // 
            // PanelForCheck
            // 
            this.PanelForCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelForCheck.BackColor = System.Drawing.Color.Snow;
            this.PanelForCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelForCheck.Location = new System.Drawing.Point(15, 26);
            this.PanelForCheck.Margin = new System.Windows.Forms.Padding(0);
            this.PanelForCheck.Name = "PanelForCheck";
            this.PanelForCheck.Size = new System.Drawing.Size(79, 68);
            this.PanelForCheck.TabIndex = 5;
            // 
            // LabWidth
            // 
            this.LabWidth.AutoSize = true;
            this.LabWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabWidth.Location = new System.Drawing.Point(537, 151);
            this.LabWidth.Name = "LabWidth";
            this.LabWidth.Size = new System.Drawing.Size(52, 20);
            this.LabWidth.TabIndex = 6;
            this.LabWidth.Text = "Width";
            // 
            // PanelForColors
            // 
            this.PanelForColors.BackColor = System.Drawing.Color.MistyRose;
            this.PanelForColors.Controls.Add(this.PicBoxAqua);
            this.PanelForColors.Controls.Add(this.PicBoxBrown);
            this.PanelForColors.Controls.Add(this.PicBoxWhite);
            this.PanelForColors.Controls.Add(this.PictureBoxRed);
            this.PanelForColors.Controls.Add(this.PicBoxSilver);
            this.PanelForColors.Controls.Add(this.PicBoxYellow);
            this.PanelForColors.Controls.Add(this.PicBoxOrange);
            this.PanelForColors.Controls.Add(this.PicBoxGreen);
            this.PanelForColors.Controls.Add(this.PicBoxBlack);
            this.PanelForColors.Controls.Add(this.PicBoxPurple);
            this.PanelForColors.Controls.Add(this.PicBoxBlue);
            this.PanelForColors.Location = new System.Drawing.Point(198, 78);
            this.PanelForColors.Name = "PanelForColors";
            this.PanelForColors.Size = new System.Drawing.Size(373, 31);
            this.PanelForColors.TabIndex = 8;
            // 
            // PicBoxAqua
            // 
            this.PicBoxAqua.BackColor = System.Drawing.Color.Aqua;
            this.PicBoxAqua.Location = new System.Drawing.Point(172, 3);
            this.PicBoxAqua.Name = "PicBoxAqua";
            this.PicBoxAqua.Size = new System.Drawing.Size(28, 26);
            this.PicBoxAqua.TabIndex = 18;
            this.PicBoxAqua.TabStop = false;
            this.PicBoxAqua.Click += new System.EventHandler(this.PicBoxAqua_Click);
            // 
            // PicBoxBrown
            // 
            this.PicBoxBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PicBoxBrown.Location = new System.Drawing.Point(37, 3);
            this.PicBoxBrown.Name = "PicBoxBrown";
            this.PicBoxBrown.Size = new System.Drawing.Size(28, 26);
            this.PicBoxBrown.TabIndex = 17;
            this.PicBoxBrown.TabStop = false;
            this.PicBoxBrown.Click += new System.EventHandler(this.PicBoxBrown_Click);
            // 
            // PicBoxWhite
            // 
            this.PicBoxWhite.BackColor = System.Drawing.Color.White;
            this.PicBoxWhite.Location = new System.Drawing.Point(274, 3);
            this.PicBoxWhite.Name = "PicBoxWhite";
            this.PicBoxWhite.Size = new System.Drawing.Size(28, 26);
            this.PicBoxWhite.TabIndex = 16;
            this.PicBoxWhite.TabStop = false;
            this.PicBoxWhite.Click += new System.EventHandler(this.PicBoxWhite_Click);
            // 
            // PictureBoxRed
            // 
            this.PictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.PictureBoxRed.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxRed.Name = "PictureBoxRed";
            this.PictureBoxRed.Size = new System.Drawing.Size(28, 26);
            this.PictureBoxRed.TabIndex = 8;
            this.PictureBoxRed.TabStop = false;
            this.PictureBoxRed.Click += new System.EventHandler(this.PictureBoxRed_Click);
            // 
            // PicBoxSilver
            // 
            this.PicBoxSilver.BackColor = System.Drawing.Color.Silver;
            this.PicBoxSilver.Location = new System.Drawing.Point(308, 3);
            this.PicBoxSilver.Name = "PicBoxSilver";
            this.PicBoxSilver.Size = new System.Drawing.Size(28, 26);
            this.PicBoxSilver.TabIndex = 15;
            this.PicBoxSilver.TabStop = false;
            this.PicBoxSilver.Click += new System.EventHandler(this.PicBoxSilver_Click);
            // 
            // PicBoxYellow
            // 
            this.PicBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.PicBoxYellow.Location = new System.Drawing.Point(104, 3);
            this.PicBoxYellow.Name = "PicBoxYellow";
            this.PicBoxYellow.Size = new System.Drawing.Size(28, 26);
            this.PicBoxYellow.TabIndex = 9;
            this.PicBoxYellow.TabStop = false;
            this.PicBoxYellow.Click += new System.EventHandler(this.PicBoxYellow_Click);
            // 
            // PicBoxOrange
            // 
            this.PicBoxOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PicBoxOrange.Location = new System.Drawing.Point(70, 3);
            this.PicBoxOrange.Name = "PicBoxOrange";
            this.PicBoxOrange.Size = new System.Drawing.Size(28, 26);
            this.PicBoxOrange.TabIndex = 14;
            this.PicBoxOrange.TabStop = false;
            this.PicBoxOrange.Click += new System.EventHandler(this.PicBoxOrange_Click);
            // 
            // PicBoxGreen
            // 
            this.PicBoxGreen.BackColor = System.Drawing.Color.Lime;
            this.PicBoxGreen.Location = new System.Drawing.Point(138, 3);
            this.PicBoxGreen.Name = "PicBoxGreen";
            this.PicBoxGreen.Size = new System.Drawing.Size(28, 26);
            this.PicBoxGreen.TabIndex = 10;
            this.PicBoxGreen.TabStop = false;
            this.PicBoxGreen.Click += new System.EventHandler(this.PicBoxGreen_Click);
            // 
            // PicBoxBlack
            // 
            this.PicBoxBlack.BackColor = System.Drawing.Color.Black;
            this.PicBoxBlack.Location = new System.Drawing.Point(342, 3);
            this.PicBoxBlack.Name = "PicBoxBlack";
            this.PicBoxBlack.Size = new System.Drawing.Size(28, 26);
            this.PicBoxBlack.TabIndex = 13;
            this.PicBoxBlack.TabStop = false;
            this.PicBoxBlack.Click += new System.EventHandler(this.PicBoxBlack_Click);
            // 
            // PicBoxPurple
            // 
            this.PicBoxPurple.BackColor = System.Drawing.Color.Fuchsia;
            this.PicBoxPurple.Location = new System.Drawing.Point(240, 3);
            this.PicBoxPurple.Name = "PicBoxPurple";
            this.PicBoxPurple.Size = new System.Drawing.Size(28, 26);
            this.PicBoxPurple.TabIndex = 11;
            this.PicBoxPurple.TabStop = false;
            this.PicBoxPurple.Click += new System.EventHandler(this.PicBoxPurple_Click);
            // 
            // PicBoxBlue
            // 
            this.PicBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.PicBoxBlue.Location = new System.Drawing.Point(206, 3);
            this.PicBoxBlue.Name = "PicBoxBlue";
            this.PicBoxBlue.Size = new System.Drawing.Size(28, 26);
            this.PicBoxBlue.TabIndex = 12;
            this.PicBoxBlue.TabStop = false;
            this.PicBoxBlue.Click += new System.EventHandler(this.PicBoxBlue_Click);
            // 
            // PanelForTools
            // 
            this.PanelForTools.BackColor = System.Drawing.Color.LightCoral;
            this.PanelForTools.Controls.Add(this.PicBoxBrush);
            this.PanelForTools.Controls.Add(this.pictureBox1);
            this.PanelForTools.Controls.Add(this.ButClean);
            this.PanelForTools.Controls.Add(this.PanelForColors);
            this.PanelForTools.Controls.Add(this.TrackBarSizePen);
            this.PanelForTools.Controls.Add(this.PanelForCheck);
            this.PanelForTools.Location = new System.Drawing.Point(23, 437);
            this.PanelForTools.Name = "PanelForTools";
            this.PanelForTools.Size = new System.Drawing.Size(688, 123);
            this.PanelForTools.TabIndex = 9;
            // 
            // PicBoxBrush
            // 
            this.PicBoxBrush.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxBrush.Image")));
            this.PicBoxBrush.Location = new System.Drawing.Point(97, 32);
            this.PicBoxBrush.Name = "PicBoxBrush";
            this.PicBoxBrush.Size = new System.Drawing.Size(66, 63);
            this.PicBoxBrush.TabIndex = 11;
            this.PicBoxBrush.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 53);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMessage.Location = new System.Drawing.Point(738, 534);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(400, 26);
            this.TextBoxMessage.TabIndex = 11;
            // 
            // ButSend
            // 
            this.ButSend.BackColor = System.Drawing.Color.SeaShell;
            this.ButSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButSend.Image = ((System.Drawing.Image)(resources.GetObject("ButSend.Image")));
            this.ButSend.Location = new System.Drawing.Point(1144, 525);
            this.ButSend.Name = "ButSend";
            this.ButSend.Size = new System.Drawing.Size(47, 35);
            this.ButSend.TabIndex = 12;
            this.ButSend.UseVisualStyleBackColor = false;
            this.ButSend.Click += new System.EventHandler(this.ButSend_Click);
            // 
            // TimerCheckMessage
            // 
            this.TimerCheckMessage.Tick += new System.EventHandler(this.TimerCheckMessage_Tick);
            // 
            // TimerCheckNewDots
            // 
            this.TimerCheckNewDots.Tick += new System.EventHandler(this.TimerCheckNewDots_Tick);
            // 
            // ListViewChat
            // 
            this.ListViewChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnForIcon,
            this.ColumnForMessageText});
            this.ListViewChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListViewChat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListViewChat.HideSelection = false;
            this.ListViewChat.LargeImageList = this.imageList;
            this.ListViewChat.Location = new System.Drawing.Point(738, 47);
            this.ListViewChat.Name = "ListViewChat";
            this.ListViewChat.Size = new System.Drawing.Size(454, 472);
            this.ListViewChat.SmallImageList = this.imageList;
            this.ListViewChat.TabIndex = 13;
            this.ListViewChat.UseCompatibleStateImageBehavior = false;
            this.ListViewChat.View = System.Windows.Forms.View.Details;
            this.ListViewChat.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewChat_ItemSelectionChanged);
            // 
            // ColumnForIcon
            // 
            this.ColumnForIcon.Text = "";
            this.ColumnForIcon.Width = 20;
            // 
            // ColumnForMessageText
            // 
            this.ColumnForMessageText.Text = "";
            this.ColumnForMessageText.Width = 300;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "gray_like.png");
            this.imageList.Images.SetKeyName(1, "green_like.png");
            this.imageList.Images.SetKeyName(2, "entry_door.png");
            this.imageList.Images.SetKeyName(3, "exit_door.png");
            this.imageList.Images.SetKeyName(4, "hand_drawn32.png");
            this.imageList.Images.SetKeyName(5, "prize32.png");
            this.imageList.Images.SetKeyName(6, "fail.png");
            // 
            // LabTime
            // 
            this.LabTime.AutoSize = true;
            this.LabTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabTime.Location = new System.Drawing.Point(644, 9);
            this.LabTime.Name = "LabTime";
            this.LabTime.Size = new System.Drawing.Size(36, 20);
            this.LabTime.TabIndex = 15;
            this.LabTime.Text = "300";
            // 
            // LabSec
            // 
            this.LabSec.AutoSize = true;
            this.LabSec.Location = new System.Drawing.Point(686, 11);
            this.LabSec.Name = "LabSec";
            this.LabSec.Size = new System.Drawing.Size(19, 17);
            this.LabSec.TabIndex = 16;
            this.LabSec.Text = "s.";
            // 
            // LabUser
            // 
            this.LabUser.AutoSize = true;
            this.LabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabUser.Location = new System.Drawing.Point(68, 11);
            this.LabUser.Name = "LabUser";
            this.LabUser.Size = new System.Drawing.Size(0, 20);
            this.LabUser.TabIndex = 18;
            // 
            // TimerGameTime
            // 
            this.TimerGameTime.Tick += new System.EventHandler(this.TimerGameTime_Tick);
            // 
            // PictureBoxTimer
            // 
            this.PictureBoxTimer.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxTimer.Image")));
            this.PictureBoxTimer.Location = new System.Drawing.Point(596, 3);
            this.PictureBoxTimer.Name = "PictureBoxTimer";
            this.PictureBoxTimer.Size = new System.Drawing.Size(42, 40);
            this.PictureBoxTimer.TabIndex = 19;
            this.PictureBoxTimer.TabStop = false;
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxUser.Image")));
            this.PictureBoxUser.Location = new System.Drawing.Point(23, 3);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(39, 38);
            this.PictureBoxUser.TabIndex = 20;
            this.PictureBoxUser.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelNumUsers,
            this.toolStripStatusLabelNotification,
            this.toolStripStatusNotification});
            this.statusStrip1.Location = new System.Drawing.Point(3, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 26);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabelNumUsers
            // 
            this.toolStripStatusLabelNumUsers.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelNumUsers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelNumUsers.Image")));
            this.toolStripStatusLabelNumUsers.Name = "toolStripStatusLabelNumUsers";
            this.toolStripStatusLabelNumUsers.Size = new System.Drawing.Size(72, 20);
            this.toolStripStatusLabelNumUsers.Text = "LIVE: 0";
            // 
            // toolStripStatusLabelNotification
            // 
            this.toolStripStatusLabelNotification.Name = "toolStripStatusLabelNotification";
            this.toolStripStatusLabelNotification.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusNotification
            // 
            this.toolStripStatusNotification.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusNotification.Image")));
            this.toolStripStatusNotification.Name = "toolStripStatusNotification";
            this.toolStripStatusNotification.Size = new System.Drawing.Size(20, 20);
            this.toolStripStatusNotification.Visible = false;
            // 
            // LabelGameWord
            // 
            this.LabelGameWord.AutoSize = true;
            this.LabelGameWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGameWord.Location = new System.Drawing.Point(738, 13);
            this.LabelGameWord.Name = "LabelGameWord";
            this.LabelGameWord.Size = new System.Drawing.Size(0, 20);
            this.LabelGameWord.TabIndex = 22;
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1203, 604);
            this.Controls.Add(this.LabelGameWord);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PictureBoxUser);
            this.Controls.Add(this.PictureBoxTimer);
            this.Controls.Add(this.LabUser);
            this.Controls.Add(this.LabSec);
            this.Controls.Add(this.LabTime);
            this.Controls.Add(this.ListViewChat);
            this.Controls.Add(this.ButSend);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.PanelForTools);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PanelForDrawing);
            this.Controls.Add(this.LabWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FGame";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FGame_FormClosing);
            this.Shown += new System.EventHandler(this.FGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSizePen)).EndInit();
            this.PanelForColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBlue)).EndInit();
            this.PanelForTools.ResumeLayout(false);
            this.PanelForTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelForDrawing;
        private System.Windows.Forms.Button ButClean;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar TrackBarSizePen;
        private System.Windows.Forms.Panel PanelForCheck;
        private System.Windows.Forms.Label LabWidth;
        private System.Windows.Forms.Panel PanelForColors;
        private System.Windows.Forms.PictureBox PictureBoxRed;
        private System.Windows.Forms.PictureBox PicBoxSilver;
        private System.Windows.Forms.PictureBox PicBoxYellow;
        private System.Windows.Forms.PictureBox PicBoxOrange;
        private System.Windows.Forms.PictureBox PicBoxGreen;
        private System.Windows.Forms.PictureBox PicBoxBlack;
        private System.Windows.Forms.PictureBox PicBoxPurple;
        private System.Windows.Forms.PictureBox PicBoxBlue;
        private System.Windows.Forms.Panel PanelForTools;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button ButSend;
        private System.Windows.Forms.PictureBox PicBoxAqua;
        private System.Windows.Forms.PictureBox PicBoxBrown;
        private System.Windows.Forms.PictureBox PicBoxWhite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicBoxBrush;
        private System.Windows.Forms.Timer TimerCheckMessage;
        private System.Windows.Forms.Timer TimerCheckNewDots;
        private System.Windows.Forms.ListView ListViewChat;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader ColumnForIcon;
        private System.Windows.Forms.ColumnHeader ColumnForMessageText;
        private System.Windows.Forms.Label LabTime;
        private System.Windows.Forms.Label LabSec;
        private System.Windows.Forms.Label LabUser;
        private System.Windows.Forms.Timer TimerGameTime;
        private System.Windows.Forms.PictureBox PictureBoxTimer;
        private System.Windows.Forms.PictureBox PictureBoxUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumUsers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNotification;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNotification;
        private System.Windows.Forms.Label LabelGameWord;
    }
}