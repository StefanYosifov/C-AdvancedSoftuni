using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books=new List<Book>();
        public Library(List<Book> books)
        {
            this.books = books;
        }
        public IEnumerator<Book> GetEnumerator()
        {
            for(int i = 0; i < books.Count; i++)
            {
                //Console.WriteLine(books[i]);
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
