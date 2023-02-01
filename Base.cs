using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PGf
{
    public class Base
    {
        protected Color startColor;
        protected Color endColor;
        protected int Level;
        protected Color[] colors;
        public Base(int Level, Color startColour, Color endColour)
        {
            this.Level = Level;
            this.startColor = startColour;
            this.endColor = endColour;
            colors = new Color[Level + 1];
            CalculateColors();
        }

        public Color[] Colors
        {
            get => colors;
        }
        /// <summary>
        /// Метод заполнения массива цветов.
        /// </summary>
        public void CalculateColors()
        {

            int rMin = startColor.R;
            int gMin = startColor.G;
            int bMin = startColor.B;

            int rMax = endColor.R;
            int gMax = endColor.G;
            int bMax = endColor.B;


            int size = colors.Length;
            for (int i = size - 1; i > 0; i--)
            {
                var rAverage = rMin + (int)((rMax - rMin) * i / size);
                var gAverage = gMin + (int)((gMax - gMin) * i / size);
                var bAverage = bMin + (int)((bMax - bMin) * i / size);
                colors[i] = Color.FromArgb(rAverage, gAverage, bAverage);
            }
        }
        /// <summary>
        /// Метод заполнения массива цветов.
        /// </summary>
        /// <param name="startColor">начальный цвет</param>
        /// <param name="endColor">конечный цвет</param>
        /// <param name="colors">массив цветов</param>
        public void CalculateColors(Color startColor, Color endColor, Color[] colors)
        {

            int rMin = startColor.R;
            int gMin = startColor.G;
            int bMin = startColor.B;

            int rMax = endColor.R;
            int gMax = endColor.G;
            int bMax = endColor.B;


            int size = colors.Length;
            for (int i = size - 1; i > 0; i--)
            {
                var rAverage = rMin + (int)((rMax - rMin) * i / size);
                var gAverage = gMin + (int)((gMax - gMin) * i / size);
                var bAverage = bMin + (int)((bMax - bMin) * i / size);
                colors[i] = Color.FromArgb(rAverage, gAverage, bAverage);
            }



        }

    }
}
