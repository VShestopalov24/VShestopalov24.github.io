using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = Double.Parse(textBoxA.Text);
            double B = Double.Parse(textBoxB.Text);
            double C = Double.Parse(textBoxC.Text);
            Calculator(A, B, C);
        }

        private void Calculator(double A, double B, double C)
        {
            double D = Math.Pow(B, 2) - 4 * A * C;
            if (D > 0)
            {
                double x1 = (B * (-1) + Math.Sqrt(D)) / (2 * A);
                double x2 = (B * (-1) - Math.Sqrt(D)) / (2 * A);
                labelRezult.Text = "Ответ: " + x1 + " и " + x2;
            }
            else if (D == 0)
            {
                double x = (B * (-1)) / (2 * A);
                labelRezult.Text = "Ответ: " + x;
            }
            else labelRezult.Text = "Ответ: Нет решения!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxA.Text = "1";
            textBoxB.Text = "0";
            textBoxC.Text = "0";
        }
    }
}
