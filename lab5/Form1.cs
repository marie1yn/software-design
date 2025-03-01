using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; } = new List<Book>(); // Initialize collection
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                }

                var book = new Book { Title = bookTitle, Author = author };
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}") // Fixed this line!
                    .ToList();
                return booksWithAuthors;
            }
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim(); // Get author from a TextBox
            string bookTitle = txtBookTitle.Text.Trim();   // Get book title from a TextBox

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please enter both Author and Book Title!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddAuthorWithBook(authorName, bookTitle); // Add the book & author to DB
            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAuthorName.Clear();
            txtBookTitle.Clear();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = null;  // Refresh list
            listBoxBooks.DataSource = books;
        }
        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully.");
        }
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var books = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName)) // Case-insensitive search
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return books;
            }
        }
        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorSearch.Text.Trim();
            if (string.IsNullOrEmpty(authorName))
            {
                MessageBox.Show("Please enter an author name!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var books = SearchBooksByAuthor(authorName);
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;

            if (books.Count == 0)
            {
                MessageBox.Show("No books found for this author.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
