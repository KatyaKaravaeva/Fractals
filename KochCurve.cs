using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PGf
{
    class KochCurve: Base
    {
        public KochCurve
            (int Level, Color startColour, Color endColour) : base(Level, startColour, endColour)
        {

        }
        /// <summary>
        /// Рекурсивная функция отрисовки фрактала.
        /// </summary>
        /// <param name="p1">точка1</param>
        /// <param name="p2">точка2</param>
        /// <param name="p3">точка3</param>
        /// <param name="n">количество рекурсивный вызовов</param>
        /// <param name="gr"></param>
        /// <param name="max">глубина рекурсии</param>
        /// <param name="pen1">цвет для рисования</param>
        /// <param name="pen2">ластик</param>
        /// <returns>оставшееся количество рекурсивных методов</returns>
        public int Fractal(PointF p1, PointF p2, PointF p3, int n, Graphics gr, int max, Pen pen1, Pen pen2)
        {
        
            if (n == max)
            {
                pen1.Color = colors[n];
                gr.DrawLine(pen1, p2, p3);
                Fractal(p2, p3, p1, n - 1, gr, max, pen1, pen2);
            }
            else if (n > 0)
            {
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                pen1.Color = colors[n];
                gr.DrawLine(pen1, p4, pn);
                pen1.Color = colors[n];
                gr.DrawLine(pen1, p5, pn);
                gr.DrawLine(pen2, p4, p5);

                Fractal(p4, pn, p5, n - 1, gr, max, pen1, pen2);
                Fractal(pn, p5, p4, n - 1, gr, max, pen1, pen2);
                Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3,
                    (2 * p1.Y + p3.Y) / 3), n - 1, gr, max, pen1, pen2);
                Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3,
                    (2 * p2.Y + p3.Y) / 3), n - 1, gr, max, pen1, pen2);

            }
            return n;
        }
    }
}