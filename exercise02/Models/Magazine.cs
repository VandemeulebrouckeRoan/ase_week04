public class Magazine : LibraryItem{

    public int IssueNumber {get; set;}

    public Magazine(int id, string title, string yearPublished, int issueNumber) : base(id, title, yearPublished){
        IssueNumber = issueNumber;
    }

    public override void PrintDetails(){
        Console.WriteLine($"Id: {Id}, Title: {Title}, Year Published: {YearPublished}, Author: {IssueNumber}");
    }
}