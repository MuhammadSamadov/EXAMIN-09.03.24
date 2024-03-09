
using MainApp;

var book = new Book();
book.Id=1;
book.Title="Shohnoma";
book.Author="Firdavsi";

var book1 = new Book();
book1.Id=2;
book1.Title="Tojikon";
book1.Author="Bobojon G";

var book2 = new Book();
book2.Id=3;
book2.Title="Gulomon";
book2.Author="Mirzo T";

var book3 = new Book();
book3.Id=4;
book3.Title="Romeo & Jullieata";
book3.Author="Shekspear";

var book4 = new Book();
book4.Id=5;
book4.Title="blablabla";
book4.Author="blablablabla";

var lib= new Library();
lib.AddBook(book);
lib.AddBook(book1);
lib.AddBook(book2);
lib.AddBook(book3);
lib.AddBook(book4);
lib.DeleteBook(book4);
lib.SearchByAuthor("Firdavsi");
lib.SearchByTitle("Tojikon");
foreach (var item in lib.DisplayBooks())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Author);
    System.Console.WriteLine("----------------------");
}
