using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        //int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush s = new SolidBrush(Color.Red);
            g.DrawString(richTextBox2.Text, new Font(new FontFamily("Arial"), 13), s, new PointF(50, 100));
            richTextBox2.Text = string.Empty;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.DarkGray, 2f);
            // SolidBrush s = new SolidBrush(Color.Red);
            // g.DrawRectangle(p, 50, 50, 500, 400);
            e.Graphics.DrawRectangle(p, 30, 90, 100, 200);
            e.Graphics.DrawRectangle(p, 130, 90, 30, 200);
            e.Graphics.DrawRectangle(p, 160, 90, 100, 200);
            
            p.Dispose();
        }
    }
}
