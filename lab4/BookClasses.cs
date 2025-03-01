namespace lab4
{
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
}
