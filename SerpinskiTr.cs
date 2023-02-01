using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PGf
{
    class SerpinskiTr : Base

    {

        public SerpinskiTr
            (int Level, Color startColour, Color endColour) : base(Level, startColour, endColour)
        {

        }
        public void DrawTriangle(int level, PointF top, PointF left, PointF right, Graphics _graph)
        {
            // Проверка на выход из рекурсии.
            if (level == 0)
            {
                return;

            }
            else
            {
                SolidBrush br = new SolidBrush(colors[level]);
                PointF[] points = new PointF[3]
                {
                top, right, left
                }; 
                // Рисование треугольника.
                _graph.FillPolygon(br, points);
                // Вычисление средней точки
                var leftMid = MidPoint(top, left); 
                var rightMid = MidPoint(top, right); 
                var topMid = MidPoint(left, right); 
                DrawTriangle(level - 1, top, leftMid, rightMid, _graph);
                DrawTriangle(level - 1, leftMid, left, topMid, _graph);
                DrawTriangle(level - 1, rightMid, topMid, right, _graph);
            }
        }

        /// <summary>
        /// Вычисляем координаты средней точки.
        /// </summary>
        /// <param name="p1">точка1</param>
        /// <param name="p2">точка2</param>
        /// <returns>средняя точка</returns>
        public static PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }



    }

}
