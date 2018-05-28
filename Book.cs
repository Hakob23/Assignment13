using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13_WCF
{
    public class Book
    {

        public Book(int id, string title, string author, double price, int year)
        {
            Id = id;

            Author = author;

            Title = title;

            Price = price;

            Year = year;

        }

        public int Id { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public int Year { get; set; }


    }
}
