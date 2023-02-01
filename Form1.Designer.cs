namespace PGf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StartColour = new System.Windows.Forms.Button();
            this.EndColour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DeepRec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Tree = new System.Windows.Forms.Button();
            this.Cantor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LengthOfSegment = new System.Windows.Forms.NumericUpDown();
            this.ButtonTriangle = new System.Windows.Forms.Button();
            this.Carpet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric3 = new System.Windows.Forms.NumericUpDown();
            this.KochButton = new System.Windows.Forms.Button();
            this.angelButton = new System.Windows.Forms.NumericUpDown();
            this.angle1Button = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SavePicture = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeepRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle1Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Clear.Location = new System.Drawing.Point(23, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(112, 69);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Конечный цвет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начальный цвет:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(269, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(707, 583);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Resize += new System.EventHandler(this.FromMainMenuResize);
            // 
            // StartColour
            // 
            this.StartColour.BackColor = System.Drawing.Color.Fuchsia;
            this.StartColour.Location = new System.Drawing.Point(170, 179);
            this.StartColour.Name = "StartColour";
            this.StartColour.Size = new System.Drawing.Size(32, 34);
            this.StartColour.TabIndex = 6;
            this.StartColour.UseVisualStyleBackColor = false;
            this.StartColour.Click += new System.EventHandler(this.StartColour_Click);
            // 
            // EndColour
            // 
            this.EndColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EndColour.Location = new System.Drawing.Point(168, 230);
            this.EndColour.Name = "EndColour";
            this.EndColour.Size = new System.Drawing.Size(34, 34);
            this.EndColour.TabIndex = 7;
            this.EndColour.UseVisualStyleBackColor = false;
            this.EndColour.Click += new System.EventHandler(this.EndColour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-8, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Соотношение отрезков:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(194, 378);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 31);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // DeepRec
            // 
            this.DeepRec.Location = new System.Drawing.Point(194, 341);
            this.DeepRec.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DeepRec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeepRec.Name = "DeepRec";
            this.DeepRec.Size = new System.Drawing.Size(69, 31);
            this.DeepRec.TabIndex = 13;
            this.DeepRec.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DeepRec.ValueChanged += new System.EventHandler(this.DeepRec_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(194, 415);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 31);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ширина кисти:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Глубина рекурсии:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(23, 87);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(112, 34);
            this.Tree.TabIndex = 14;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.tree_Cl);
            // 
            // Cantor
            // 
            this.Cantor.Location = new System.Drawing.Point(23, 127);
            this.Cantor.Name = "Cantor";
            this.Cantor.Size = new System.Drawing.Size(112, 34);
            this.Cantor.TabIndex = 15;
            this.Cantor.Text = "Cantor";
            this.Cantor.UseVisualStyleBackColor = true;
            this.Cantor.Click += new System.EventHandler(this.Cantor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Введите длину отрезка(Cantor)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LengthOfSegment
            // 
            this.LengthOfSegment.Location = new System.Drawing.Point(12, 551);
            this.LengthOfSegment.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.LengthOfSegment.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.LengthOfSegment.Name = "LengthOfSegment";
            this.LengthOfSegment.Size = new System.Drawing.Size(204, 31);
            this.LengthOfSegment.TabIndex = 17;
            this.LengthOfSegment.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.LengthOfSegment.ValueChanged += new System.EventHandler(this.LengthOfSegment_ValueChanged);
            // 
            // ButtonTriangle
            // 
            this.ButtonTriangle.Location = new System.Drawing.Point(141, 87);
            this.ButtonTriangle.Name = "ButtonTriangle";
            this.ButtonTriangle.Size = new System.Drawing.Size(112, 34);
            this.ButtonTriangle.TabIndex = 18;
            this.ButtonTriangle.Text = "Triangle";
            this.ButtonTriangle.UseVisualStyleBackColor = true;
            this.ButtonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // Carpet
            // 
            this.Carpet.Location = new System.Drawing.Point(141, 127);
            this.Carpet.Name = "Carpet";
            this.Carpet.Size = new System.Drawing.Size(112, 34);
            this.Carpet.TabIndex = 19;
            this.Carpet.Text = "Carpet";
            this.Carpet.UseVisualStyleBackColor = true;
            this.Carpet.Click += new System.EventHandler(this.Carpet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Глубина рекурсии для Cantor ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // numeric3
            // 
            this.numeric3.Location = new System.Drawing.Point(12, 477);
            this.numeric3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeric3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric3.Name = "numeric3";
            this.numeric3.Size = new System.Drawing.Size(199, 31);
            this.numeric3.TabIndex = 21;
            this.numeric3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeric3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // KochButton
            // 
            this.KochButton.Location = new System.Drawing.Point(141, 47);
            this.KochButton.Name = "KochButton";
            this.KochButton.Size = new System.Drawing.Size(112, 34);
            this.KochButton.TabIndex = 22;
            this.KochButton.Text = "KochCurve";
            this.KochButton.UseVisualStyleBackColor = true;
            this.KochButton.Click += new System.EventHandler(this.KochButton_Click);
            // 
            // angelButton
            // 
            this.angelButton.Location = new System.Drawing.Point(194, 271);
            this.angelButton.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.angelButton.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.angelButton.Name = "angelButton";
            this.angelButton.Size = new System.Drawing.Size(69, 31);
            this.angelButton.TabIndex = 23;
            this.angelButton.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // angle1Button
            // 
            this.angle1Button.Location = new System.Drawing.Point(194, 308);
            this.angle1Button.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.angle1Button.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.angle1Button.Name = "angle1Button";
            this.angle1Button.Size = new System.Drawing.Size(69, 31);
            this.angle1Button.TabIndex = 24;
            this.angle1Button.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Угол наклона (2):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Угол наклона (1):";
            // 
            // SavePicture
            // 
            this.SavePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SavePicture.Location = new System.Drawing.Point(982, 115);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(219, 116);
            this.SavePicture.TabIndex = 27;
            this.SavePicture.Text = "Сохранение картинки";
            this.SavePicture.UseVisualStyleBackColor = false;
            this.SavePicture.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(996, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 50);
            this.label11.TabIndex = 28;
            this.label11.Text = "Сохранение в \r\n=> bin => Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 594);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SavePicture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.angle1Button);
            this.Controls.Add(this.angelButton);
            this.Controls.Add(this.KochButton);
            this.Controls.Add(this.numeric3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Carpet);
            this.Controls.Add(this.ButtonTriangle);
            this.Controls.Add(this.LengthOfSegment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cantor);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.DeepRec);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndColour);
            this.Controls.Add(this.StartColour);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeepRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle1Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button StartColour;
        private System.Windows.Forms.Button EndColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown DeepRec;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button Cantor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown LengthOfSegment;
        private System.Windows.Forms.Button ButtonTriangle;
        private System.Windows.Forms.Button Carpet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numeric3;
        private System.Windows.Forms.Button KochButton;
        private System.Windows.Forms.NumericUpDown angelButton;
        private System.Windows.Forms.NumericUpDown angle1Button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SavePicture;
        private System.Windows.Forms.Button Clear;
    }
}

