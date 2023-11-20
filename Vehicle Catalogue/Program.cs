
namespace Vehicle_Catalogue
{
    internal class Program
    {
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }

        public class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }

        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];

                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = int.Parse(data[3])
                    };
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = int.Parse(data[3])
                    };
                    catalog.Trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderCar = catalog.Cars.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderTruck = catalog.Trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
