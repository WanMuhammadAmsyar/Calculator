namespace Calculator
{
    partial class Form1
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonequal = new Button();
            buttonmulti = new Button();
            buttonplus = new Button();
            buttonminus = new Button();
            result = new Label();
            button0 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(10, 78);
            button7.Name = "button7";
            button7.Size = new Size(44, 45);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(60, 78);
            button8.Name = "button8";
            button8.Size = new Size(44, 45);
            button8.TabIndex = 1;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(110, 78);
            button9.Name = "button9";
            button9.Size = new Size(44, 45);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Location = new Point(10, 129);
            button4.Name = "button4";
            button4.Size = new Size(44, 45);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(60, 129);
            button5.Name = "button5";
            button5.Size = new Size(44, 45);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(110, 129);
            button6.Name = "button6";
            button6.Size = new Size(44, 45);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 180);
            button1.Name = "button1";
            button1.Size = new Size(44, 45);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 180);
            button2.Name = "button2";
            button2.Size = new Size(44, 45);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(110, 180);
            button3.Name = "button3";
            button3.Size = new Size(44, 45);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonequal
            // 
            buttonequal.Location = new Point(110, 231);
            buttonequal.Name = "buttonequal";
            buttonequal.Size = new Size(94, 45);
            buttonequal.TabIndex = 9;
            buttonequal.Text = "=";
            buttonequal.UseVisualStyleBackColor = true;
            buttonequal.Click += buttonequal_Click;
            // 
            // buttonmulti
            // 
            buttonmulti.Location = new Point(160, 78);
            buttonmulti.Name = "buttonmulti";
            buttonmulti.Size = new Size(44, 45);
            buttonmulti.TabIndex = 10;
            buttonmulti.Text = "x";
            buttonmulti.UseVisualStyleBackColor = true;
            buttonmulti.Click += buttonmulti_Click;
            // 
            // buttonplus
            // 
            buttonplus.Location = new Point(160, 129);
            buttonplus.Name = "buttonplus";
            buttonplus.Size = new Size(44, 45);
            buttonplus.TabIndex = 11;
            buttonplus.Text = "+";
            buttonplus.UseVisualStyleBackColor = true;
            buttonplus.Click += buttonplus_Click;
            // 
            // buttonminus
            // 
            buttonminus.Location = new Point(160, 180);
            buttonminus.Name = "buttonminus";
            buttonminus.Size = new Size(44, 45);
            buttonminus.TabIndex = 12;
            buttonminus.Text = "-";
            buttonminus.UseVisualStyleBackColor = true;
            buttonminus.Click += buttonminus_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(12, 26);
            result.Name = "result";
            result.Size = new Size(24, 30);
            result.TabIndex = 13;
            result.Text = "0";
            // 
            // button0
            // 
            button0.Location = new Point(60, 231);
            button0.Name = "button0";
            button0.Size = new Size(44, 45);
            button0.TabIndex = 14;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button10
            // 
            button10.Location = new Point(10, 231);
            button10.Name = "button10";
            button10.Size = new Size(44, 45);
            button10.TabIndex = 15;
            button10.Text = "clr";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 299);
            Controls.Add(button10);
            Controls.Add(button0);
            Controls.Add(result);
            Controls.Add(buttonminus);
            Controls.Add(buttonplus);
            Controls.Add(buttonmulti);
            Controls.Add(buttonequal);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonequal;
        private Button buttonmulti;
        private Button buttonplus;
        private Button buttonminus;
        private Label result;
        private Button button0;
        private Button button10;
    }
}