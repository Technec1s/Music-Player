namespace Music_Player
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.Label();
            this.Music = new System.Windows.Forms.ListBox();
            this.ChooseMusic = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.Logo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 47);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 47);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(746, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(68, 8);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(59, 20);
            this.Logo.TabIndex = 1;
            this.Logo.Text = "Spotify";
            // 
            // Music
            // 
            this.Music.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Music.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.FormattingEnabled = true;
            this.Music.ItemHeight = 15;
            this.Music.Location = new System.Drawing.Point(626, 134);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(162, 289);
            this.Music.TabIndex = 1;
            this.Music.SelectedIndexChanged += new System.EventHandler(this.Music_SelectedIndexChanged);
            // 
            // ChooseMusic
            // 
            this.ChooseMusic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChooseMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseMusic.Location = new System.Drawing.Point(626, 68);
            this.ChooseMusic.Name = "ChooseMusic";
            this.ChooseMusic.Size = new System.Drawing.Size(162, 45);
            this.ChooseMusic.TabIndex = 2;
            this.ChooseMusic.Text = "Select Music";
            this.ChooseMusic.UseVisualStyleBackColor = false;
            this.ChooseMusic.Click += new System.EventHandler(this.ChooseMusic_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(12, 68);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(597, 473);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.Info;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_next.Location = new System.Drawing.Point(35, 400);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(103, 38);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Info;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_play.Location = new System.Drawing.Point(159, 400);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(103, 38);
            this.btn_play.TabIndex = 5;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.SystemColors.Info;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_pause.Location = new System.Drawing.Point(284, 400);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(103, 38);
            this.btn_pause.TabIndex = 6;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.Info;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_stop.Location = new System.Drawing.Point(405, 400);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(103, 38);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(540, 82);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(45, 313);
            this.track_volume.TabIndex = 8;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(537, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Volume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.ChooseMusic);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music PLayer App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.ListBox Music;
        private System.Windows.Forms.Button ChooseMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
    }
}

