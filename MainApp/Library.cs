

namespace MainApp;

public class Library : ILibrary
{
     public List<Book> books= new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void DeleteBook(Book id)
    {
        books.Remove(id);
    }
    public List<Book> DisplayBooks()
    {
        return books;
    }
    public void SearchByAuthor(string author)
    {
        books.FindAll(p=>p.Author==author);
        if(books!=null)
        {
            foreach (var item in books)
            {
                Console.WriteLine("Search by Author");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Author);
            }
        }
    }
    public void SearchByTitle(string title)
    {
         books.FindAll(p=>p.Title==title);
        if(books!=null)
        {
            foreach (var item in books)
            {
                Console.WriteLine("Search by Title");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Author);
            }
        }
    }
    public void UpdateBooks(int id)
    {
        books.FirstOrDefault(p=>p.Id==id);
    }

}
