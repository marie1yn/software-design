using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab6
{
    public partial class Form1 : Form
    {
        private ProgressBar progressBar;

        public Form1()
        {
            InitializeComponent();
        }
        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value =>
            {
                if (progressBar.InvokeRequired)
                {
                    progressBar.Invoke((MethodInvoker)(() => progressBar.Value = value));
                }
                else
                {
                    progressBar.Value = value;
                }
            });

            var books = await GetBooksAsync(progress);
            listBoxBooks.DataSource = books;

            progressBar.Value = 0; 
        }

        public async Task<List<string>> GetBooksAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author).ToListAsync();
                var bookList = new List<string>();

                for (int i = 0; i < books.Count; i++)
                {
                    bookList.Add($"{books[i].Title} by {books[i].Author.Name}");

                    // Make sure progress is reported correctly
                    progress?.Report((i + 1) * 100 / books.Count);

                    await Task.Delay(100); // Simulate loading
                }

                return bookList;
            }
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                }

                var book = new Book { Title = bookTitle, Author = author };
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;
            await SaveBookAsync(bookTitle, authorName);
            MessageBox.Show("Book and Author saved successfully!");
        }

        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.BookID == bookId);

                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            await UpdateBookAsync(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully.");
        }

        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            await DeleteBookAsync(bookId);
            MessageBox.Show("Book deleted successfully.");
        }

        public async Task<List<string>> SearchBooksAsync(string searchTitle)
        {
            using (var context = new BookstoreContext())
            {
                return await context.Books
                    .Where(b => b.Title.Contains(searchTitle))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
        }

        private async void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearchTitle.Text;
            var books = await SearchBooksAsync(searchTitle);
            listBoxBooks.DataSource = books;
        }
    }
}
