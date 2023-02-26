namespace Task1
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.maxRowField = new System.Windows.Forms.TextBox();
            this.maxColField = new System.Windows.Forms.TextBox();
            this.sumField = new System.Windows.Forms.TextBox();
            this.defField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(12, 12);
            this.inputField.Multiline = true;
            this.inputField.Name = "inputField";
            this.inputField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputField.Size = new System.Drawing.Size(840, 218);
            this.inputField.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 245);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(251, 44);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Расчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // maxRowField
            // 
            this.maxRowField.Location = new System.Drawing.Point(370, 324);
            this.maxRowField.Name = "maxRowField";
            this.maxRowField.Size = new System.Drawing.Size(100, 26);
            this.maxRowField.TabIndex = 2;
            this.maxRowField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxColField
            // 
            this.maxColField.Location = new System.Drawing.Point(370, 357);
            this.maxColField.Name = "maxColField";
            this.maxColField.Size = new System.Drawing.Size(100, 26);
            this.maxColField.TabIndex = 3;
            // 
            // sumField
            // 
            this.sumField.Location = new System.Drawing.Point(370, 389);
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(100, 26);
            this.sumField.TabIndex = 4;
            // 
            // defField
            // 
            this.defField.Location = new System.Drawing.Point(370, 426);
            this.defField.Name = "defField";
            this.defField.Size = new System.Drawing.Size(100, 26);
            this.defField.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер строки с максимальным произдением";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер стобца с максимальным произдением";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сумма строк";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Разность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defField);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.maxColField);
            this.Controls.Add(this.maxRowField);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox maxRowField;
        private System.Windows.Forms.TextBox maxColField;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.TextBox defField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

