using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace zlap_mnie_app
{
    public partial class Form1 : Form
    {
        readonly Random r;
        private int Punkty;
        private int Highscore;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
            Punkty = 0;
            Highscore = 0;
            timer1.Start();
           
            
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            MoveButton();
            Punkty = 0;
            toolStripLabel1.Text = "Punkty: " + Punkty.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton();
            Punkty++;
            toolStripLabel1.Text = "Punkty: " + Punkty.ToString();
            timer1.Stop();
            timer1.Start();
            button1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            toolStripLabel2.Text = "Highscore: " + Punkty.ToString();
            timer1.Stop();
            timer1.Interval -= 50;
            timer1.Start();
        }

        private void MoveButton()
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
            button1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}