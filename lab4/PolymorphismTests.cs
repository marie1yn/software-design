using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab4; 

namespace lab4.Tests
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "School For Good And Evil", Author = "Soman Chainani" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Ebook { Title = "Attack on Titan", Author = "Hajime Isayama", FileSizeMB = 1.5 }
            };

            Assert.AreEqual("School For Good And Evil by Soman Chainani", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 45", books[1].GetInfo());
            Assert.AreEqual("Attack on Titan (Ebook, 1.5MB)", books[2].GetInfo());
        }

        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "School For Good And Evil", Author = "Soman Chainani" };
            Assert.AreEqual("School For Good And Evil", book.Title);
            Assert.AreEqual("Soman Chainani", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(45, magazine.IssueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = -1 };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTextbookCreation()
        {
            Textbook textbook = new Textbook { Title = "Math+", Author = "Juan Doe", Subject = "" };
        }
    }
}
