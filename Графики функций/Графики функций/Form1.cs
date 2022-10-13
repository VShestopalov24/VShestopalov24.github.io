using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графики_функций
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Считываем с формы требуемые значения
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text);

            //Количество точек графика
            double X = (Xmax - Xmin) / Step;
            int count = (int)Math.Ceiling(X) + 1;

            //Массив значений х - общий для всех графиков
            double[] x = new double[count];

            //Массивы у - по одному для каждого графика
            double[] y1 = new double[count]; 
            double[] y2 = new double[count];

            //Расчитываем точки для графиков функции
            for(int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                //Вычисляем значение функции в точке Х
                y1[i] = Math.Sin(x[i]);
                y2[i] = Math.Cos(x[i]);
            }

            //Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin; 
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            //Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            //Добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(x, y1); 
            chart1.Series[1].Points.DataBindXY(x, y2);
        }
    }
}
