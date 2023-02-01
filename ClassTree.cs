using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PGf
{
    public class ClassTree : Base

    {
        public ClassTree
            (int Level, Color startColour, Color endColour) : base(Level, startColour, endColour)
        {

        }
        public const double angle45 = Math.PI / 4;
        public const double angle90 = Math.PI / 2;
        public const double angle30 = Math.PI / 6;
        public static int i1;
        public static int size;
        public static List<Color> colorList = new List<Color>();
        public static int kz = 0;
        public static int k1 = 0;
        /// <summary>
        /// Проверяем уровень рекурсии.
        /// </summary>
        /// <param name="a">коэффициент</param>
        /// <param name="recursNum">номер рекурсии</param>
        public static void Check(double a, int recursNum)
        {
            if (a > recursNum)
            {
                a *= 0.7;
                kz++;
                Check(a, recursNum);
                Check(a, recursNum);
            }
        }
        /// <summary>
        /// Рекурсивный метод отрисовки фрактала.
        /// </summary>
        /// <param name="w">длина</param>
        /// <param name="h">высота</param>
        /// <param name="a">коэффициент рекурсии</param>
        /// <param name="b"></param>
        /// <param name="g"></param>
        /// <param name="pen">ручка</param>
        /// <param name="colorStart">начальный цвет</param>
        /// <param name="colorEnd">конечный цвет</param>
        /// <param name="recursNum">количество рекурсивных вызовов</param>
        /// <param name="angle1">угол наклона первого отрезка</param>
        /// <param name="angle2">угол наклона второго отрезка</param>
        public void Draw1(int w, int h, double a, double b, Graphics g, Pen pen, Color colorStart, Color colorEnd,
            int recursNum, double angle1, double angle2)
        {
            i1 = 0;
            kz = 0;
            Check(a, recursNum);
            size = kz + 1;
            i1 = recursNum;
            int rMax = colorStart.R;
            int gMax = colorStart.G;
            int bMax = colorStart.B;
            int rMin = colorEnd.R;
            int gMin = colorEnd.G;
            int bMin = colorEnd.B;
            colorList = null;
            colorList = new List<Color>();
            for (int i = 0; i < size; i++)
            {
                var rAverage = rMin + ((rMax - rMin) * i / size);
                var gAverage = gMin + ((gMax - gMin) * i / size);
                var bAverage = bMin + ((bMax - bMin) * i / size);
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }

            Draw(w, h, a, b, g, pen, colorStart, colorEnd, recursNum, angle1, angle2);
        }

        public void Draw(int w, int h, double a, double b, Graphics g, Pen pen, Color colorStart, Color colorEnd,
            int recursNum, double angle1, double angle2)
        {
            if (a > recursNum)
            {
                a *= 0.7;
                DrawLine(w, h, a, b, g, pen, colorStart, colorEnd);
                w = (int)(Math.Round(w + (a * Math.Cos(b))));
                h = (int)(Math.Round(h - (a * Math.Sin(b))));
                Draw(w, h, a, b + angle1 * Math.PI / 180, g, pen, colorStart, colorEnd, recursNum, angle1, angle2);
                Draw(w, h, a, b - angle2 * Math.PI / 180, g, pen, colorStart, colorEnd, recursNum, angle1, angle2);
            }
        }

        public static int k = 0;
        public static int i = 0;
        public static int x1;
        public static int y1;
        // Рисуем линии.
        private void DrawLine(int x, int y, double a, double b, Graphics g, Pen pen, Color colorStart,
            Color colorEnd)
        {
            i++;
            pen.Color = colorList[i];
            g.DrawLine(pen, x, y, (float)Math.Round(x + a * Math.Cos(b)), (float)Math.Round(y - a * Math.Sin(b)));
        }


    }
}

