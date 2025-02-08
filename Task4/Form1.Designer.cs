namespace Task4
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
            listBoxResult = new ListBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 20;
            listBoxResult.Location = new Point(257, 13);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(532, 424);
            listBoxResult.TabIndex = 3;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(12, 13);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(238, 101);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResult);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResult;
        private Button btnSort;
    }
}