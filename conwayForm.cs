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
    public partial class conwayForm : Form
    {
        bool[,] plan;
        int size = 10;

        bool isDrawing = false;
        bool drawColor;



        public conwayForm()
        {
            InitializeComponent();
            planRedo();
        }

        private void conwayForm_Load(object sender, EventArgs e)
        {

        }

        private void planRedo()
        {
            plan = new bool[50, 50];
            plan[23, 12] = true;
            plan[24, 14] = true;
            plan[23, 14] = true;
            guiField.Size = new Size(plan.GetLength(0) * size, plan.GetLength(1) * size);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Brush alive = Brushes.White;
            Brush dead = Brushes.Black;


            for(int x=0;x<plan.GetLength(0);x++)
            {
                for(int y=0; y<plan.GetLength(1);y++)
                {
                    Brush b;
                    if (plan[x, y])
                        b = alive;
                    else
                        b = dead;
                    g.FillRectangle(b, x * size, y * size, size, size);
                }
            }
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Step();
        }

        private void Step()
        {
            plan = nextGen(plan);
            guiField.Invalidate();
        }

        private bool[,] nextGen(bool [,] plan)
        {
            bool[,] planNou = new bool[plan.GetLength(0), plan.GetLength(1)];

            for (int x = 0; x < plan.GetLength(0); x++) {
                for (int y = 0; y < plan.GetLength(1); y++)
                {
                    int vecini = getVecini(plan, x, y);
                    if(plan[x,y])
                    {
                        planNou[x, y] = (vecini >= 2 && vecini <= 3);
                    }
                    else
                    {
                        planNou[x, y] = vecini == 3;
                    }
                }
            }
            return planNou;

        }

        private int getVecini(bool[,] plan,int x,int y)
        {
            int vecini = 0;
            int maxX = plan.GetLength(0);
            int maxY = plan.GetLength(1);

            for(int dx=-1;dx<=1;dx++)
            {
                for(int dy=-1;dy<=1;dy++)
                {
                    int cx = x + dx;
                    int cy = y + dy;
                    if(cx==x && cy==y)
                        continue;
                    if (cx < 0 || cx >= maxX)
                        continue;
                    if (cy < 0 || cy >= maxY)
                        continue;
                    if (plan[cx, cy])
                        vecini++;
                }
            }
            return vecini;   
        }

        private void guiField_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / size;
            int y = e.Y / size;
            isDrawing = true;
            if (x < 0 || x >= plan.GetLength(0))
                return;
            if (y < 0 || y >= plan.GetLength(1))
                return;
            drawColor = !plan[x, y];
            
            guiField.Invalidate();
        }

        private void guiField_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
                return;

            int x = e.X / size;
            int y = e.Y / size;
            if (x < 0 || x >= plan.GetLength(0))
                return;
            if (y < 0 || y >= plan.GetLength(1))
                return;

            plan[x, y] = drawColor;

            guiField.Invalidate();
        }

        private void guiField_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.Text == "Play")
            {
                timer1.Start();
                playButton.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                playButton.Text = "Play";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Step();
        }

        private void trabkBar_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = speedBar.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
