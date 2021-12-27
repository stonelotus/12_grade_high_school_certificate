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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void despreB_Click(object sender, EventArgs e)
        {
            despreForm despreForm = new despreForm();
            despreForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void memoryGame_Click_1(object sender, EventArgs e)
        {
            memoryGameForm memoryGameForm = new memoryGameForm();
            memoryGameForm.Show();
            this.Hide();
        }

        private void conwoy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var conwayForm = new conwayForm();

            conwayForm.Show();
        }

        private void tictactoeB_Click_1(object sender, EventArgs e)
        {
            tictactoeForm tictactoeForm = new tictactoeForm();
            tictactoeForm.Show();
            this.Hide();
        }

        private void musicB_Click(object sender, EventArgs e)
        {
            mediaPlayerForm mediaPlayerForm = new mediaPlayerForm();
            mediaPlayerForm.Show();
        }

        private void despreB_Click_1(object sender, EventArgs e)
        {
            despreForm despreForm = new despreForm();
            despreForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Matching_game");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Tic-tac-toe");
        }
    }
}
