using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pr_1
{
    public partial class График_функции : Form
    {
        public График_функции()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double y, z, step, Xmin, Xmax;
            if (!double.TryParse(txty.Text, out y) || y <= 0)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка");
                return;
            }
            if (!double.TryParse(txtz.Text, out z) || z <= 0)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка");
                return;
            }
            if (!double.TryParse(txtstep.Text, out step) || step <= 0)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка");
                return;
            }
            if (!double.TryParse(txtXmin.Text, out Xmin) || Xmin <= 0)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка");
                return;
            }
            if (!double.TryParse(txtXmax.Text, out Xmax) || Xmax <= 0)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка");
                return;
            }
            // Вычисляем количество точек
            int count = (int)Math.Ceiling((Xmax - Xmin) / step) + 1;
            double[] x = new double[count];
            double[] w = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + step * i;
                w[i] = Math.Pow(Math.Abs(Math.Cos(x[i]) - Math.Cos(y)), 1 + 2 * Math.Sin(y) * Math.Sin(y)) * (1 + z + (z * z) / 2 + (z * z * z) / 3 + (z * z * z * z) / 4);
            }
            // Устанавливаем минимальное и максимальное значения оси X на графике
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x, w);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
