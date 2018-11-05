using System;
using System.Windows.Forms;

namespace PraktikaCS
{
    public partial class Form2 : Form
    {
        double a, b, c;
        int t = 0;

        int xWidth;

        public Form2(double a, double b, double c, int xWidth)
        {
            InitializeComponent();
            timer1.Interval = 1;

            this.a = a;
            this.b = b;
            this.c = c;
            this.xWidth = xWidth;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisX.Minimum = -xWidth / 2;
            chart1.ChartAreas[0].AxisX.Maximum = xWidth / 2;
            chart1.ChartAreas[0].AxisY.Crossing = 0;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "#####";
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t <= xWidth)
            {
                int x = t - xWidth / 2;
                chart1.Series[0].Points.AddXY(x, y(a, b, c, x));
                chart1.Update();
            }
            if (t >= xWidth)
                timer1.Enabled = false;
            t += 1;
        }

        private double y(double a, double b, double c, double x)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }
    }
}
