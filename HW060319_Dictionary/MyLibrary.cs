using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW060319_Dictionary
{
    class MyLibrary
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();

        public MyLibrary()
        {
            
        }

        public bool AddBook(Book b)
        {
            //what string to enter as key ?
            if (!books.TryGetValue("", out Book b2))
            {
                books.Add(b.Title, b);
                return true;
            }
            return false;
        }
        public bool RemoveBook(string s)
        {
            if (books.TryGetValue(s, out Book b))
            {
                books.Remove(s);
                return true;
            }
            return false;
        }
        public bool HaveThisBook(string s)
        {
            if (books.TryGetValue(s, out Book b))
            {                
                return true;
            }
            return false;
        }
        public Book GetBook(string s)
        {
            if (books.TryGetValue(s, out Book b))
            {
                return b;
            }
            return null;
        }
        public Book GetBookByAuthor(string s)
        {
            foreach (KeyValuePair<string, Book> b in books)
            {
                if (b.Value.Author == s)
                    return b.Value;
            }
            return null;
        }
        public void Clear()
        {
            books.Clear();            
        }
        public List<string> GetAuthors()
        {
            List<string> AllAuthors = new List<string>();
            foreach (KeyValuePair<string, Book> b in books)
            {
                AllAuthors.Add(b.Value.Author);
            }
            return AllAuthors;
        }
        public List<Book> GetBooksStoredByAuthorName()
        {
            List<Book> booksToSort = new List<Book>();
            
            foreach (KeyValuePair<string, Book> b in books)
            {
                booksToSort.Add(b.Value);
            }
            booksToSort.Sort(new BookSortedByAuthor());
            return booksToSort;
        }
        public List<string> GetBooksTitleStored()
        {
            List<string> booksToSort = new List<string>();

            foreach (KeyValuePair<string, Book> b in books)
            {
                booksToSort.Add(b.Value.Title);
            }
            booksToSort.Sort();
            return booksToSort;
        }
        public int Count
        {
            get
            {
                return books.Count;
            }
            
        }

        public override string ToString()
        {
            string AllBooks = string.Empty;
            foreach (KeyValuePair<string, Book> b in books)
            {
                AllBooks += b.Value.ToString() + "\n";
            }
            return AllBooks;
        }
    }
}
