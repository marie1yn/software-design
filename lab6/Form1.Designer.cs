namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            txtSearchTitle = new TextBox();
            progressBar = new ProgressBar();
            btnSearchBook = new Button();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(33, 383);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(247, 29);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(307, 101);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(469, 264);
            listBoxBooks.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(33, 61);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(247, 27);
            txtAuthorName.TabIndex = 2;
            txtAuthorName.Text = "Author Name";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(33, 112);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(247, 27);
            txtBookTitle.TabIndex = 3;
            txtBookTitle.Text = "Book Title";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(91, 170);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(118, 29);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(33, 233);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(247, 27);
            txtBookID.TabIndex = 5;
            txtBookID.Text = "Book ID";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(91, 285);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(118, 29);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(91, 336);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(118, 29);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(307, 61);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(316, 27);
            txtSearchTitle.TabIndex = 8;
            txtSearchTitle.Text = "Search";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(307, 383);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(469, 29);
            progressBar.TabIndex = 9;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(658, 59);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(118, 29);
            btnSearchBook.TabIndex = 10;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchBook);
            Controls.Add(progressBar);
            Controls.Add(txtSearchTitle);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private TextBox txtSearchTitle;
        private Button btnSearchBook;
    }
}
