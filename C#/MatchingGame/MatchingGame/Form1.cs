using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        SoundPlayer mediayes = new SoundPlayer(@"yes.wav");
        SoundPlayer mediano = new SoundPlayer(@"no.wav");
        SoundPlayer mediawin = new SoundPlayer(@"win.wav");
        Label firstClicked = null;
        Label secondClicked = null;

        //используем объект Random для выбора случайной
        //иконки для квадратиков

        //Каждая из этих букв--это иконка
        //в шрифте Webdings,
        //и каждая иконка используется дважды
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k", "h", "h", "j", "j", "p", "p", "o", "o", "l", "l",
            "b", "b", "v", "v", "w", "w", "z", "z", "L", "L", "f", "f", "O", "O", "V", "V", "a", "a"
        };
        int timeMin = 0;
        int timeSec = 0;
        int second = 0;

        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            //TableLayoutPanel имеет 16 меток,
            //и icon list имеет 16 иконок,
            //поэтому иконки случайным образом берутся из list
            //и добавляются в каждую метку
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
            
            timeLabel.Text = "0:0";
            timer2.Start();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            Label clickedLabel = sender as Label;

            if(clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black) 
                    return; 

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    timer3.Start();
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    timer3.Stop();
                    second = 0;
                    mediayes.Play();
                    return;
                }
                else
                {
                    mediano.Play();
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Stop timer
            timer1.Stop();

            //Скрыть иконки
            timer3.Stop();
            second = 0;
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if(iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            mediawin.Play();
            MessageBox.Show("Вы сопоставили все картинки! Ваше время: " + timeLabel.Text, "Поздравляем!");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeSec==60)
            {
                timeSec = 0;
                timeMin++;
            }
            timeSec++;
            timeLabel.Text = timeMin + ":" + timeSec;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 5)
            {
                firstClicked.ForeColor = firstClicked.BackColor;
                firstClicked = null;
                second = 0;
                timer3.Stop();
            }
        }
    }
}
