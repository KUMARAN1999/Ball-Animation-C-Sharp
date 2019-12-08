using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _16CS125_Ball
{
    public partial class Form1 : Form
    {
        Color color = Color.White;
        Graphics g;
        Ball[] ball = new Ball[50];
        int size = 20, count = 0, vx = 3, vy = 3;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Blue);
            for (int i = 0; i < count; i++)
            {
                ball[i].Draw(g, new SolidBrush(color));
                ball[i].MoveBall(ClientSize.Width, ClientSize.Height);
                //Interaction.Beep();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ball[count] = new Ball(e.X - (size / 2), e.Y - (size / 2), vx, vy, size);
            count++;
        }
    }
}
