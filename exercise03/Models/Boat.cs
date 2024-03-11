public class Boat : Vehicle{

    public string T_water {get;set;}

    public Boat(int speed, string color, string t_water) : base(speed, color){
        T_water = t_water;
    }

    public override string DescribeVehicle()
    {
        return $"Color: {Color}, speed: {Speed}, type of water: {T_water}";
    }


}