using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType_List
{
    class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBookToLibrary(Book book)
        {
            Books.Add(book);
        }

        public void FindAllBooksByName(string value)
        {
            var result = Books.FindAll(x => x.Name.ToLower() == value.ToLower());
            if (result.Count == 0)
            {
                Console.WriteLine("Bele bir adda kitab yoxdur");
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.PageCount} {item.Code}");
            }
        
        }
        public void RemoveAllBooksByName(string value)
        {
            var result = Books.RemoveAll(x => x.Name.ToLower() == value.ToLower());
            if (result==0)
            {
                Console.WriteLine("Bele bir adda kitab yoxdur");
            }
            foreach (var item in Books)
            {
                Console.WriteLine($"{item.AuthorName}{item.Code}");
            }
           

        }
        public void SearchBooks(string value)
        {
            var result = Books.FindAll(book => book.AuthorName.ToLower() == value.ToLower() || book.Name.ToLower() == value.ToLower() || book.PageCount.ToString() == value);
            if (result.Count == 0)
            {
                Console.WriteLine("Bele bir deyerde kitab yoxdur");
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}{item.PageCount}{item.Code}");
            }
        }
        public void FindAllBooksByPageCountRange(int min,int max)
        {
            var result = Books.FindAll(x => x.PageCount > min && x.PageCount < max);
            if (result.Count == 0)
            {
                Console.WriteLine("Bu araliqda kitab yoxdur");
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}{item.PageCount}");
            }
        }
        public void RemoveBookByCode(string code)
        {
            var result = Books.Find(x => x.Code == code);
            if (result != null)
            {
                Books.Remove(result);
            }
            foreach (var item in Books)
            {
                Console.WriteLine($"{item.Name}{item.PageCount}{item.Code}");
            }
        }



    }
}
