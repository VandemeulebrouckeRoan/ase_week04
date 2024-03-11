public class Book : LibraryItem{

    public string Author {get; set;}

    public Book(int id, string title, string yearPublished, string author) : base(id, title, yearPublished){
        Author = author;
    }

    public override void PrintDetails(){
        Console.WriteLine($"Id: {Id}, Title: {Title}, Year Published: {YearPublished}, Author: {Author}");
    }
}