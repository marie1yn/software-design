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
            lblPageNumber.Location = new Point(373, 421);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(50, 20);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "label1";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(37, 409);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(680, 409);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(29, 124);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(247, 27);
            txtBookTitle.TabIndex = 6;
            txtBookTitle.Text = "Book Title";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(29, 73);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(247, 27);
            txtAuthorName.TabIndex = 5;
            txtAuthorName.Text = "Author Name";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(303, 113);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(469, 264);
            listBoxBooks.TabIndex = 4;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(654, 71);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(118, 29);
            btnSearchBook.TabIndex = 12;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(303, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 27);
            txtSearch.TabIndex = 11;
            txtSearch.Text = "Search";
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(86, 194);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(118, 29);
            btnImportBooks.TabIndex = 13;
            btnImportBooks.Text = "Add Book";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnAddBook_Click;
            // 
            // button1
            // 
            button1.Location = new Point(86, 313);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 14;
            button1.Text = "Import Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnImportBooks_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 348);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 15;
            button2.Text = "Export Books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnImportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
