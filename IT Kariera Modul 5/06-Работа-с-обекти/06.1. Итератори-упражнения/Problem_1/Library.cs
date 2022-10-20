using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library : IEnumerable<Book>
    {
        private List<Book> Books { get; set; }
        public Library(params Book[] book)
        {
            Books = new List<Book>(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryInterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
