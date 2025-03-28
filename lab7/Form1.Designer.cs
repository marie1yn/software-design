namespace lab7
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
            lblPageNumber = new Label();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            listBoxBooks = new ListBox();
            btnSearchBook = new Button();
            txtSearch = new TextBox();
            btnImportBooks = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(466, 526);
            lblPageNumber.Margin = new Padding(4, 0, 4, 0);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(59, 25);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "label1";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(46, 511);
            btnPreviousPage.Margin = new Padding(4, 4, 4, 4);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(118, 36);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(850, 511);
            btnNextPage.Margin = new Padding(4, 4, 4, 4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(118, 36);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(36, 155);
            txtBookTitle.Margin = new Padding(4, 4, 4, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(308, 31);
            txtBookTitle.TabIndex = 6;
            txtBookTitle.Text = "Book Title";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(36, 91);
            txtAuthorName.Margin = new Padding(4, 4, 4, 4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(308, 31);
            txtAuthorName.TabIndex = 5;
            txtAuthorName.Text = "Author Name";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 25;
            listBoxBooks.Location = new Point(379, 141);
            listBoxBooks.Margin = new Padding(4, 4, 4, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(585, 329);
            listBoxBooks.TabIndex = 4;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(818, 89);
            btnSearchBook.Margin = new Padding(4, 4, 4, 4);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(148, 36);
            btnSearchBook.TabIndex = 12;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(379, 91);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 31);
            txtSearch.TabIndex = 11;
            txtSearch.Text = "Search";
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(108, 242);
            btnImportBooks.Margin = new Padding(4, 4, 4, 4);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(148, 36);
            btnImportBooks.TabIndex = 13;
            btnImportBooks.Text = "Add Book";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnAddBook_Click;
            // 
            // button1
            // 
            button1.Location = new Point(108, 391);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(148, 36);
            button1.TabIndex = 14;
            button1.Text = "Import Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnImportBooks_Click;
            // 
            // button2
            // 
            button2.Location = new Point(108, 435);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(148, 36);
            button2.TabIndex = 15;
            button2.Text = "Export Books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnExportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnImportBooks);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearch);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(lblPageNumber);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private ListBox listBoxBooks;
        private Button btnSearchBook;
        private TextBox txtSearch;
        private Button btnImportBooks;
        private Button button1;
        private Button button2;
    }
}
