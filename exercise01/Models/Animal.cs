public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    void MakeSound()
    {
        Console.WriteLine("Unknown animal sound");
    }
}