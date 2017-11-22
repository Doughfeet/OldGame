using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int X { get; set; }
        public int Y { get; set; }


        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;


        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;

            this.TopMost = true;

            PlayerBall.Top = Canvas.Bottom - (Canvas.Bottom / 20);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EnemyBall.Left += speed_left;
            EnemyBall.Top += speed_top;


            if (EnemyBall.Left <= Canvas.Left && EnemyBall.BackColor != Canvas.BackColor)
            {
                speed_left = -speed_left;
            }
            if (EnemyBall.Right >= Canvas.Right)
            {
                speed_left = -speed_left;
            }
            if (EnemyBall.Top <= Canvas.Top)
            {
                speed_top = -speed_top;
            }
            if (EnemyBall.Top >= Canvas.Bottom)
            {
                speed_top = -speed_top;
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Brush brush = (Brush)Brushes.Blue;
            Graphics g = this.CreateGraphics();
            X = PlayerBall.Location.X;
            Y = PlayerBall.Location.Y;

            if (e.KeyCode == Keys.Right && PlayerBall.Right <= Canvas.Right )
            {
                X += 4;
            }
            else if (e.KeyCode == Keys.Left && PlayerBall.Left >= Canvas.Left)
            {
                X -= 4;
            }
            else if (e.KeyCode == Keys.Up && PlayerBall.Top >= Canvas.Top)
            {
                Y -= 4;
            }
            else if (e.KeyCode == Keys.Down && PlayerBall.Bottom <= Canvas.Bottom)
            {
                Y += 4;
            }

            PlayerBall.Location = new Point(X, Y);
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, X, Y, 1, 1);
        }
    }
}
