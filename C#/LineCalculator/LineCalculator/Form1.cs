using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCalculator
{
    public partial class Form1 : Form
    {
        // Объявляем поля класса Form1
        private static double Number1 = 0; // хранение первого числа введенного пользователем
        // private - уровень доступа (доступно только внутри класса Form1)
        // static - поле не будет автоматически обновляться (сохраняет введенное значение)
        private static byte Operation = 0; // номер математической операции
        // 0 - сложение
        // 1 - вычитание
        // 2 - умножение
        // 3 - деление
        // 4 - возведение в степень
        private static double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Методы цифровых кнопок
        #region NumericButtons
        //Кнопка 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "1";
            else textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "2";
            else textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "3";
            else textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "4";
            else textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "5";
            else textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "6";
            else textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "7";
            else textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "8";
            else textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "9";
            else textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "0";
        }
        #endregion

        #region MathOperations
        private void button11_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(textBox1.Text); 

            textBox1.Text = "0"; // обнуляем textBox

            Operation = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(textBox1.Text);

            textBox1.Text = "0"; // обнуляем textBox

            Operation = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(textBox1.Text);

            textBox1.Text = "0"; // обнуляем textBox

            Operation = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(textBox1.Text);

            textBox1.Text = "0"; // обнуляем textBox

            Operation = 3;
        }


        #endregion

        private void buttonRezult_Click(object sender, EventArgs e)
        {
            // Получаем второе число
            double Number2 = double.Parse(textBox1.Text);

            // Проверяем какая выбрана операция
            switch (Operation)
            {
                case 0: Number2 += Number1;break;
                case 1: Number2 = Number1 - Number2;break;
                case 2: Number2 = Number1 * Number2;break;
                case 3: Number2 = Number1 / Number2;break;
                case 4: Number2 = (double)Math.Pow(Number1, Number2); break;
            }
            textBox1.Text = Number2.ToString(); // выводим результат в textBox
        }

        #region MathFunctions
        // Кнопка Плюс Минус
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            Number *= -1;

            textBox1.Text = Number.ToString();
        }

        // Кнопка Х в квадрате
        private void buttonSqr_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            Number = (double)Math.Pow(Number, 2);

            textBox1.Text = Number.ToString();
        }

        // Кнопка Х в кубе
        private void buttonCube_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            Number = (double)Math.Pow(Number, 3);

            textBox1.Text = Number.ToString();
        }

        // Кнопка возведения в степень
        private void buttonDeg_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            Operation = 4;
        }

        // Кнопка факториала
        private void buttonF_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            double Rezult = 1;

            for(int i = 2; i <= Number; i++)
            {
                Rezult *= i;
            }
            textBox1.Text = Rezult.ToString();
        }

        // Кнопка Пи
        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        // Кнопка модуля числа
        private void buttonAbs_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Abs(Number).ToString();
        }

        // Кнопка 1/х
        private void button18_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            Number = 1 / Number;

            textBox1.Text = Number.ToString();
        }

        // Кнопка квадратного корня
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Sqrt(Number).ToString();
        }

        // Кнопка синуса
        private void buttonSin_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Sin(Number).ToString();
        }

        // Кнопка косинуса
        private void buttonCos_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Cos(Number).ToString();
        }

        // Кнопка тангентса
        private void buttonTg_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Tan(Number).ToString();
        }

        // Кнопка постоянной Е
        private void buttonE_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.E.ToString();
        }

        // Кнопка логарифма с основанием 10
        private void buttonLog_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Log10(Number).ToString();
        }

        // Кнопка натурального логарифма
        private void buttonLn_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Log(Number).ToString();
        }

        // Кнопка экспоненты
        private void buttonExp_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Exp(Number).ToString();
        }

        // Arcsin
        private void buttonArcsin_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Asin(Number).ToString();
        }

        // Arccos
        private void buttonArccos_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Acos(Number).ToString();
        }

        // Arctg
        private void buttonArctg_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(textBox1.Text);

            textBox1.Text = Math.Atan(Number).ToString();
        }
        #endregion

        #region MemoryAndBackspace
        // Кнопка памяти
        private void buttonM_Click(object sender, EventArgs e)
        {
            // Получаем число из textBox и сохраняем в поле Memory
            double Number = double.Parse(textBox1.Text);
            memory = Number;
            // Обнуляем textBox
            textBox1.Text = "0";
        }

        // Кнопка воспроизведение из памяти
        private void buttonMR_Click(object sender, EventArgs e)
        {
            // Помещаем данные из Memory в textBox
            textBox1.Text = memory.ToString();
        }

        // Кнопка очистки памяти
        private void buttonMC_Click(object sender, EventArgs e)
        {
            // Обнуляем Memory
            memory = 0;
        }

        // Кнопка С
        private void buttonC_Click(object sender, EventArgs e)
        {
            // Обнуляем textBox
            textBox1.Text = "0";
            // Обнуляем поля классов
            Number1 = 0;
        }

        // Кнопка СЕ
        private void buttonCE_Click(object sender, EventArgs e)
        {
            // Обнуляем textBox
            textBox1.Text = "0";
        }

        // Кнопка Backspace
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            StringBuilder stroka = new StringBuilder(textBox1.Text);
            stroka.Remove(stroka.Length - 1, 1);
            if (stroka.ToString() == "") stroka = new StringBuilder("0");
            textBox1.Text = stroka.ToString();
        }
        #endregion

        // Кнопка Запятая
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            
        }

        // Нажатие кнопки на клавиатуре
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            switch (symbol)
            {
                case '1': 
                    button1_Click(button1, null); 
                    break;
                case '2': 
                    button2_Click(button2, null); 
                    break;
                case '3': 
                    button3_Click(button3, null); 
                    break;
                case '4': 
                    button4_Click(button4, null); 
                    break;
                case '5': 
                    button5_Click(button5, null); 
                    break;
                case '6': 
                    button6_Click(button6, null); 
                    break;
                case '7': 
                    button7_Click(button7, null); 
                    break;
                case '8': 
                    button8_Click(button8, null); 
                    break;
                case '9': 
                    button9_Click(button9, null); 
                    break;
                case '0': 
                    button0_Click(button0, null); 
                    break;
                case '+': 
                    button11_Click(button11, null); 
                    break;
                case '-': 
                    button12_Click(button12, null); 
                    break;
                case '*': 
                    button13_Click(button13, null); 
                    break;
                case '/': 
                    button14_Click(button14, null); 
                    break;
                case '=':
                    buttonRezult_Click(buttonRezult, null);
                    break;
                case ',':
                case '.': 
                    buttonPoint_Click(buttonPoint, null); 
                    break;
                case 'p': buttonPi_Click(buttonPi, null);
                    break;
                case 'e':
                    buttonE_Click(buttonE, null);
                    break;
                case '\b': buttonBackspace_Click(buttonBackspace, null); break;
            }
        }

        private void buttonArctg_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
