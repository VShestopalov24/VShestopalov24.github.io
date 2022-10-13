using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixDeterminant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Determinant();
        }

        private void Determinant()
        {
            int A11 = Int32.Parse(textBox1.Text);
            int A12 = Int32.Parse(textBox2.Text);
            int A13 = Int32.Parse(textBox3.Text);
            int A21 = Int32.Parse(textBox4.Text);
            int A22 = Int32.Parse(textBox5.Text);
            int A23 = Int32.Parse(textBox6.Text);
            int A31 = Int32.Parse(textBox7.Text);
            int A32 = Int32.Parse(textBox8.Text);
            int A33 = Int32.Parse(textBox9.Text);

            int det = A11 * A22 * A33 + A12 * A23 * A31 + A13 * A21 * A32 - A13 * A22 * A31 - A11 * A23 * A32 - A12 * A21 * A33;
            labelRezult.Text = "Результат: " + det;
        }
    }
}
