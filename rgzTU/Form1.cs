using System;
using System.Windows.Forms;

namespace rgzTU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vovchikChislo = 0;
        double integr = 0;
        double dif = 0;
        private void startBTN_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            double[] mas1 = new double[Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text))];
            double[] mas2 = new double[Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text))];
            double[] mas3 = new double[Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text))];
            double[] mas4 = new double[Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text))];

            mas1[0] = 0;
            mas2[0] = 0;
            int iterator = 1;

            double xPast = Convert.ToDouble(controlTB.Text), /**/ epsPast = 0/*выход сумматорп*/, UyPast = 0/*выход исилителя*/, yPast = 0/**/, UaPast = 0/*Выход усилителя*/, Uak = 0/*Выход апериодического*/;

            for (double t = Convert.ToDouble(stepTB.Text); t < Convert.ToDouble(timeTB.Text); t = t + Convert.ToDouble(stepTB.Text))
            {
                //xPast = Convert.ToDouble(controlTB.Text);
                epsPast = xPast - yPast; // ЦМ сумматора

                if (iterator != Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text)))
                {
                    mas3[iterator] = t;
                    mas4[iterator] = epsPast;
                }
                double f = Convert.ToDouble(powering2TB.Text) * epsPast;
                //chart1.Series[0].Points.AddXY(t, f);

                double shit = integrator(integr, Convert.ToDouble(stepTB.Text), Convert.ToDouble(integratorTB.Text), epsPast);
                integr = shit;
                double poop = dx(Convert.ToDouble(textBox1.Text), Convert.ToDouble(stepTB.Text), dif, epsPast);
                dif = epsPast;

                double secondDifference = (f + shit);

                UyPast = Convert.ToDouble(poweringTB.Text) * secondDifference; //ЦМ усилительного звена

                Uak = aperValue( //ЦМ 1 апериодического звена
                    vovchikChislo,
                    Convert.ToDouble(stepTB.Text),
                    Convert.ToDouble(k1TB.Text),
                    Convert.ToDouble(t1TB.Text),
                    UyPast);

                vovchikChislo = Uak;

                double newUak = aperValue( //ЦМ 2 апериодического звена
                    yPast,
                    Convert.ToDouble(stepTB.Text),
                    Convert.ToDouble(k2TB.Text),
                    Convert.ToDouble(t2TB.Text),
                    Uak);
                Console.WriteLine($"Uak {Uak} | newUak {newUak}");

                if (iterator != Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text)))
                {
                    mas1[iterator] = t;
                    mas2[iterator] = newUak;
                    iterator++;
                }

                yPast = newUak;
                UaPast = newUak;

            }



            for (int i = 0; i < mas1.Length; i++)
            {
                chart1.Series[1].Points.AddXY(mas1[i], mas2[i]);
                chart1.Series[0].Points.AddXY(mas3[i], mas4[i]);
            }
            mas1 = mas2 = mas3 = mas4 = null; vovchikChislo = 0;
        }

        double aperValue(double UaPast, double step, double k, double t, double UyPast) => UaPast + step * ((k / t) * UyPast - UaPast / t);
        double integrator(double Ypast, double deltaT, double K, double Upast) => Ypast + deltaT * K * Upast;
        double dx(double K, double deltaT, double Ukpast, double Uk) => (K / deltaT) * (Uk - Ukpast);
    }
}