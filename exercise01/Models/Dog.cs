public class Dog : Animal
{
    public string Breed { get; set; }
    public string Sound { get; set; }
    
    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
    
    public void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}