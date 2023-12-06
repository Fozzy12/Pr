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
            double a, b, c, Xmax, Xmin, step;
            if (!double.TryParse(txta.Text, out a) || !double.TryParse(txtb.Text, out b) || !double.TryParse(txtc.Text, out c) ||
               !double.TryParse(txtstep.Text, out step) || !double.TryParse(txtXmin.Text, out Xmin) ||
               !double.TryParse(txtXmax.Text, out Xmax))
            {
                MessageBox.Show("Пожалуйста, введите числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Вычисляем количество точек
            int count = (int)Math.Ceiling((Xmax - Xmin) / step) + 1;
            double[] x = new double[count];
            double[] y = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + step * i;
                y[i] = a * Math.Pow(x[i], 2) + b * x[i] + c;
            }
            // Устанавливаем минимальное и максимальное значения оси X на графике
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Hide();
            График_функции btnForm2 = new График_функции();
            btnForm2.ShowDialog();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
