namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnShowBooks = new Button();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnSearchBooks = new Button();
            txtAuthorSearch = new TextBox();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(68, 48);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 0;
            txtAuthorName.Text = "Author";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(68, 96);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 1;
            txtBookTitle.Text = "Book";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(83, 156);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(235, 88);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(535, 324);
            listBoxBooks.TabIndex = 3;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(68, 383);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(125, 29);
            btnShowBooks.TabIndex = 4;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(68, 216);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 5;
            txtBookID.Text = "BookID";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(83, 270);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 29);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(83, 305);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 29);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(635, 47);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(135, 29);
            btnSearchBooks.TabIndex = 9;
            btnSearchBooks.Text = "Search";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // txtAuthorSearch
            // 
            txtAuthorSearch.Location = new Point(235, 48);
            txtAuthorSearch.Name = "txtAuthorSearch";
            txtAuthorSearch.Size = new Size(394, 27);
            txtAuthorSearch.TabIndex = 8;
            txtAuthorSearch.Text = "Search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchBooks);
            Controls.Add(txtAuthorSearch);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnShowBooks;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnSearchBooks;
        private TextBox txtAuthorSearch;
    }
}
