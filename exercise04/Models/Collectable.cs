public abstract class Collectable{

    public string Name {get;set;}

    public int YearOfOrigin {get;set;}

    public double Price {get;set;}

    public Collectable(string name, int yearOfOrigin, double price){
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
    }
}