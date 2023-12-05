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
            double step = double.Parse(txtstep.Text);
            double Xmin = double.Parse();
            double Xmax = double.Parse();
        }
    }
}
