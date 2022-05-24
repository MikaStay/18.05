using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; //важно!
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._05_ОП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        } 
        Graphics gr;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(100, 800);
            gr = CreateGraphics();
            //gr.DrawEllipse(Pens.Red, 150, 75, 75, 75);
            //gr.FillRectangle(Brushes.BlueViolet, 75, 150, 75, 75);
            //gr.FillRectangle(Brushes.Blue, rnd.Next(100, 800), rnd.Next(100, 800), 75, 75);
            
            //button1.Left = rnd.Next(0, 26);
            //button1.Top = rnd.Next(0, 80);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 60 == 0)
                i = 0;
            label1.Text = i.ToString();
            i++;
            gr = CreateGraphics();
            if (f) 
            gr.FillRectangle(Brushes.Black, MousePosition.X-Location.X-8, MousePosition.Y-Location.Y-31-35, 70, 70);
        }

        bool f = true;

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            f = true;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            f = false;
        }
    }
}
