using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Метеостанция
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        // Метод закрытия программы
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Метод кнопки "Открыть файл"
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                short[] array;
                {
                    Encoding enc = Encoding.GetEncoding(1251);//Задаем кодировку файла
                    StreamReader fileread = new StreamReader(openFileDialog1.FileName, enc);
                    labelMonth.Text = fileread.ReadLine();
                    short[] TempArray = new short[31]; // объявляем массив для чтения данных из файла
                    byte count = 0; // объявляем счетчик считанных данных
                    while (!fileread.EndOfStream) // проверяем, что файл не кончился
                        TempArray[count++] = short.Parse(fileread.ReadLine()); // считываем числа в массив
                    fileread.Close();

                    array = new short[count]; // массив с количеством элементов, считанным из файлов
                    for (byte i = 0; i < count; i++) // передаем значения из временного массива
                        array[i] = TempArray[i];
                }
                labelKolDay.Text = array.Length.ToString();
                
                labelSred.Text = middleArray(array).ToString();
                maxTemperature(array);
                minTemperature(array);
                coldDay(array);
                
            }
        }

        // Средняя температура
        private double middleArray(short[] A)
        {
            int summa = 0;
            for (byte i = 0; i < A.Length; i++)
                summa += A[i];
            double middle = (double)summa / A.Length;
            middle *= 10;
            middle = Math.Round(middle);
            middle /= 10;
            return middle;
        }

        // Максимальная температура
        private void maxTemperature(short[] A)
        {
            short max = A[0];
            byte maxdate = 0;
            for (byte i = 0; i < A.Length; i++)
                if (A[i] > max)
                {
                    max = A[i];
                    maxdate = i;
                }
            labelMax.Text = max.ToString();
            labelMaxDay.Text = (++maxdate).ToString();
        }

        // Минимальная температура
        private void minTemperature(short[] A)
        {
            short min = A[0];
            byte mindate = 0;
            for (byte i = 0; i < A.Length; i++)
                if (A[i] < min)
                {
                    min = A[i];
                    mindate = i;
                }
            labelMin.Text = min.ToString();
            labelMinDay.Text = (++mindate).ToString();
        }

        // Кол-во холодных дней
        private void coldDay(short[] A)
        {
            byte countCold = 0;
            for (byte i = 0; i < A.Length; i++)
                if (A[i] <= -25) countCold++;
            labelCold.Text = countCold.ToString();
        }

        // Кол-во жарких дней
        private void hotDay(short[] A)
        {
            byte countHot = 0;
            for (byte i = 0; i < A.Length; i++)
                if (A[i] >= 25) countHot++;
            labelHotDay.Text = countHot.ToString();
        }
    }
}
