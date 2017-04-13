namespace COSC270FinalProject1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.theText = new System.Windows.Forms.RichTextBox();
            this.textMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.go = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paperColors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inkColors = new System.Windows.Forms.ComboBox();
            this.fadePast = new System.Windows.Forms.CheckBox();
            this.disappear = new System.Windows.Forms.CheckBox();
            this.highBox = new System.Windows.Forms.CheckBox();
            this.cat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.read = new System.Windows.Forms.CheckBox();
            this.track = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.music = new System.Windows.Forms.Button();
            this.textMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.optionsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            this.SuspendLayout();
            // 
            // theText
            // 
            this.theText.ContextMenuStrip = this.textMenuStrip;
            this.theText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theText.Location = new System.Drawing.Point(0, 0);
            this.theText.Name = "theText";
            this.theText.Size = new System.Drawing.Size(275, 347);
            this.theText.TabIndex = 0;
            this.theText.Text = resources.GetString("theText.Text");
            // 
            // textMenuStrip
            // 
            this.textMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.textMenuStrip.Name = "optionsMenuStrip";
            this.textMenuStrip.Size = new System.Drawing.Size(209, 70);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem4.Text = "Clear";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem5.Text = "Load File";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem6.Text = "Search Project Gutenberg";
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.LimeGreen;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(343, 12);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 64);
            this.go.TabIndex = 1;
            this.go.Text = "Go!";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Red;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(424, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 64);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // paperColors
            // 
            this.paperColors.FormattingEnabled = true;
            this.paperColors.Items.AddRange(new object[] {
            "White",
            "Light Blue",
            "Parchment",
            "Light Green",
            "Black"});
            this.paperColors.Location = new System.Drawing.Point(343, 134);
            this.paperColors.Name = "paperColors";
            this.paperColors.Size = new System.Drawing.Size(71, 21);
            this.paperColors.TabIndex = 3;
            this.paperColors.SelectedIndexChanged += new System.EventHandler(this.paperColors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paper Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ink Color:";
            // 
            // inkColors
            // 
            this.inkColors.FormattingEnabled = true;
            this.inkColors.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Blue",
            "Green",
            "White"});
            this.inkColors.Location = new System.Drawing.Point(424, 134);
            this.inkColors.Name = "inkColors";
            this.inkColors.Size = new System.Drawing.Size(71, 21);
            this.inkColors.TabIndex = 6;
            // 
            // fadePast
            // 
            this.fadePast.AutoSize = true;
            this.fadePast.Location = new System.Drawing.Point(6, 46);
            this.fadePast.Name = "fadePast";
            this.fadePast.Size = new System.Drawing.Size(128, 17);
            this.fadePast.TabIndex = 7;
            this.fadePast.Text = "Fade Out Past Words";
            this.fadePast.UseVisualStyleBackColor = true;
            this.fadePast.CheckedChanged += new System.EventHandler(this.fadePast_CheckedChanged);
            // 
            // disappear
            // 
            this.disappear.AutoSize = true;
            this.disappear.Location = new System.Drawing.Point(6, 92);
            this.disappear.Name = "disappear";
            this.disappear.Size = new System.Drawing.Size(220, 17);
            this.disappear.TabIndex = 8;
            this.disappear.Text = "Words Disappear just AHEAD of speaker";
            this.disappear.UseVisualStyleBackColor = true;
            this.disappear.CheckedChanged += new System.EventHandler(this.disappear_CheckedChanged);
            // 
            // highBox
            // 
            this.highBox.AutoSize = true;
            this.highBox.Location = new System.Drawing.Point(6, 23);
            this.highBox.Name = "highBox";
            this.highBox.Size = new System.Drawing.Size(133, 17);
            this.highBox.TabIndex = 9;
            this.highBox.Text = "Highlight Current Word";
            this.highBox.UseVisualStyleBackColor = true;
            this.highBox.CheckedChanged += new System.EventHandler(this.highBox_CheckedChanged);
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(6, 69);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(146, 17);
            this.cat.TabIndex = 10;
            this.cat.Text = "Cat Looks at Current Line";
            this.cat.UseVisualStyleBackColor = true;
            this.cat.CheckedChanged += new System.EventHandler(this.cat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.optionsMenuStrip;
            this.groupBox1.Controls.Add(this.read);
            this.groupBox1.Controls.Add(this.track);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.highBox);
            this.groupBox1.Controls.Add(this.disappear);
            this.groupBox1.Controls.Add(this.cat);
            this.groupBox1.Controls.Add(this.fadePast);
            this.groupBox1.Location = new System.Drawing.Point(343, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 186);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options:";
            // 
            // optionsMenuStrip
            // 
            this.optionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.optionsMenuStrip.Name = "optionsMenuStrip";
            this.optionsMenuStrip.Size = new System.Drawing.Size(309, 70);
            this.optionsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.optionsMenuStrip_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(308, 22);
            this.toolStripMenuItem1.Text = "Clear All";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(308, 22);
            this.toolStripMenuItem2.Text = "Select Options for As Much Help As Possible";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(308, 22);
            this.toolStripMenuItem3.Text = "Select Options for Max Points!";
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.read.Location = new System.Drawing.Point(6, 151);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(74, 17);
            this.read.TabIndex = 28;
            this.read.Text = "Just Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.CheckedChanged += new System.EventHandler(this.read_CheckedChanged);
            // 
            // track
            // 
            this.track.AutoSize = true;
            this.track.Checked = true;
            this.track.CheckState = System.Windows.Forms.CheckState.Checked;
            this.track.Location = new System.Drawing.Point(6, 128);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(54, 17);
            this.track.TabIndex = 27;
            this.track.Text = "Track";
            this.track.UseVisualStyleBackColor = true;
            this.track.CheckedChanged += new System.EventHandler(this.track_CheckedChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(166, 148);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(55, 23);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "four.png");
            this.imageList1.Images.SetKeyName(1, "cat.png");
            this.imageList1.Images.SetKeyName(2, "dog.png");
            this.imageList1.Images.SetKeyName(3, "cold.png");
            this.imageList1.Images.SetKeyName(4, "dance.png");
            this.imageList1.Images.SetKeyName(5, "castle.png");
            this.imageList1.Images.SetKeyName(6, "can.png");
            this.imageList1.Images.SetKeyName(7, "bark.png");
            this.imageList1.Images.SetKeyName(8, "antelope.png");
            this.imageList1.Images.SetKeyName(9, "antelopelarge.png");
            this.imageList1.Images.SetKeyName(10, "apple.png");
            this.imageList1.Images.SetKeyName(11, "applelarge.png");
            this.imageList1.Images.SetKeyName(12, "one.png");
            this.imageList1.Images.SetKeyName(13, "two.png");
            this.imageList1.Images.SetKeyName(14, "three.png");
            this.imageList1.Images.SetKeyName(15, "five.png");
            this.imageList1.Images.SetKeyName(16, "six.png");
            this.imageList1.Images.SetKeyName(17, "sixlarge.png");
            this.imageList1.Images.SetKeyName(18, "red.png");
            this.imageList1.Images.SetKeyName(19, "yellow.png");
            this.imageList1.Images.SetKeyName(20, "blue.png");
            this.imageList1.Images.SetKeyName(21, "prince.png");
            this.imageList1.Images.SetKeyName(22, "princess.png");
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.PeachPuff;
            this.pause.Location = new System.Drawing.Point(424, 83);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 16;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.MediumAquamarine;
            this.resume.Location = new System.Drawing.Point(343, 82);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(75, 23);
            this.resume.TabIndex = 17;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(98, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(184, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.txt)|*.txt|All files (*.*)|*.*;";
            this.openFileDialog1.InitialDirectory = "E:\\COSC270FinalProject1.0\\COSC270FinalProject1.0\\bin\\Debug\\Stories";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(593, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(100, 361);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Your Badges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Your badges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Your Score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreLabel.Location = new System.Drawing.Point(596, 28);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(83, 18);
            this.scoreLabel.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(253, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(604, 410);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 29;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(604, 381);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer2.TabIndex = 30;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(604, 353);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer3.TabIndex = 32;
            this.axWindowsMediaPlayer3.Visible = false;
            // 
            // music
            // 
            this.music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("music.BackgroundImage")));
            this.music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.music.Location = new System.Drawing.Point(459, 400);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(110, 40);
            this.music.TabIndex = 30;
            this.music.UseVisualStyleBackColor = true;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 452);
            this.Controls.Add(this.music);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inkColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paperColors);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.go);
            this.Controls.Add(this.theText);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Word Detective";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.textMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.optionsMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox theText;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox paperColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inkColors;
        private System.Windows.Forms.CheckBox fadePast;
        private System.Windows.Forms.CheckBox disappear;
        private System.Windows.Forms.CheckBox highBox;
        private System.Windows.Forms.CheckBox cat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip optionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip textMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.CheckBox read;
        private System.Windows.Forms.CheckBox track;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.Button music;
    }
}

