using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static BookContext bc = new BookContext();
        static void ShowBooks()
        {
            var book = from b in bc.Books
                       select b;

            foreach (var item in book)
            {
                Console.WriteLine(item.BookId + " " + item.BookName);
            }
        }

        static void UpdateBooks(Book bkobj)
        {
            var bk = bc.Books.FirstOrDefault(b => b.BookId == bkobj.BookId);

            bk.BookName = "My New Book";
            bc.SaveChanges();
            //for delete
            //bc.Books.Remove(bk);
            //bc.SaveChanges();       

        }
        
        static void Main(string[] args)
        {
            ShowBooks();
            Console.WriteLine("----------------");
            Book mybook = new Book() { BookId = 2 };
            UpdateBooks(mybook);
           
            //Callproc();
            using (var db = new BookContext())
            {
                db.Books.Add(new Book { BookName = "Introduction to EF" });
                db.SaveChanges();

                //    foreach(var bk in db.Books)
                //    {
                //        Console.WriteLine(bk.BookId + " "+ bk.BookName);
                //    }
                //}                
            }
            Console.WriteLine("-----------------");
            ShowBooks();
            Console.Read();
        }
    }
}
