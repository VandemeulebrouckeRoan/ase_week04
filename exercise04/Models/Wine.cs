using Microsoft.VisualBasic;
public enum WineType{Red, White, Rose, Sparkeling}

public class Wine{

    public string Name {set;get;}
    public int YearOfOrigin {set;get;}
    public double Price {set;get;}
    public double PricePerGlass {set;get;}
    public string Country {set;get;}
    public WineType wineType {get;set;}

    public Wine(string name, int yearOfOrigin, double price, double pricePerGlass, string country, WineType winetype){
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        PricePerGlass = pricePerGlass;
        Country = country;
        wineType = wineType;
    }


    public override string ToString()
    {
        return $"Wine: {Name} ({Country})";
    }

}
