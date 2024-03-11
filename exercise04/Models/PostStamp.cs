public class PostStamp{

    public string Name {set;get;}
    public int YearOfOrigin {set;get;}
    public double Price {set;get;}
    public string Image {set; get;}

    public PostStamp(string name, int yearOfOrigin, double price, string image){
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        Image = image;

    }
    public override string ToString()
    {
        return $"Poststamp: {Name}";
    }

}
