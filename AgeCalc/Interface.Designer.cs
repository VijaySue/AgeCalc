namespace AgeCalc
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            year = new TextBox();
            month = new TextBox();
            day = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            calButton = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(202, 159);
            label1.Name = "label1";
            label1.Size = new Size(390, 48);
            label1.TabIndex = 0;
            label1.Text = "请输入您的出生日期：";
            // 
            // year
            // 
            year.Location = new Point(202, 341);
            year.Name = "year";
            year.Size = new Size(186, 39);
            year.TabIndex = 1;
            // 
            // month
            // 
            month.Location = new Point(483, 341);
            month.Name = "month";
            month.Size = new Size(186, 39);
            month.TabIndex = 2;
            // 
            // day
            // 
            day.Location = new Point(758, 341);
            day.Name = "day";
            day.Size = new Size(186, 39);
            day.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(410, 340);
            label2.Name = "label2";
            label2.Size = new Size(50, 41);
            label2.TabIndex = 4;
            label2.Text = "年";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(689, 339);
            label3.Name = "label3";
            label3.Size = new Size(50, 41);
            label3.TabIndex = 5;
            label3.Text = "月";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(960, 339);
            label4.Name = "label4";
            label4.Size = new Size(50, 41);
            label4.TabIndex = 6;
            label4.Text = "日";
            // 
            // calButton
            // 
            calButton.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            calButton.Location = new Point(480, 503);
            calButton.Name = "calButton";
            calButton.Size = new Size(203, 78);
            calButton.TabIndex = 7;
            calButton.Text = "计算";
            calButton.UseVisualStyleBackColor = true;
            calButton.Click += calcButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(236, 643);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(697, 31);
            progressBar1.TabIndex = 8;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 738);
            Controls.Add(progressBar1);
            Controls.Add(calButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(day);
            Controls.Add(month);
            Controls.Add(year);
            Controls.Add(label1);
            Name = "Interface";
            Text = "年龄计算器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox year;
        private TextBox month;
        private TextBox day;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button calButton;
        private ProgressBar progressBar1;
    }
}
