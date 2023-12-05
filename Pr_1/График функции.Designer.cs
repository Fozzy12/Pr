namespace Pr_1
{
    partial class График_функции
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtstep = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(323, 376);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 30;
            this.btnForm2.Text = "Переход";
            this.btnForm2.UseVisualStyleBackColor = true;
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(111, 376);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(100, 20);
            this.txtXmax.TabIndex = 29;
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(217, 376);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(100, 20);
            this.txtXmin.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Xmin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Xmax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Шаг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "A";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(323, 336);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 21;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(217, 339);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 20;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(111, 339);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 19;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(5, 339);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 18;
            // 
            // txtstep
            // 
            this.txtstep.Location = new System.Drawing.Point(5, 376);
            this.txtstep.Name = "txtstep";
            this.txtstep.Size = new System.Drawing.Size(100, 20);
            this.txtstep.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-7, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "График";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(623, 300);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // График_функции
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.txtXmax);
            this.Controls.Add(this.txtXmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtstep);
            this.Controls.Add(this.chart1);
            this.Name = "График_функции";
            this.Text = "График_функции";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtstep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}