using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW060319_Dictionary
{
    class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"Book title is : {Title, 7}, content {Content, 10}, author {Author,10}, category {Category, 10}";
        }

        public int CompareTo(Book other)
        {
            return string.Compare(this.Title, other.Title);
        }
    }

    class BookSortedByAuthor : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return string.Compare(x.Author, y.Author);
        }
    }
}
