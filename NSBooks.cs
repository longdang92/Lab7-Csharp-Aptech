using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSBooks;
using NSBookTest;

namespace NSBooks
{
    interface IBook
    {
        //Properties
        int ID { get; set; }
        string Name { get; set; }
        DateTime Publishdate { get; set; }
        string Author { get; set; }
        string Language { get; set; }
        float AveragePrice { get; }

        //Indexer
        int this[int index] { get; set; }
        //method
        void Display();
    }

    class Book : IBook
    {
        public string Author
        {
            get
            {
                return Author;
            }

            set
            {
                Author = value;
            }
        }
        public float AveragePrice
        {
            get
            {
                return AveragePrice;
            }
        }
        public int ID
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
        public string Language
        {
            get
            {
                return Language;
            }

            set
            {
                Language = value;
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }
        public DateTime Publishdate
        {
            get
            {
                return Publishdate;
            }

            set
            {
                Publishdate = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}\nPublishDate: {1}\nAuthor: {2}\nLanguage: {3}\nAveragePrice: {4}"
                , Name, Publishdate, Author, Language, AveragePrice);
        }

        public int[] PriceList = new int[5];
        //indexer
        public int this[int index]
        {
            get
            {
                return PriceList[index];
            }
            set
            {
                PriceList[index] = value;
            }
        }
    }

}

namespace NSBookTest
{
    class BookTest
    {
        static void Main(string[] args)
        {
 
 			BookList[] blist = new BookList[5];

            Console.WriteLine("Please select an options:");
            Console.WriteLine("1. Insert new book ...");
            Console.WriteLine("2. View list of book ...");
            Console.WriteLine("3. Average Price ...");
            Console.WriteLine("4. Exit ...");
            Console.WriteLine("Option: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int cid = 0;
            switch (x)
            {
                case 1:
                    blist[cid] = new Book();
                    DateTime dt= new DateTime.Now;
                    Console.WriteLine("Input book's info: ");
                    blist[cid].ID++;
                    Console.WriteLine("Name: ");
                    blist[cid].Name = Console.ReadLine();
                    blist[cid].Publishdate = dt;
                    Console.WriteLine("Author: ");
                    blist[cid].Author = Console.ReadLine();
                    Console.WriteLine("Language: ");
                    blist[cid].Language = Console.ReadLine();
                    cid++;
                    break;
                default:
                    break;
            }
        }
    }
}
