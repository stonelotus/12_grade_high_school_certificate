namespace ATESTAT
{
    partial class mediaPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaPlayerForm));
            this.volum = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.listSongs = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addB = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.volum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // volum
            // 
            this.volum.Location = new System.Drawing.Point(63, 46);
            this.volum.Maximum = 100;
            this.volum.Name = "volum";
            this.volum.Size = new System.Drawing.Size(182, 45);
            this.volum.TabIndex = 2;
            this.volum.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Track -> ";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(55, 98);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(10, 13);
            this.songLabel.TabIndex = 4;
            this.songLabel.Text = "-";
            // 
            // listSongs
            // 
            this.listSongs.Location = new System.Drawing.Point(5, 121);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(243, 362);
            this.listSongs.TabIndex = 5;
            this.listSongs.UseCompatibleStateImageBehavior = false;
            this.listSongs.View = System.Windows.Forms.View.List;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.Black;
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.ForeColor = System.Drawing.Color.White;
            this.addB.Location = new System.Drawing.Point(9, 493);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(236, 39);
            this.addB.TabIndex = 6;
            this.addB.Text = "Adauga melodie";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = global::ATESTAT.Properties.Resources.circled_play_48px;
            this.play.Location = new System.Drawing.Point(5, 45);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(48, 46);
            this.play.TabIndex = 1;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(61, 205);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(21, 24);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATESTAT.Properties.Resources.exit2;
            this.pictureBox1.Location = new System.Drawing.Point(223, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATESTAT.Properties.Resources.minim1;
            this.pictureBox2.Location = new System.Drawing.Point(188, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // titleP
            // 
            this.titleP.AutoSize = true;
            this.titleP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.titleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleP.ForeColor = System.Drawing.Color.Black;
            this.titleP.Location = new System.Drawing.Point(12, 0);
            this.titleP.Name = "titleP";
            this.titleP.Size = new System.Drawing.Size(119, 20);
            this.titleP.TabIndex = 4;
            this.titleP.Text = "Player muzica";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleP);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 25);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mediaPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ATESTAT.Properties.Resources.videoblocks_dark_energy_looped_background_r0dm_6dqe_thumbnail_full01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(253, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volum);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(253, 544);
            this.Name = "mediaPlayerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Muzica ";
            this.Load += new System.EventHandler(this.mediaPlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.TrackBar volum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.ListView listSongs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}