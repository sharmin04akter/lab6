using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6

{
    public class Library
    {
        private String libName;
        private String libAddress;
        private Book[] listOfBook;
        private int totalBook;
        private Student[] libMembers;
        private Account libAccount;


        public String LibName { get { return libName; } set { libName = value; } }
        public String LibAddress { get { return libAddress; } set { libAddress = value; } }
        public Book[] ListOfBook { get { return listOfBook; } set { listOfBook = value; } }
        public int TotalBook { get { return totalBook; } set { totalBook = value; } }
        public Student[] LibMembers { get { return libMembers; } set { libMembers = value; } }
        public Account LibAccount { get => libAccount; set => libAccount = value; }

        public Library()
        {
        }

        public Library(String libName, String libAddress, Book[] listOfBook, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.listOfBook = listOfBook;
            this.totalBook = totalBook;
        }

        public void showLibInfo()
        {
            Console.WriteLine("Library Name : " + this.libName);
            Console.WriteLine("Library Address : " + this.libName);
            Console.WriteLine("Total Number of Books : " + this.totalBook);
        }

        public void showAllBooks()
        {
            for (int i = 0; i < totalBook; i++)
            {
                listOfBook[i].showInfo();
                Console.WriteLine();
            }
        }

        public void addNewBook(Book book)
        {
            listOfBook[totalBook++] = book;
        }

        public void deleteBook(Book book)
        {
            int i = 0;

            for (i = 0; i < totalBook; i++)
            {
                if (listOfBook[i] == book)
                {
                    listOfBook[i] = null;
                    break;
                }
            }

            if (i < totalBook)
            {
                for (int j = i; j < totalBook - 1; ++j)
                {
                    listOfBook[j] = listOfBook[j + 1];
                }
            }

        }

        public void addNewBookCopy(Book book, int copy)
        {
            int i = 0;

            for (i = 0; i < totalBook; i++)
            {
                if (listOfBook[i] == book)
                {
                    listOfBook[i] = null;
                    break;
                }
            }

            if (i < totalBook)
            {
                listOfBook[i].addBookCopy(copy);
            }

        }

        public void showAllBorrowInfo()
        {
            for (int i = 0; i < libMembers.Length; i++)
            {
                libMembers[i].showInfo();
                libMembers[i].showBorrowedBookInfo();
            }
        }
    }
}
