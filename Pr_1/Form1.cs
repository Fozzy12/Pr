using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);
            double step = double.Parse(txtd.Text);

            // Очищаем график перед построением нового
            chart1.Series.Clear();
            // Создаем новый ряд данных для графика
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            // Вычисляем значения функции и добавляем точки к ряду данных
            for (double x = -10; x <= 10; x += step)
            {
                double y = a * x * x + b * x + c;
                series.Points.AddXY(x, y);
            }

            // Добавляем ряд данных на график
            chart1.Series.Add(series);
        }
    }
}
