using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Ebook, {FileSizeMB}MB)";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Duration: {Duration} hours - Narrator: {Narrator}";
            }
        }

        private void ShowBookInfo(Book[] books)
        {
            listBox1.Items.Clear();
            foreach (var book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] myBooks = new Book[]
            {
                new Book { Title = "School For Good And Evil", Author = "Soman Chainani" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Ebook { Title = "Attack on Titan", Author = "Hajime Isayama", FileSizeMB = 1.5 },
                new Textbook { Title = "Math+", Author = "Juan Doe", Subject = "Math" },
                new AudioBook { Title = "James Doe", Author = "Jane Doe", Duration = 15.5, Narrator = "Jake Doe" }
            };

            ShowBookInfo(myBooks);
        }
    }
}
