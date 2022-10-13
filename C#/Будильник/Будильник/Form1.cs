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

namespace Будильник
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        Timer timer01 = new Timer();

        
        SoundPlayer melody1 = new SoundPlayer("melody1.wav");
        SoundPlayer melody2 = new SoundPlayer("melody2.wav");
        SoundPlayer melody3 = new SoundPlayer("melody3.wav");
        SoundPlayer melody4 = new SoundPlayer("melody4.wav");
        SoundPlayer melody5 = new SoundPlayer("melody5.wav");

        bool b = false;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this) { Visible = false };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(timer1_Tick);
            timer01.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") +
                ":" + DateTime.Now.Minute.ToString("00") +
                ":" + DateTime.Now.Second.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                label2.Text = maskedTextBox1.Text;
                timer2.Start();
                maskedTextBox1.Visible = false;
                comboBox1.Visible = false;
                button1.Text = "Убрать будильник";
                b = true;
            }
            else if (b == true)
            {
                label2.Text = "00:00";
                timer2.Stop();
                maskedTextBox1.Visible = true;
                comboBox1.Visible = true;
                button1.Text = "Завести будильник";
                b = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text + ":00")
            {
                button2.Enabled = true;
                switch (comboBox1.Text)
                {
                    case "melody1": melody1.Play(); break;
                    case "melody2": melody2.Play(); break;
                    case "melody3": melody3.Play(); break;
                    case "melody4": melody4.Play(); break;
                    default: melody5.Play(); break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "melody1": melody1.Stop(); break;
                case "melody2": melody2.Stop(); break;
                case "melody3": melody3.Stop(); break;
                case "melody4": melody4.Stop(); break;
                default: melody5.Stop(); break;
            }
            button2.Enabled = false;
            maskedTextBox1.Visible = true;
            comboBox1.Visible = true;
            button1.Text = "Завести будильник";
            b = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;
        }
    }
}
