using System;

namespace GenericType_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Book kodDaVinci = new Book("KodDaVinci", "DanBrown", 30);
            Book cerpeleng = new Book("CerpelengUchuran", "XalidHuseyni", 100);
            Book kisilerinKitabi = new Book("KishilerinKitabi", "Osho", 60);
            Book kisilerinKitabi2 = new Book("KishilerinKitabi", "GopcchuOsho", 60);
            Library library = new Library();
            library.AddBookToLibrary(kodDaVinci);
            library.AddBookToLibrary(cerpeleng);
            library.AddBookToLibrary(kisilerinKitabi);
            library.AddBookToLibrary(kisilerinKitabi2);

            library.RemoveBookByCode("KO1");

        }
    }
}
