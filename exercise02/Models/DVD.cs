public class DVD : LibraryItem{

    public int Duration {get; set;}

    public DVD(int id, string title, string yearPublished, int duration) : base(id, title, yearPublished){
        Duration = duration;
    }

    public override void PrintDetails(){
        Console.WriteLine($"Id: {Id}, Title: {Title}, Year Published: {YearPublished}, Author: {Duration}");
    }
}