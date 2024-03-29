﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Математическая_головоломка
{
    public partial class Form1 : Form
    {
        //Создание метода для генерации случайных чисел
        Random randomizer = new Random();
        //Переменные для подстановки в примеры
        int addend1;
        int addend2;

        int minuend;//Уменьшаемое
        int subtrahend;//Вычитаемое

        int multiplicand;//Множимое
        int multiplier;//Множитель

        int dividend;//Делимое
        int divisor;//Делитель

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
        }

        public void StartTheQuiz()
        {
            //Заполняет пример на сложение
            //Генерация двух случайных чисел.
            //Запись их в переменные addend1 и addend2
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Конвертирование двух сгенерированных чисел
            //В строки для отображения в метках
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //'sum' это значение переменной, которое равно 0.
            //перед сложением
            sum.Value = 0;

            //Создание примера на вычитание
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //Создание примера на умножение
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Создание примера на деление
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Метод обработки нажатия кнопки Запуск головоломки
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        //Метод обработки таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //Если CheckTheAnswer() возвращает значение true,
                //т.е. правильный ответ, тогда время останавливается
                //и будет показано сообщение.
                timer1.Stop();
                MessageBox.Show("You got all answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                //Если CheckTheAnswer() возвращает значение false,
                //будет дана еще одна попытка
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
            //Изменение цвета если осталось меньше 5 секунд
            if (timeLeft <= 5)
            {
                timeLabel.BackColor = Color.Red;
            }
            else { timeLabel.BackColor = Color.White; }
        }

        //Проверка правильных ответов
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend-subtrahend==difference.Value)
                && (multiplicand*multiplier==product.Value)
                && (dividend/divisor==quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if(answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
