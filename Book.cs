using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6

{
    public class Book
    {
        private String bookName;
        private String bookAuthor;
        private String bookId;
        private String bookType;
        private int bookCopy;

        public String BookName { get { return bookName; } set { bookName = value; } }
        public String BookAuthor { get { return bookAuthor; } set { bookAuthor = value; } }
        public String BookId { get { return bookId; } set { bookId = value; } }
        public String BookType { get { return bookType; } set { bookType = value; } }
        public int BookCopy { get { return BookCopy; } set { bookCopy = value; } }



        public Book()
        {
        }

        public Book(String bookName, String bookAuthor, String bookId, String bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }

        public void showInfo()
        {
            Console.WriteLine("Book Name : " + this.bookName);
            Console.WriteLine("Book Auhtor : " + this.bookAuthor);
            Console.WriteLine("Book ID : " + this.bookId);
            Console.WriteLine("Book Type : " + this.bookType);
            Console.WriteLine("Book Copy : " + this.bookCopy);
        }

        public void addBookCopy(int x)
        {
            this.bookCopy += x;
        }
    }
}
