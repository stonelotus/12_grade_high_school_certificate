using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATESTAT
{
    public partial class memoryGameForm : Form
    {
        public int nr,fails;
        public Dictionary<string,bool> labelDone = new Dictionary<string, bool> ();
        public char[] charactersUsed = new char[16];
        public char[] MyRandomArray = new char[16];
        public int hour = -3;
        public string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
        public bool playing = false;
        Label firstClicked, secondClicked;

        System.Windows.Forms.Timer aTimer;
        System.Windows.Forms.Timer playTimer;
        public memoryGameForm()
        {
            InitializeComponent();
            stopB.Enabled = false;
        }

        public void resetGame()
        {
            labelDone.Clear();
            nr = 0;
            fails = 0;
        }

        private void playB_Click_1(object sender, EventArgs e)
        {
            resetGame();
            stopB.Enabled = true;
            playB.Enabled = false;
            playing = true;
            playB.Text = "Replay";
            hour = -5;
            Random random = new Random();
            char character;
            int index;
            for (int i = 0; i < 8; i++)
            {
                index = random.Next(chars.Length);
                labelDone.Add("label" + (i + 1).ToString(),false);
                charactersUsed[i] = chars[index];
            }
            for(int i=8;i<16;i++)
            {
                charactersUsed[i] = charactersUsed[i - 8];
                labelDone.Add("label" + (i + 1).ToString(), false);
            }

            charactersUsed=shuffle(charactersUsed);
            initIcons(true);


            // timere joc
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Interval = 1000;
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Enabled = true;

            playTimer = new System.Windows.Forms.Timer();
            playTimer.Interval = 500;
            playTimer.Tick += new EventHandler(playTimer_Tick);
            playTimer.Enabled = true;





        }
        // functia ce initializeaza iconitele la apasarea butonului play si dupa secundele de vizionare
        public void initIcons(bool first) 
        {

            if (first == true)
            {
                for (int i = 0; i <= 15; i++)
                {
                    Label label;

                    if (tableLayoutPanel1.Controls[i] is Label)
                        label = (Label)tableLayoutPanel1.Controls[i];
                    else continue;

                    label.Text = charactersUsed[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i <= 15; i++)
                {
                    Label label;

                    if (tableLayoutPanel1.Controls[i] is Label)
                        label = (Label)tableLayoutPanel1.Controls[i];
                    else continue;

                    label.ForeColor = Color.SkyBlue;
                }
            }
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            hour++;
            time.Text = hour.ToString();
            if(hour == 0) initIcons(false);

        }
        private void playTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }

        private void memoryGameForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (playing == false) return;
            if (firstClicked != null && secondClicked != null)
               return;
            

            Label clickedLabel = sender as Label;
            clickedLabel.ForeColor = Color.Black;
            if (clickedLabel == null || labelDone[clickedLabel.Name.ToString()] == true)
                return;

            

            if(firstClicked == null)
            {
                firstClicked = clickedLabel;
                labelDone[clickedLabel.Name.ToString()] = true;
                return;
            }
            secondClicked = clickedLabel;
            labelDone[clickedLabel.Name.ToString()] = true;
            if (firstClicked.Text == secondClicked.Text)
            {
                nr++;
                if (nr == 8) gameOver();
            }
            else
            {
                firstClicked.ForeColor = Color.SkyBlue;
                secondClicked.ForeColor = Color.SkyBlue;
                labelDone[firstClicked.Name.ToString()] = false;
                labelDone[secondClicked.Name.ToString()] = false;
                fails++;
            }
            firstClicked = secondClicked = null;
        }

        private void stopB_Click(object sender, EventArgs e)
        {

            aTimer.Stop();
            aTimer.Dispose();
            playTimer.Stop();
            playTimer.Dispose();
            resetGame();
            stopB.Enabled = false;
            playB.Enabled = true;
            playing = false;
        }

        public void gameOver()
        {
            MessageBox.Show("Felicitari!!");
            aTimer.Stop();
            aTimer.Enabled = false;
            playTimer.Stop();
            playTimer.Enabled = false;
            //MessageBox.Show("Scor final")
        }
        public char[] shuffle(char[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                char k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }


    }
}
