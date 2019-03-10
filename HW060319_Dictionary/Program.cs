using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW060319_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary myLibrary = new MyLibrary();
            myLibrary.AddBook(new Book("Tanya", "Remez", "R_ShneyOr", "Ktav"));
            myLibrary.AddBook(new Book("Shmot", "Pshat", "Moshe", "Humash"));
            myLibrary.AddBook(new Book("Tora Or", "Kabala", "AriZal", "Hasiduth"));
            
            Console.WriteLine(myLibrary);
            Console.WriteLine("===============");
            Console.WriteLine(myLibrary.GetBook("Shmot"));
            Console.WriteLine("===============");
            List<string> BooksByTitleName = myLibrary.GetBooksTitleStored();
            BooksByTitleName.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("===============");
            List<Book> BooksByAuthorName = myLibrary.GetBooksStoredByAuthorName();
            BooksByAuthorName.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("===============");
            Console.WriteLine($"Do we have the book Vayikra: {myLibrary.RemoveBook("Vayikra")}.");

            Console.ReadKey();
        }
    }
}
