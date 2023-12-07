namespace Pr_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chL = new System.Windows.Forms.CheckBox();
            this.chU = new System.Windows.Forms.CheckBox();
            this.chN = new System.Windows.Forms.CheckBox();
            this.cmData = new System.Windows.Forms.ComboBox();
            this.nmA = new System.Windows.Forms.NumericUpDown();
            this.nmK = new System.Windows.Forms.NumericUpDown();
            this.cmTime = new System.Windows.Forms.ComboBox();
            this.cmV = new System.Windows.Forms.ComboBox();
            this.cmR = new System.Windows.Forms.ComboBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chT = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЖДКасса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рейс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата отправление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип Вагона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество Взрослых";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество Детей";
            // 
            // chL
            // 
            this.chL.AutoSize = true;
            this.chL.Location = new System.Drawing.Point(158, 243);
            this.chL.Name = "chL";
            this.chL.Size = new System.Drawing.Size(109, 17);
            this.chL.TabIndex = 7;
            this.chL.Text = "Наличие багажа";
            this.chL.UseVisualStyleBackColor = true;
            // 
            // chU
            // 
            this.chU.AutoSize = true;
            this.chU.Location = new System.Drawing.Point(18, 243);
            this.chU.Name = "chU";
            this.chU.Size = new System.Drawing.Size(102, 17);
            this.chU.TabIndex = 8;
            this.chU.Text = "Наличие белья";
            this.chU.UseVisualStyleBackColor = true;
            // 
            // chN
            // 
            this.chN.AutoSize = true;
            this.chN.Location = new System.Drawing.Point(18, 266);
            this.chN.Name = "chN";
            this.chN.Size = new System.Drawing.Size(113, 17);
            this.chN.TabIndex = 9;
            this.chN.Text = "Наличие питания";
            this.chN.UseVisualStyleBackColor = true;
            // 
            // cmData
            // 
            this.cmData.FormattingEnabled = true;
            this.cmData.Items.AddRange(new object[] {
            "14.01.2024",
            "10.12.2023",
            "12.02.2024",
            "01.01.2024"});
            this.cmData.Location = new System.Drawing.Point(126, 73);
            this.cmData.Name = "cmData";
            this.cmData.Size = new System.Drawing.Size(179, 21);
            this.cmData.TabIndex = 10;
            // 
            // nmA
            // 
            this.nmA.Location = new System.Drawing.Point(167, 167);
            this.nmA.Name = "nmA";
            this.nmA.Size = new System.Drawing.Size(168, 20);
            this.nmA.TabIndex = 12;
            // 
            // nmK
            // 
            this.nmK.Location = new System.Drawing.Point(167, 197);
            this.nmK.Name = "nmK";
            this.nmK.Size = new System.Drawing.Size(168, 20);
            this.nmK.TabIndex = 13;
            // 
            // cmTime
            // 
            this.cmTime.FormattingEnabled = true;
            this.cmTime.Items.AddRange(new object[] {
            "08:45",
            "12:30",
            "18:23",
            "01:29"});
            this.cmTime.Location = new System.Drawing.Point(126, 100);
            this.cmTime.Name = "cmTime";
            this.cmTime.Size = new System.Drawing.Size(179, 21);
            this.cmTime.TabIndex = 14;
            // 
            // cmV
            // 
            this.cmV.FormattingEnabled = true;
            this.cmV.Items.AddRange(new object[] {
            "Купе",
            "СВ",
            "Плацкарт",
            "Для инвалидов"});
            this.cmV.Location = new System.Drawing.Point(127, 127);
            this.cmV.Name = "cmV";
            this.cmV.Size = new System.Drawing.Size(178, 21);
            this.cmV.TabIndex = 15;
            // 
            // cmR
            // 
            this.cmR.FormattingEnabled = true;
            this.cmR.Items.AddRange(new object[] {
            "Екатеринбург-Москва",
            "Сочи-Екатеринбург",
            "Москва-Владивосток",
            "Волгоград-Краснодар"});
            this.cmR.Location = new System.Drawing.Point(126, 46);
            this.cmR.Name = "cmR";
            this.cmR.Size = new System.Drawing.Size(179, 21);
            this.cmR.TabIndex = 16;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(12, 289);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(200, 50);
            this.btnTicket.TabIndex = 17;
            this.btnTicket.Text = "Оформить билет";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(240, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 50);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chT
            // 
            this.chT.AutoSize = true;
            this.chT.Location = new System.Drawing.Point(158, 266);
            this.chT.Name = "chT";
            this.chT.Size = new System.Drawing.Size(109, 17);
            this.chT.TabIndex = 19;
            this.chT.Text = "Обратный билет";
            this.chT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 346);
            this.Controls.Add(this.chT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.cmR);
            this.Controls.Add(this.cmV);
            this.Controls.Add(this.cmTime);
            this.Controls.Add(this.nmK);
            this.Controls.Add(this.nmA);
            this.Controls.Add(this.cmData);
            this.Controls.Add(this.chN);
            this.Controls.Add(this.chU);
            this.Controls.Add(this.chL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ЖДКасса";
            ((System.ComponentModel.ISupportInitialize)(this.nmA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chL;
        private System.Windows.Forms.CheckBox chU;
        private System.Windows.Forms.CheckBox chN;
        private System.Windows.Forms.ComboBox cmData;
        private System.Windows.Forms.NumericUpDown nmA;
        private System.Windows.Forms.NumericUpDown nmK;
        private System.Windows.Forms.ComboBox cmTime;
        private System.Windows.Forms.ComboBox cmV;
        private System.Windows.Forms.ComboBox cmR;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chT;
    }
}

