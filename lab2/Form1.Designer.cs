namespace lab2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            txtInput = new TextBox();
            lbl = new Label();
            lblSum = new Label();
            button2 = new Button();
            lblFibonacci = new Label();
            textSum = new TextBox();
            button3 = new Button();
            txtFibonacciInput = new TextBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            txtBase = new TextBox();
            lblPower = new Label();
            button4 = new Button();
            txtExponent = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(322, 193);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Factorial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(322, 155);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(242, 27);
            txtInput.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(429, 199);
            lbl.Name = "lbl";
            lbl.Size = new Size(72, 20);
            lbl.TabIndex = 2;
            lbl.Text = "Factorial: ";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(429, 280);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(45, 20);
            lblSum.TabIndex = 4;
            lblSum.Text = "Sum: ";
            // 
            // button2
            // 
            button2.Location = new Point(322, 275);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "Sum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblFibonacci
            // 
            lblFibonacci.AutoSize = true;
            lblFibonacci.Location = new Point(429, 366);
            lblFibonacci.Name = "lblFibonacci";
            lblFibonacci.Size = new Size(52, 20);
            lblFibonacci.TabIndex = 7;
            lblFibonacci.Text = "Result:";
            // 
            // textSum
            // 
            textSum.Location = new Point(322, 240);
            textSum.Margin = new Padding(3, 4, 3, 4);
            textSum.Name = "textSum";
            textSum.Size = new Size(242, 27);
            textSum.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(322, 360);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 5;
            button3.Text = "Fibonacci";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(322, 325);
            txtFibonacciInput.Margin = new Padding(3, 4, 3, 4);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(242, 27);
            txtFibonacciInput.TabIndex = 8;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(322, 409);
            txtBase.Margin = new Padding(3, 4, 3, 4);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(120, 27);
            txtBase.TabIndex = 11;
            txtBase.Text = "Base";
            // 
            // lblPower
            // 
            lblPower.AutoSize = true;
            lblPower.Location = new Point(429, 450);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(52, 20);
            lblPower.TabIndex = 10;
            lblPower.Text = "Result:";
            // 
            // button4
            // 
            button4.Location = new Point(322, 444);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 9;
            button4.Text = "Power";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(444, 409);
            txtExponent.Margin = new Padding(3, 4, 3, 4);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(120, 27);
            txtExponent.TabIndex = 12;
            txtExponent.Text = "Exponent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtExponent);
            Controls.Add(txtBase);
            Controls.Add(lblPower);
            Controls.Add(button4);
            Controls.Add(txtFibonacciInput);
            Controls.Add(lblFibonacci);
            Controls.Add(textSum);
            Controls.Add(button3);
            Controls.Add(lblSum);
            Controls.Add(button2);
            Controls.Add(lbl);
            Controls.Add(txtInput);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtInput;
        private Label lbl;
        private Label lblSum;
        private Button button2;
        private Label lblFibonacci;
        private TextBox textSum;
        private Button button3;
        private TextBox txtFibonacciInput;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private TextBox txtBase;
        private Label lblPower;
        private Button button4;
        private TextBox txtExponent;
    }
}
