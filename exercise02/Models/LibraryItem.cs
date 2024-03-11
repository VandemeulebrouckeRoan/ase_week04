public class LibraryItem
{

    public int Id { get; set; }
    public string Title { get; set; }
    public string YearPublished { get; set; }

    public LibraryItem(int id, string title, string yearPublished){
        Id = id;
        Title = title;
        YearPublished = yearPublished;
    }

    public virtual void PrintDetails(){
        Console.WriteLine($"Id: {Id}, Title: {Title}, Year Published: {YearPublished}");
    }



}