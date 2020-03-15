using System;
using System.Collections.Generic;
using System.Linq;

namespace vehicleCatalogueLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = inputArgs[0];
                string model = inputArgs[1];
                string color = inputArgs[2];
                int horsepower = int.Parse(inputArgs[3]);

                if (typeOfVehicle == "car")
                {
                    Car car = new Car(model, color, horsepower);

                    cars.Add(car);
                }

                else if (typeOfVehicle == "truck")
                {
                    Truck truck = new Truck(model, color, horsepower);

                    trucks.Add(truck);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }
                string model = input;

                if (cars.Any(x => x.Model == model))
                {
                    var currentCar = cars.FirstOrDefault(x => x.Model == model);
                    Console.WriteLine($"Type: Car" + Environment.NewLine
                               + $"Model: {currentCar.Model}" + Environment.NewLine
                               + $"Color: {currentCar.Color}" + Environment.NewLine
                               + $"Horsepower: {currentCar.Horsepower}");
                }

                else if (trucks.Any(x => x.Model == model))
                {
                    var currentTruck = trucks.FirstOrDefault(x => x.Model == model);
                    Console.WriteLine($"Type: Truck" + Environment.NewLine
                               + $"Model: {currentTruck.Model}" + Environment.NewLine
                               + $"Color: {currentTruck.Color}" + Environment.NewLine
                               + $"Horsepower: {currentTruck.Horsepower}");
                }
            }
            if (cars.Any())
            {
            Console.WriteLine($"Cars have average horsepower of: " +
                $"{cars.Average(x => x.Horsepower):F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (trucks.Any())
            {
            Console.WriteLine($"Trucks have average horsepower of: " +
                $"{trucks.Average(x => x.Horsepower):F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
