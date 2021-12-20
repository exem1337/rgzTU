
namespace rgzTU
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.poweringTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.k1TB = new System.Windows.Forms.TextBox();
            this.t1TB = new System.Windows.Forms.TextBox();
            this.t2TB = new System.Windows.Forms.TextBox();
            this.k2TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stepTB = new System.Windows.Forms.TextBox();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.controlTB = new System.Windows.Forms.TextBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.integratorTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.powering2TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 220);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.Name = "Series1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(791, 407);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Усилитель";
            // 
            // poweringTB
            // 
            this.poweringTB.Location = new System.Drawing.Point(914, 251);
            this.poweringTB.Name = "poweringTB";
            this.poweringTB.Size = new System.Drawing.Size(100, 20);
            this.poweringTB.TabIndex = 2;
            this.poweringTB.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1 апер звено";
            // 
            // k1TB
            // 
            this.k1TB.Location = new System.Drawing.Point(914, 277);
            this.k1TB.Name = "k1TB";
            this.k1TB.Size = new System.Drawing.Size(100, 20);
            this.k1TB.TabIndex = 4;
            this.k1TB.Text = "10";
            // 
            // t1TB
            // 
            this.t1TB.Location = new System.Drawing.Point(914, 303);
            this.t1TB.Name = "t1TB";
            this.t1TB.Size = new System.Drawing.Size(100, 20);
            this.t1TB.TabIndex = 5;
            this.t1TB.Text = "2,5";
            // 
            // t2TB
            // 
            this.t2TB.Location = new System.Drawing.Point(914, 364);
            this.t2TB.Name = "t2TB";
            this.t2TB.Size = new System.Drawing.Size(100, 20);
            this.t2TB.TabIndex = 8;
            this.t2TB.Text = "4";
            // 
            // k2TB
            // 
            this.k2TB.Location = new System.Drawing.Point(914, 338);
            this.k2TB.Name = "k2TB";
            this.k2TB.Size = new System.Drawing.Size(100, 20);
            this.k2TB.TabIndex = 7;
            this.k2TB.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2 апер звено";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шаг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Управление";
            // 
            // stepTB
            // 
            this.stepTB.Location = new System.Drawing.Point(914, 394);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(100, 20);
            this.stepTB.TabIndex = 12;
            this.stepTB.Text = "0,001";
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(914, 425);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(100, 20);
            this.timeTB.TabIndex = 13;
            this.timeTB.Text = "10";
            // 
            // controlTB
            // 
            this.controlTB.Location = new System.Drawing.Point(665, 51);
            this.controlTB.Name = "controlTB";
            this.controlTB.Size = new System.Drawing.Size(100, 20);
            this.controlTB.TabIndex = 14;
            this.controlTB.Text = "5";
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(665, 170);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(100, 23);
            this.startBTN.TabIndex = 15;
            this.startBTN.Text = "Запуск";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // integratorTB
            // 
            this.integratorTB.Location = new System.Drawing.Point(665, 81);
            this.integratorTB.Name = "integratorTB";
            this.integratorTB.Size = new System.Drawing.Size(100, 20);
            this.integratorTB.TabIndex = 18;
            this.integratorTB.Text = "0,0003";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Интегратор";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(665, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0,175";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дифференциатор";
            // 
            // powering2TB
            // 
            this.powering2TB.Location = new System.Drawing.Point(665, 138);
            this.powering2TB.Name = "powering2TB";
            this.powering2TB.Size = new System.Drawing.Size(100, 20);
            this.powering2TB.TabIndex = 22;
            this.powering2TB.Text = "0,08";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Усилитель 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 202);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.powering2TB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.integratorTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.controlTB);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.stepTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t2TB);
            this.Controls.Add(this.k2TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t1TB);
            this.Controls.Add(this.k1TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poweringTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poweringTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox k1TB;
        private System.Windows.Forms.TextBox t1TB;
        private System.Windows.Forms.TextBox t2TB;
        private System.Windows.Forms.TextBox k2TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stepTB;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.TextBox controlTB;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox integratorTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox powering2TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

