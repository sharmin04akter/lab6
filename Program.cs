using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6



{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Student s1 = new Student();
            s1.Name = "Sharmin";
            s1.Id = "17-33604-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.64f;
            Student s2 = new Student("Arpita", "16-34790-2", "EEE",3.6f);

            Student s3 = new Student("Ornithin", "17-22504-1", "CSE",3.89f);

            //s1.showInfo();

            Book b1 = new Book("book1Name", "book1Author", "2324", "Thriller", 3);
            Book b2 = new Book("book2Name", "book2Author", "4597", "Commic", 5);
            Book b3 = new Book("book3Name", "book3Author", "9023", "Horror", 2);
            Book b4 = new Book("book4Name", "book4Author", "5675", "Romantic", 4);
            Book b5 = new Book("book5Name", "book5Author", "3471", "Science Fiction", 3);
            Book b6 = new Book("book6Name", "book6Author", "2665", "Thriller", 2);


            s1.BorrowedBook = new Book[] { b1, b2 };
            s2.BorrowedBook = new Book[] { b3, b4, b5 };
            s3.BorrowedBook = new Book[] { b2, b6 };
            //s1.BorrowedBookCount = borrowedBook.Length;

            //s1.showBorrowedBookInfo();

            Library library = new Library("BookHouse", "Kuratoli", new Book[] { b1, b2, b3, b4, b5, b6 }, 6);

            library.showAllBooks();
        }
    }
}