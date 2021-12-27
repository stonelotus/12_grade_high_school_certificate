using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ATESTAT
{
    public partial class mediaPlayerForm : Form
    {
        Boolean playing = false;
        int pausedId = -1;
        public struct meh
        {
            public string[] names;
            public string[] paths;
            
        };
        meh files;
        public mediaPlayerForm()
        {
            InitializeComponent();
        }

      
        private void mediaPlayerForm_Load(object sender, EventArgs e)
        {
            reset();
            volum.Value = 25;
            axWindowsMediaPlayer1.settings.volume = volum.Value;
            MessageBox.Show(Application.StartupPath + @"\music");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int id = listSongs.FocusedItem.Index;
            
            if (playing == false)
            {
                songLabel.Text = files.names[id];
                if(pausedId != id)
                { 
                    axWindowsMediaPlayer1.URL = files.paths[id];
                    pausedId = id;
                }
                play.Image = Properties.Resources.circled_pause_48px;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                playing = true;
            }

            else if(playing == true)
            {
                if (pausedId == id)
                {
                    
                    pausedId = id;
                    songLabel.Text = "PAUSED";
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    play.Image = Properties.Resources.circled_play_48px;
                    playing = false;
                }
                else
                {
                    pausedId = id;
                    axWindowsMediaPlayer1.URL = files.paths[id];
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                }
                
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            String[] filesNames,paths;
            string here = Application.StartupPath + @"\music";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int number = -1;
                filesNames = ofd.SafeFileNames;
                paths = ofd.FileNames;
                foreach(var path in paths)
                {
                    ++number;
                    here = here + @"\" + filesNames[number]; 
                    System.IO.File.Copy(path, here, true);
                }
                reset();
            }
            
        }
        public void reset()
        {
            listSongs.Items.Clear();

            string path = Application.StartupPath + @"\music";
            //   files.names = new string[1001];
            //  files.paths = new string[1001];
            files.names = Directory.GetFiles(path, "*.mp3");
            files.paths = Directory.GetFiles(path);
            //    MessageBox.Show(Application.StartupPath + "Resources/music");
            for (int i = 0; i < files.names.Length; i++)
            {
                files.names[i] = Path.GetFileName(files.names[i]);
                files.paths[i] = path + @"\" + files.names[i];
                //  MessageBox.Show(files.paths[i]);
            }

            foreach (var file in files.names)
            {
                listSongs.Items.Add(file);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volum.Value;
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
