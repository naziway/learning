using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String text = "Смайлик";
        int p = 0;
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }
        private void Lopata(PaintEventArgs e, Graphics g, int x, int y)
        {
            g.Clear(Color.White);
            //inside lines
            g.DrawLine(new Pen(Brushes.Black, 2), x + 10, y + 30, x + 10, y + 120);
            g.DrawLine(new Pen(Brushes.Black, 2), x + 40, y + 30, x + 40, y + 120);

            //outside lines
            g.DrawLine(new Pen(Brushes.Black, 2), x - 10, y + 5, x - 10, y + 80);
            g.DrawLine(new Pen(Brushes.Black, 2), x + 60, y + 5, x + 60, y + 80);

            //goriszontal line
            g.DrawLine(new Pen(Brushes.Black, 2), x - 10, y + 80, x + 60, y + 80);

            //inside Arc
            g.DrawArc(new Pen(Brushes.Black, 2), x + 9, y + 20, 31, 30, 180, 180);

            //outside Arc
            g.DrawArc(new Pen(Brushes.Black, 2), x - 11, y -15, 71, 40, 180, 180);

        }
        private void LopataMove(Graphics g, int x, int y)
        {
            g.Clear(Color.White);
            //inside lines
            g.DrawLine(new Pen(Brushes.Black, 2), x + 10, y + 30, x + 10, y + 120);
            g.DrawLine(new Pen(Brushes.Black, 2), x + 40, y + 30, x + 40, y + 120);

            //outside lines
            g.DrawLine(new Pen(Brushes.Black, 2), x - 10, y + 5, x - 10, y + 80);
            g.DrawLine(new Pen(Brushes.Black, 2), x + 60, y + 5, x + 60, y + 80);

            //goriszontal line
            g.DrawLine(new Pen(Brushes.Black, 2), x - 10, y + 80, x + 60, y + 80);

            //inside Arc
            g.DrawArc(new Pen(Brushes.Black, 2), x + 9, y + 20, 31, 30, 180, 180);

            //outside Arc
            g.DrawArc(new Pen(Brushes.Black, 2), x - 11, y - 15, 71, 40, 180, 180);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Lopata(e, g, x, y);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            x = 250; y = 280;
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.Clear(Color.White);
            if (e.KeyChar == 'w')
            {
                this.LopataMove(g, x, y);
                y = y - 5;
            }
            else if (e.KeyChar == 's')
            {
                this.LopataMove(g, x, y);
                y = y + 5;
            }
            else if (e.KeyChar == 'd')
            {
                this.LopataMove(g, x, y);
                x = x + 5;
            }
            else if (e.KeyChar == 'a')
            {
                this.LopataMove(g, x, y);
                x = x - 5;
            }
        }

    }
}

