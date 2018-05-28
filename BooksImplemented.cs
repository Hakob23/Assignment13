using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment13_WCF
{
    
    public class BooksImplemented : IBooks
    {
        public List<Book> Books;

        public void ShowLibrary()
        {
            foreach(Book b in Books)
            {
                Console.Write(b.Id);

                Console.Write(b.Title);

                Console.Write(b.Author);

                Console.Write(b.Year);

                Console.Write(b.Price);

                Console.WriteLine();
            }
        }

        public void ShowBook(int id)
        {
            foreach (Book b in Books)
            {
                if (b.Id == id)
                {
                    Console.WriteLine(b.Id);

                    Console.WriteLine(b.Title);

                    Console.WriteLine(b.Author);

                    Console.WriteLine(b.Year);

                    Console.WriteLine(b.Price);

                    Console.WriteLine();

                    break;
                }
            }
        }

        public void Add(int id, string title, string author, double Price, int year)
        {
            Book book = new Book(id, title, author, Price, year);

            Books.Add(book);
        }

        public void Update(int id, int newId)
        {
            foreach(Book b in Books)
            {
                if(b.Id == id)
                {
                    b.Id = newId;

                    break;
                }
            }
        }

   
    }
}
