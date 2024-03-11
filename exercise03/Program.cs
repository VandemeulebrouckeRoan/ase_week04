using System.Runtime.InteropServices;

Car car = new Car(400, "pink", 4);
Boat boat = new Boat(50, "green", "salty");

List<Vehicle> list = new List<Vehicle>();

list.Add(car);
list.Add(boat);

foreach(Vehicle item in list){
    Console.WriteLine(item.DescribeVehicle());
}