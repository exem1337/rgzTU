
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 148);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(449, 181);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Усилитель";
            // 
            // poweringTB
            // 
            this.poweringTB.Location = new System.Drawing.Point(570, 6);
            this.poweringTB.Name = "poweringTB";
            this.poweringTB.Size = new System.Drawing.Size(76, 20);
            this.poweringTB.TabIndex = 2;
            this.poweringTB.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1 апер звено";
            // 
            // k1TB
            // 
            this.k1TB.Location = new System.Drawing.Point(546, 43);
            this.k1TB.Name = "k1TB";
            this.k1TB.Size = new System.Drawing.Size(100, 20);
            this.k1TB.TabIndex = 4;
            this.k1TB.Text = "9";
            // 
            // t1TB
            // 
            this.t1TB.Location = new System.Drawing.Point(546, 69);
            this.t1TB.Name = "t1TB";
            this.t1TB.Size = new System.Drawing.Size(100, 20);
            this.t1TB.TabIndex = 5;
            this.t1TB.Text = "2,5";
            // 
            // t2TB
            // 
            this.t2TB.Location = new System.Drawing.Point(546, 130);
            this.t2TB.Name = "t2TB";
            this.t2TB.Size = new System.Drawing.Size(100, 20);
            this.t2TB.TabIndex = 8;
            this.t2TB.Text = "2";
            // 
            // k2TB
            // 
            this.k2TB.Location = new System.Drawing.Point(546, 104);
            this.k2TB.Name = "k2TB";
            this.k2TB.Size = new System.Drawing.Size(100, 20);
            this.k2TB.TabIndex = 7;
            this.k2TB.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2 апер звено";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шаг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Управление";
            // 
            // stepTB
            // 
            this.stepTB.Location = new System.Drawing.Point(546, 160);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(100, 20);
            this.stepTB.TabIndex = 12;
            this.stepTB.Text = "0,0001";
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(546, 191);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(100, 20);
            this.timeTB.TabIndex = 13;
            this.timeTB.Text = "10";
            // 
            // controlTB
            // 
            this.controlTB.Location = new System.Drawing.Point(546, 219);
            this.controlTB.Name = "controlTB";
            this.controlTB.Size = new System.Drawing.Size(100, 20);
            this.controlTB.TabIndex = 14;
            this.controlTB.Text = "4";
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(546, 257);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(100, 23);
            this.startBTN.TabIndex = 15;
            this.startBTN.Text = "Запуск";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 131);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}

