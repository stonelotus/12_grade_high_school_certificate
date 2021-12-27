namespace ATESTAT
{
    partial class conwayForm
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
            this.guiField = new System.Windows.Forms.PictureBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guiField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guiField
            // 
            this.guiField.Location = new System.Drawing.Point(115, 55);
            this.guiField.Name = "guiField";
            this.guiField.Size = new System.Drawing.Size(627, 511);
            this.guiField.TabIndex = 1;
            this.guiField.TabStop = false;
            this.guiField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.guiField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guiField_MouseDown);
            this.guiField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guiField_MouseMove);
            this.guiField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guiField_MouseUp);
            // 
            // stepButton
            // 
            this.stepButton.BackColor = System.Drawing.Color.Thistle;
            this.stepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepButton.Location = new System.Drawing.Point(9, 106);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(100, 42);
            this.stepButton.TabIndex = 2;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = false;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Thistle;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(9, 154);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(12, 225);
            this.speedBar.Maximum = 3000;
            this.speedBar.Minimum = 10;
            this.speedBar.Name = "speedBar";
            this.speedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speedBar.Size = new System.Drawing.Size(45, 341);
            this.speedBar.TabIndex = 4;
            this.speedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedBar.Value = 1000;
            this.speedBar.ValueChanged += new System.EventHandler(this.trabkBar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleP);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 33);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // titleP
            // 
            this.titleP.AutoSize = true;
            this.titleP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.titleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleP.ForeColor = System.Drawing.Color.Black;
            this.titleP.Location = new System.Drawing.Point(211, 8);
            this.titleP.Name = "titleP";
            this.titleP.Size = new System.Drawing.Size(316, 24);
            this.titleP.TabIndex = 16;
            this.titleP.Text = "Conway\'s Game of Life - Evolutie";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATESTAT.Properties.Resources.minim1;
            this.pictureBox2.Location = new System.Drawing.Point(688, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATESTAT.Properties.Resources.exit2;
            this.pictureBox1.Location = new System.Drawing.Point(733, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ATESTAT.Properties.Resources.romania_48px;
            this.pictureBox3.Location = new System.Drawing.Point(12, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // conwayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATESTAT.Properties.Resources.spacebg;
            this.ClientSize = new System.Drawing.Size(771, 578);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.guiField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conwayForm";
            this.Text = "conwayForm";
            this.Load += new System.EventHandler(this.conwayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guiField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox guiField;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label titleP;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}