using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType_List
{
    class Book
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book(string name,string authorName,int pageCount)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = Name.Substring(0, 2).ToUpper() + Id;
        }
    }
}
