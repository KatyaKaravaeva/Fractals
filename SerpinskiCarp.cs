using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PGf
{

    class SerpinskiCarp : Base
    {
        public SerpinskiCarp
            (int Level, Color startColour, Color endColour) : base(Level, startColour, endColour)
        {

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

        /// <summary>
        /// Рисование ковра Серпинского.
        /// </summary>
        /// <param name="level">уровень рекурсии</param>
        /// <param name="x1">координата по x</param>
        /// <param name="y1">координата по у</param>
        /// <param name="_width">длина</param>
        /// <param name="_height">высота</param>
        /// <param name="_graph"></param>
        public void DrawCarpet(int level, float x1, float y1, float _width, float _height, Graphics _graph)
        {
            if (level == 0)
            {
                return;

            }

            SolidBrush brush0 = new SolidBrush(colors[level]);
            _graph.FillRectangle(brush0, x1, y1, _width, _height);
            var width = _width / 3f;
            var height = _height / 3f;
            var x2 = x1 + width;
            var x3 = x1 + 2f * width;
            var y2 = y1 + height;
            var y3 = y1 + 2f * height;

            DrawCarpet(level - 1, x1, y1, width, height, _graph); 
            DrawCarpet(level - 1, x2, y1, width, height, _graph); 
            DrawCarpet(level - 1, x3, y1, width, height, _graph); 
            DrawCarpet(level - 1, x1, y2, width, height, _graph); 
            DrawCarpet(level - 1, x3, y2, width, height, _graph); 
            DrawCarpet(level - 1, x1, y3, width, height, _graph); 
            DrawCarpet(level - 1, x2, y3, width, height, _graph); 
            DrawCarpet(level - 1, x3, y3, width, height, _graph); 

        }
    }
}
