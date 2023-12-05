using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);
            double step = double.Parse(txtstep.Text);
            double Xmin = double.Parse(txtXmin.Text);
            double Xmax = double.Parse(txtXmax.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / step) + 1;
            double[] x = new double[count];
            double[] y = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + step * i;
                y[i] = a * Math.Pow(x[i], 2) + b * x[i] + c;
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }
    }
}
