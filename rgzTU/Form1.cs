using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double xPast = 0, epsPast = 0, UyPast = 0, yPast = 0, UaPast = 0, Uak;

            for(double t = 0; t < Convert.ToDouble(timeTB.Text); t = t + Convert.ToDouble(stepTB.Text))
            {
                xPast = t;
                epsPast = xPast - yPast; // ЦМ сумматора

                //chart1.Series[0].Points.AddXY(t, epsPast);

                UyPast = Convert.ToDouble(poweringTB.Text) * epsPast; //ЦМ усилительного звена
                
                Uak = aperValue( //ЦМ 1 апериодического звена
                    UaPast,
                    Convert.ToDouble(stepTB.Text),
                    Convert.ToDouble(k1TB.Text),
                    Convert.ToDouble(t1TB.Text),
                    UyPast);
                
                Uak = aperValue( //ЦМ 2 апериодического звена
                    Uak,
                    Convert.ToDouble(stepTB.Text),
                    Convert.ToDouble(k2TB.Text),
                    Convert.ToDouble(t2TB.Text),
                    UyPast);

                //chart1.Series[1].Points.AddXY(t, Uak);

                yPast = Uak;
                UaPast = Uak;

            }
            //label7.Text = UaPast.ToString();
        }

        double aperValue(double UaPast, double step, double k, double t, double UyPast) => UaPast + step * ((k / t) * UyPast - UaPast / t); 



    }
}
