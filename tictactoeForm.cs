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
    public partial class tictactoeForm : Form
    {
        public int[,] playground = new int[3, 3];
        public int turn;
        public tictactoeForm()
        {
            InitializeComponent();
        }

        private void playB_Click(object sender, EventArgs e)
        {
            initLabels();
            turn = 1;
        }
        public void initLabels()
        {
           for(int i=0; i < 9; i++)
            {
                Label label;
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else continue;

                label.Text = "";
            }

           for(int i = 0; i<3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    playground[i,j] = 0;
                }
            }
            

        }
        public bool winCheck(int val)
        {
            
            if (playground[0, 0] == playground[1, 1] && playground[0, 0] == playground[2, 2] && playground[0, 0] == val)
                return true;
            if (playground[2, 0] == playground[1, 1] && playground[2,0] == playground[0, 2] && playground[2, 0] == val)
                return true;
            bool ok = true;
            for(int i = 0; i < 3; i++)
            {
                ok = true;
                for(int j = 0; j < 3; j++)
                {
                    if (playground[i, j] != val)
                    {
                        ok = false;
                    }
                }
                if (ok == true) return true;
            }
            for(int j = 0; j < 3; j++)
            {
                for(int i = 0; i < 3; i++)
                {
                    if(playground[i,j]!= val)
                    {
                        ok = false;
                    }
                }
                if (ok == true) return true;
            }


            return false;
        }
        
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel.Text != "") return; 

            int i = getPosition(clickedLabel.Name.ToString(),1);
            int j = getPosition(clickedLabel.Name.ToString(),2);
            if(turn == 1)
            {
                turn = 2;

                clickedLabel.Text = "X";
                playground[i, j] = 1;
                if (winCheck(1) == true) MessageBox.Show("Win X");
            }
            else
            {
                turn = 1;

                clickedLabel.Text = "O";
                playground[i, j] = 2;

                if (winCheck(2) == true) MessageBox.Show("Win O");
            }
            if (winCheck(1) == true) MessageBox.Show("Win X");
            else if (winCheck(2) == true) MessageBox.Show("Win O");
            
        }
        public int getPosition(string name,int test)
        {
            int row=0, column=0;
            int index = int.Parse(name[5].ToString());
            index--;
            
            if(index >=0 && index <=2)
            {
                row = 0;
                if (index == 0) column = 0;
                if (index == 1) column = 1;
                if (index == 2) column = 2;
            }
            if (index >= 3 && index <= 5)
            {
                row = 1;
                if (index == 3) column = 0;
                if (index == 4) column = 1;
                if (index == 5) column = 2;
            }
            if (index >= 6 && index <= 8)
            {
                row = 2;
                if (index == 6) column = 0;
                if (index == 7) column = 1;
                if (index == 8) column = 2;
            }
            if (test == 1) return row;
            return column; ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
