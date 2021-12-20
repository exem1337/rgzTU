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
        private void startBTN_Click(object sender, EventArgs e)
        {
            //ass();

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
                if (iterator != Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text)))
                {
                    mas3[iterator] = t;
                    mas4[iterator] = epsPast;
                }
                double f = Convert.ToDouble(poweringTB.Text) * epsPast;
                //chart1.Series[0].Points.AddXY(t, f);
                
                double shit = integrator(yPast, Convert.ToDouble(stepTB.Text), Convert.ToDouble(integratorTB.Text), epsPast);
                double poop = dx(Convert.ToDouble(powering2TB.Text), Convert.ToDouble(stepTB.Text), UaPast, Uak);
                double secondDifference = (f+shit);
               
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
                //Console.WriteLine($"Время {t}: Uak2={Uak} ");

                //chart1.Series[1].Points.AddXY(t, Uak);
                if(iterator != Convert.ToInt32(Convert.ToDouble(timeTB.Text) / Convert.ToDouble(stepTB.Text)))
                {
                    mas1[iterator] = t;
                    mas2[iterator] = newUak;
                    iterator++;
                }
                
                yPast = newUak;
                UaPast = newUak;
                //Console.WriteLine($"time {t}, yPast={yPast}, UaPast={UaPast}");
            }
            //label7.Text = UaPast.ToString();


            for (int i = 0; i < mas1.Length; i++)
            {
                chart1.Series[1].Points.AddXY(mas1[i], mas2[i]);
                chart1.Series[0].Points.AddXY(mas3[i], mas4[i]);
            }

        }

        double[] masA = { 0,0.187382,0.287382,0.387382,0.487382,0.587382,0.687382,0.787382,0.887382,0.987382,1.08738,1.28738,2.28738,2.48738,
2.68738,
2.78738,
2.88738,
2.98738,
3.08738,
3.18738,
3.28738,
3.38738,
3.48738,
3.58738,
3.68738,
3.78738,
3.88738,
3.98738,
4.08738,
4.18738,
4.28738,
4.38738,
4.48738,
4.58738,
4.68738,
4.78738,
4.88738,
4.98738,
5.08738,
5.18738,
5.28738,
5.38738,
5.48738,
5.58738,
5.68738,
5.78738,
5.88738,
5.98738,
6.08738,
6.28738,
7.28738,
7.48738,
7.68738,
7.78738,
7.88738,
7.98738,
8.08738,
8.18738,
8.28738,
8.38738,
8.48738,
8.58738,
8.68738,
8.78738,
8.88738,
8.98738,
9.08738,
9.18738,
9.28738,
9.38738,
9.48738,
9.58738,
9.68738,
9.78738,
9.88738,
9.94369,10 };

        double[] masRes1 =
        {
            0,
0.0336883,
0.0774422,
0.137444,
0.212388,
0.300977,
0.401932,
0.513993,
0.635925,
0.766523,
0.904616,
1.19879,
2.77856,
3.07263,
3.34874,
3.4791,
3.60392,
3.72295,
3.83597,
3.94283,
4.04338,
4.13755,
4.22528,
4.30655,
4.38138,
4.44981,
4.51191,
4.56779,
4.61756,
4.66137,
4.69938,
4.73177,
4.75874,
4.7805,
4.79728,
4.8093,
4.81681,
4.82006,
4.8193,
4.81479,
4.80678,
4.79553,
4.7813,
4.76435,
4.74494,
4.7233,
4.69969,
4.67435,
4.6475,
4.59019,
4.28116,
4.22355,
4.16946,
4.14392,
4.11948,
4.09618,
4.07407,
4.05317,
4.03352,
4.01513,
3.99801,
3.98217,
3.9676,
3.9543,
3.94226,
3.93145,
3.92184,
3.91342,
3.90615,
3.9,
3.89492,
3.89087,
3.88782,
3.88571,
3.88449,
3.88418,
3.88413

        };

        double[] masRes2 =
        {
            5,
4.96631,
4.92256,
4.86256,
4.78761,
4.69902,
4.59807,
4.48601,
4.36407,
4.23348,
4.09538,
3.80121,
2.22144,
1.92737,
1.65126,
1.5209,
1.39608,
1.27705,
1.16403,
1.05717,
0.956619,
0.862451,
0.774721,
0.693449,
0.61862,
0.55019,
0.488086,
0.43221,
0.382439,
0.338631,
0.300625,
0.268235,
0.241264,
0.219502,
0.202725,
0.1907,
0.183187,
0.179937,
0.180698,
0.185213,
0.193224,
0.204472,
0.218699,
0.235647,
0.255064,
0.276699,
0.300308,
0.325653,
0.352499,
0.40981,
0.718841,
0.776454,
0.830544,
0.856077,
0.880518,
0.903817,
0.925932,
0.946829,
0.966482,
0.984873,
1.00199,
1.01783,
1.0324,
1.0457,
1.05774,
1.06855,
1.07816,
1.08658,
1.09385,
1.1,
1.10,508,
1.10913,
1.11218,
1.11429,
1.11551,
1.11582,
1.11587

        };

        void ass ()
        {
            for (int i = 0; i < masA.Length; i++)
            {
                chart1.Series[1].Points.AddXY(masA[i], masRes1[i]);
                chart1.Series[0].Points.AddXY(masA[i], masRes2[i]);
            }
        }


        double aperValue(double UaPast, double step, double k, double t, double UyPast) => UaPast + step * ((k / t) * UyPast - UaPast / t);
        double integrator(double Ypast, double deltaT, double K, double Upast) => Ypast + deltaT * K * Upast;
        double dx(double K, double deltaT, double Ukpast, double Uk) => (K / deltaT) * (Uk - Ukpast);
    }
}