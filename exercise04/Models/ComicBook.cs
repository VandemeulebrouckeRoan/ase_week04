public class ComicBook{

    public string Name {set;get;}
    public int YearOfOrigin {set;get;}
    public double Price {set;get;}
    public string Publisher {set; get;}
    public string Author {set; get;}

    public ComicBook(string name, int yearOfOrigin, double price, string publisher, string author){
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        Publisher = publisher;
        Author = author;
    }
    public override string ToString()
    {
        return $"ComicBook: {Name} ({Author})";
    }

}
