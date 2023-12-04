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
            this.btnCombination = new System.Windows.Forms.Button();
            this.btnPlacement = new System.Windows.Forms.Button();
            this.BtnPermutation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCombination
            // 
            this.btnCombination.Location = new System.Drawing.Point(12, 12);
            this.btnCombination.Name = "btnCombination";
            this.btnCombination.Size = new System.Drawing.Size(90, 23);
            this.btnCombination.TabIndex = 0;
            this.btnCombination.Text = "Сочетание";
            this.btnCombination.UseVisualStyleBackColor = true;
            this.btnCombination.Click += new System.EventHandler(this.btnCombination_Click);
            // 
            // btnPlacement
            // 
            this.btnPlacement.Location = new System.Drawing.Point(12, 41);
            this.btnPlacement.Name = "btnPlacement";
            this.btnPlacement.Size = new System.Drawing.Size(90, 23);
            this.btnPlacement.TabIndex = 1;
            this.btnPlacement.Text = "Размещение";
            this.btnPlacement.UseVisualStyleBackColor = true;
            this.btnPlacement.Click += new System.EventHandler(this.btnPlacement_Click);
            // 
            // BtnPermutation
            // 
            this.BtnPermutation.Location = new System.Drawing.Point(12, 70);
            this.BtnPermutation.Name = "BtnPermutation";
            this.BtnPermutation.Size = new System.Drawing.Size(90, 23);
            this.BtnPermutation.TabIndex = 2;
            this.BtnPermutation.Text = "Перестановка";
            this.BtnPermutation.UseVisualStyleBackColor = true;
            this.BtnPermutation.Click += new System.EventHandler(this.BtnPermutation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(147, 19);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(70, 20);
            this.txtm.TabIndex = 6;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(147, 48);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(70, 20);
            this.txtn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(44, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(186, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 155);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPermutation);
            this.Controls.Add(this.btnPlacement);
            this.Controls.Add(this.btnCombination);
            this.Name = "Form1";
            this.Text = "Элементы комбинаторики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCombination;
        private System.Windows.Forms.Button btnPlacement;
        private System.Windows.Forms.Button BtnPermutation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

