using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab7
{
    public partial class Form1 : Form
    {
        private const int pageSize = 10;
        private int currentPage = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }
        }

        private async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;
            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }

        private async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book); 
                }
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files | *.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }
        }

        private async Task<List<string>> SearchBooksAsync(string searchQuery)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(searchQuery))
                        .OrderBy(b => b.BookID)
                        .Select(b => $"{b.Title} by {b.Author.Name}")
                        .ToListAsync();

                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}");
                return new List<string>(); 
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim(); 
            if (!string.IsNullOrEmpty(searchQuery))
            {
                var books = await SearchBooksAsync(searchQuery);
                listBoxBooks.DataSource = books;

                if (books.Count == 0)
                {
                    MessageBox.Show("No books found!");
                }
            }
        }

        private async Task ImportBooksAsync(string filePath)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var lines = await File.ReadAllLinesAsync(filePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(" by "); 
                        if (parts.Length == 2)
                        {
                            string bookTitle = parts[0].Trim();
                            string authorName = parts[1].Trim();

                            var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                            if (author == null)
                            {
                                author = new Author { Name = authorName };
                                context.Authors.Add(author);
                            }

                            var book = new Book { Title = bookTitle, Author = author };
                            context.Books.Add(book);
                        }
                    }
                    await context.SaveChangesAsync();
                    MessageBox.Show("Books imported successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during import: {ex.Message}");
            }
        }

        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files | *.txt",
                Title = "Select Book List File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                await ImportBooksAsync(filePath);
            }
        }
    }
}
