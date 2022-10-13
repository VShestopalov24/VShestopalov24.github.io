using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x, y;
        
        private Pen pen = new Pen(Color.Blue, 4);

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, 3 * x + 50, y + 50, 50, 50);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 1;
            y = (int)(25 * Math.Sin(180 * x / Math.PI));
            Invalidate();
        }
    }
}
