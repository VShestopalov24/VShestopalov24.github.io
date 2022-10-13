using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Кисти
            SolidBrush A = new SolidBrush(Color.DarkGray);
            SolidBrush B = new SolidBrush(Color.White);
            SolidBrush C = new SolidBrush(Color.SaddleBrown);
            SolidBrush D = new SolidBrush(Color.DarkGreen);
            SolidBrush E = new SolidBrush(Color.Black);
            SolidBrush F = new SolidBrush(Color.Red);
            SolidBrush J = new SolidBrush(Color.CornflowerBlue);
            Pen Z = new Pen(Color.Brown, 2);

            //Фон
            g.FillRectangle(A, 0, 0, 820, 500);

            //Снег
            g.FillRectangle(B, 0, 430, 820, 30);
            g.DrawRectangle(Z, 0, 430, 820, 30);

            //Елка
            g.FillRectangle(C, 85, 390, 40, 40);
            g.DrawRectangle(Z, 85, 390, 40, 40);

            PointF point1 = new PointF(20, 390);
            PointF point2 = new PointF(190, 390);
            PointF point3 = new PointF(105, 270);
            PointF[] curvePoints1 = { point1, point2, point3 };
            g.FillPolygon(D, curvePoints1);
            g.DrawPolygon(Z, curvePoints1);

            PointF point4 = new PointF(35, 270);
            PointF point5 = new PointF(175, 270);
            PointF point6 = new PointF(105, 155);
            PointF[] curvePoints2 = { point4, point5, point6 };
            g.FillPolygon(D, curvePoints2);
            g.DrawPolygon(Z, curvePoints2);

            PointF point7 = new PointF(50, 155);
            PointF point8 = new PointF(160, 155);
            PointF point9 = new PointF(105, 50);
            PointF[] curvePoints3 = { point7, point8, point9 };
            g.FillPolygon(D, curvePoints3);
            g.DrawPolygon(Z, curvePoints3);

            //Шары у снеговика
            g.FillEllipse(B, 440, 75, 100, 100);
            g.DrawEllipse(Z, 440, 75, 100, 100);

            g.FillEllipse(B, 420, 160, 140, 140);
            g.DrawEllipse(Z, 420, 160, 140, 140);

            g.FillEllipse(B, 400, 280, 180, 180);
            g.DrawEllipse(Z, 400, 280, 180, 180);

            //Руки
            g.FillEllipse(B, 400, 160, 50, 50);
            g.DrawEllipse(Z, 400, 160, 50, 50);

            g.FillEllipse(B, 530, 160, 50, 50);
            g.DrawEllipse(Z, 530, 160, 50, 50);

            //Пуговицы
            g.FillEllipse(E, 480, 195, 20, 20);
            g.DrawEllipse(Z, 480, 195, 20, 20);

            g.FillEllipse(E, 480, 235, 20, 20);
            g.DrawEllipse(Z, 480, 235, 20, 20);

            //Глаза
            g.FillEllipse(E, 450, 100, 20, 20);
            g.DrawEllipse(Z, 450, 100, 20, 20);

            g.FillEllipse(E, 495, 100, 20, 20);
            g.DrawEllipse(Z, 495, 100, 20, 20);

            //Рот
            g.FillEllipse(F, 475, 137, 20, 20);
            g.DrawEllipse(Z, 475, 137, 20, 20);

            //Нос
            PointF point10 = new PointF(483, 110);
            PointF point11 = new PointF(493, 120);
            PointF point12 = new PointF(400, 155);
            PointF[] curvePoints4 = { point10, point11, point12 };
            g.FillPolygon(F, curvePoints4);
            g.DrawPolygon(Z, curvePoints4);

            //Шапка
            g.FillRectangle(J, 455, 20, 70, 70);
            g.DrawRectangle(Z, 455, 20, 70, 70);

            //Снег
            g.FillRectangle(B, 0, 430, 820, 30);
            g.DrawRectangle(Z, 0, 430, 820, 30);
        }
    }
}
