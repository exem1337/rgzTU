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

        

        private void startBTN_Click(object sender, EventArgs e)
        {
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
                //Console.WriteLine($"Время {t}: epsPast={epsPast} ");
                        
                //Console.WriteLine($"Время {t}: UyPast={UyPast} ");

                double f = Convert.ToDouble(poweringTB.Text) * epsPast;
                //chart1.Series[0].Points.AddXY(t, f);
                if (iterator != Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text)))
                {
                    mas3[iterator] = t;
                    mas4[iterator] = f;
                }
                double shit = integrator(yPast, Convert.ToDouble(stepTB.Text), Convert.ToDouble(integratorTB.Text), UaPast);
                double poop = dx(Convert.ToDouble(powering2TB.Text), Convert.ToDouble(stepTB.Text), UaPast, Uak);
                double secondDifference = (
                    f
                    -
                    (
                        shit
                        //-
                        //poop
                    ));

                UyPast = Convert.ToDouble(poweringTB.Text) * secondDifference; //ЦМ усилительного звена

                Uak = aperValue( //ЦМ 1 апериодического звена
                    UaPast,
                    Convert.ToDouble(stepTB.Text),
                    Convert.ToDouble(k1TB.Text),
                    Convert.ToDouble(t1TB.Text),
                    UyPast);

                Console.WriteLine($"Время {t}: Uak1={Uak} ");

                double newUak = aperValue( //ЦМ 2 апериодического звена
                Uak,
                    Convert.ToDouble(stepTB.Text),
                    Convert.ToDouble(k2TB.Text),
                    Convert.ToDouble(t2TB.Text),
                    UyPast);

                //Console.WriteLine($"Время {t}: Uak2={Uak} ");

                //chart1.Series[1].Points.AddXY(t, Uak);
                if(iterator != Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text)))
                {
                    mas1[iterator] = t;
                    mas2[iterator] = Uak;
                    iterator++;
                }
                
                yPast = newUak;
                UaPast = newUak;
                //Console.WriteLine($"time {t}, yPast={yPast}, UaPast={UaPast}");
            }
            //label7.Text = UaPast.ToString();

            for(int i = 0; i < mas1.Length; i++)
            {
                chart1.Series[1].Points.AddXY(mas1[i], mas2[i]);
                chart1.Series[0].Points.AddXY(mas3[i], mas4[i]);
            }



        }

        double aperValue(double UaPast, double step, double k, double t, double UyPast) => UaPast + step * ((k / t) * UyPast - UaPast / t);
        double integrator(double Ypast, double deltaT, double K, double Upast) => Ypast + deltaT * K * Upast;
        double dx(double K, double deltaT, double Ukpast, double Uk) => (K / deltaT) * (Uk - Ukpast);
    }
}