public class Car : Vehicle, IRefuelable{

    public int N_wheels {get;set;}

    public Car(int speed, string color, int n_wheels) : base(speed, color){
        N_wheels = n_wheels;
    }

    public override string DescribeVehicle()
    {
        return $"Color: {Color}, speed: {Speed}, number of wheels: {N_wheels}";
    }

    public void Refuel(){
        Console.WriteLine("Refuling....");
    }
}