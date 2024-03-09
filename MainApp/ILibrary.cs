namespace MainApp;

public interface ILibrary 
{
    public List<Book> DisplayBooks();

    public void AddBook(Book book);
  
    public void UpdateBooks(int id);
    
    public void DeleteBook(Book id);
    public void SearchByTitle(string title);
    public void SearchByAuthor(string author);

}
