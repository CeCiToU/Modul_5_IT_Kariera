using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class LibraryInterator : IEnumerator<Book>
    {
        private IReadOnlyList<Book> books;
        int index;
        public LibraryInterator(IReadOnlyList<Book> books)
        {
            this.books = books;
            Reset();
        }

        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            index++;
            return index < books.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
