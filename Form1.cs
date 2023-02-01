using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGf
{


    public partial class Form1 : Form
    {

        static Pen pen1;
        static Graphics gr;
        static Pen pen2;
        static int iter = 3;
        Base fractal;

        //Высота и ширина для отрисовки.
        private int _width;
        private int _height;
        // Bitmap для фрактала.
        private Bitmap _fractal;


        // используем для отрисовки на PictureBox.
        private Graphics _graph;


        public Form1()
        {
            InitializeComponent();
            _width = pictureBox2.Width;
            _height = pictureBox2.Height;
            _fractal = new Bitmap(pictureBox2.Size.Width, pictureBox2.Size.Height);

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            _graph = Graphics.FromImage(_fractal);
            gr = pictureBox2.CreateGraphics();
            pen1 = new Pen(Color.Black, 3);
            pen2 = new Pen(Color.White, 3);
            gr.Clear(Color.White);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeepRec_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clearr();
        }
        /// <summary>
        /// Метод очищения PictureBox.
        /// </summary>
        public void Clearr()
        {
            pictureBox2.Image = null;
            pictureBox2.BackgroundImage = null;
        }
        /// <summary>
        /// Проверям начальный цвет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StartColour.BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// Проверяем конечный цвет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndColour_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != DialogResult.Cancel)
            {
                EndColour.BackColor = colorDialog2.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Запуск рисования фрактала "Дерево Пифагора"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Cl(object sender, EventArgs e)
        {
            //Clear();
            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);
            int RecLevel = (int)DeepRec.Value;
            fractal = new ClassTree((int)DeepRec.Value, StartColour.BackColor, EndColour.BackColor);
            double angle1 = (int)angelButton.Value;
            double angle2 = (int)angle1Button.Value;
            ClassTree.y1 = pictureBox2.Height;
            ClassTree.x1 = pictureBox2.Width;
            ClassTree.i = 0;
            Pen pen = new Pen(Color.Black);
            Graphics gr = Graphics.FromHwnd(pictureBox2.Handle);
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush colorBrush = new SolidBrush(pictureBox2.BackColor);
            ((ClassTree)fractal).Draw1((int)(pictureBox2.Width / 2), (int)pictureBox2.Height, (pictureBox2.Width / 2 + pictureBox2.Height) / 4, ClassTree.angle90, _graph, pen, EndColour.BackColor, StartColour.BackColor, (11 - (int)DeepRec.Value), angle1, angle2);
            pictureBox2.BackgroundImage = _fractal;
        }
        /// <summary>
        /// Запуск рисования кривой Кантора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cantor_Click(object sender, EventArgs e)
        {

            int RecLevel = (int)numeric3.Value;
            fractal = new CantorSet((int)DeepRec.Value, StartColour.BackColor, EndColour.BackColor);
            int n = (int)numeric3.Value;
            int a = (int)LengthOfSegment.Value;
            _fractal = new Bitmap(_width, _height);
            //рассчитываем координату Х
            int x = 610 / 2 - a / 2;
            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);
            Graphics g = pictureBox2.CreateGraphics();
            CantorSet.Colourr(n);
            Color[] colors = new Color[n + 1];
            fractal.CalculateColors(StartColour.BackColor, EndColour.BackColor, colors);
            // вызываем функцию прорисовки
            ((CantorSet)fractal).DrawB(x, 10, a, g, n, colors, _graph);
            pictureBox2.BackgroundImage = _fractal;



        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LengthOfSegment_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Запуск рисования ковра Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carpet_Click(object sender, EventArgs e)
        {
            Clearr();
            int RecLevel = (int)DeepRec.Value;
            fractal = new SerpinskiCarp((int)DeepRec.Value, StartColour.BackColor, EndColour.BackColor);

            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);

            ((SerpinskiCarp)fractal).DrawCarpet(RecLevel, 0, 0, _width, _height, _graph);
            pictureBox2.BackgroundImage = _fractal;

        }
        /// <summary>
        /// Запуск рисования треугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Clearr();
            int RecLevel = (int)DeepRec.Value;
            fractal = new SerpinskiTr((int)DeepRec.Value, StartColour.BackColor, EndColour.BackColor);
            //создаем Bitmap для треугольника
            _fractal = new Bitmap(_width, _height);
            // cоздаем новый объект Graphics из указанного Bitmap
            _graph = Graphics.FromImage(_fractal);
            //вершины треугольника
            PointF topPoint = new PointF(_width / 2f, 0);
            PointF leftPoint = new PointF(0, _height);
            PointF rightPoint = new PointF(_width, _height);

            //вызываем функцию отрисовки
            ((SerpinskiTr)fractal).DrawTriangle(RecLevel, topPoint, leftPoint, rightPoint, _graph);
            //отображаем получившийся фрактал
            pictureBox2.BackgroundImage = _fractal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Запуск рисования кривой Коха.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KochButton_Click(object sender, EventArgs e)
        {
            _graph.Clear(Color.White);
            fractal = new KochCurve((int)DeepRec.Value, StartColour.BackColor, EndColour.BackColor);
            int max = iter = (int)DeepRec.Value;
            gr.Clear(Color.White);
            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);
            float w = pictureBox2.Width;
            float h = pictureBox2.Height;
            ((KochCurve)fractal).Fractal(new PointF(w / 2, 4 * h / 5),
                new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 1 * h / 5), new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 1 * h / 5),

                iter, _graph, max, pen1, pen2);
            //отображаем получившийся фрактал
            pictureBox2.BackgroundImage = _fractal;
            

        }

        private void Form(object sender, EventArgs e)
        {

        }

        private void FromMainMenuResize(object sender, EventArgs e)
        {
            //pictureBox2.Invalidate();
        }

        private void numericUpDown3_ValueChanged_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Сохранение картинки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _fractal;
            pictureBox2.Image.Save("fractal.bmp", ImageFormat.Bmp);
        }
    }
}
