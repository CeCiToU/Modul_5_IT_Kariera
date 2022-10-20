using System.Collections.Generic;

namespace Library
{
    internal class Book
    {
        public Book(string title, int year, params string[] author)
        {
            Title = title;
            Authors = new List<string>(author);
            Year = year;
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
    }
}