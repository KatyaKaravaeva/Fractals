using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PGf
{
    class CantorSet : Base
    {


        public CantorSet
            (int Level, Color startColour, Color endColour) : base(Level, startColour, endColour)
        {

        }
        public static int count;
        public static void Colourr(int n)
        {
            count = n;
        }
        public void DrawB(int x, int y, int width, Graphics g, int n, Color[] color, Graphics _graph)
        {
            if (count < 0 || count >= color.Length)
                count = 1;

            // Каждый раз меняем цвет для рисования.
            SolidBrush Black = new SolidBrush(color[count]);
            Pen myPen = new Pen(color[count], 1);

            if (width >= (50 + 1) - n)
            {
                //Рисуем отрезки.
                _graph.DrawRectangle(myPen, x, y, width, 12);
                _graph.FillRectangle(Black, x, y, width, 12);

                //Сдвиг вниз.
                y = y + 40;

                //Вызов функции.
                DrawB(x + width * 2 / 3, y, width / 3, g, n, color, _graph);
                DrawB(x, y, width / 3, g, n, color, _graph);
                count--;
            }
        }
    }
}
