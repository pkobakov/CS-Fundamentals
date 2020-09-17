using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var car = Console.ReadLine().Split('|');
                string model = car[0];
                int mileage = int.Parse(car[1]);
                int startingFuel = int.Parse(car[2]);

                Car currentCar = new Car(model, mileage, startingFuel);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {

                var commandArgs = command.Split(" : ");
                string operation = commandArgs[0];
                string model = commandArgs[1];

                switch (operation)
                {

                    case "Drive":
                        
                        int distance = int.Parse(commandArgs[2]);
                        int fuel = int.Parse(commandArgs[3]);

                        foreach ( var car in cars)
                        {
                            if (car.Model == model)
                            {
                                if (car.StartingFuel < fuel)
                                {
                                    Console.WriteLine("Not enough fuel to make that ride");
                                    break;
                                }

                                else
                                {
                                    car.Mileage += distance;
                                    car.StartingFuel -= fuel;

                                    Console.WriteLine($"{model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                                    if (car.Mileage>=100000)
                                    {
                                        Console.WriteLine($"Time to sell the {model}!");
                                        cars.Remove(car);
                                        break;
                                    }
                                        
                                }
                                
                            }
                        }

                        break;
                        
                    case "Refuel":
                        model = commandArgs[1];
                        fuel = int.Parse(commandArgs[2]);

                        foreach (var car in cars)
                        {
                            if (car.Model == model)
                            {
                                

                                if (car.StartingFuel + fuel > 75)
                                {
                                    int filled = 75 - ((car.StartingFuel+fuel) - fuel);
                                    car.StartingFuel += filled;

                                    Console.WriteLine($"{model} refueled with {filled} liters");
                                    continue;
                                }

                                else
                                {
                                    car.StartingFuel += fuel;

                                    Console.WriteLine($"{model} refueled with {fuel} liters");
                                }
                            }
                        }


                        break;

                    case "Revert":
                        model = commandArgs[1];
                        int mileage = int.Parse(commandArgs[2]);

                        foreach (var car in cars)
                        {
                            if (car.Model == model)
                            {
                                car.Mileage -= mileage;

                                if (car.Mileage>=10000)
                                {
                                    Console.WriteLine($"{model} mileage decreased by {mileage} kilometers");
                                    continue;
                                }

                                else
                                {
                                    car.Mileage = 10000;

                                }
                            }
                               
                        }

                        break;
                }

               command = Console.ReadLine();
            }

            foreach (var car in cars.OrderByDescending(x=>x.Mileage).ThenBy(x=>x.Model))
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.StartingFuel} lt.");
            }
        }
    }

    public class Car 
    {
    public string Model { get; set; }    
    public int Mileage { get; set; }
    public int StartingFuel { get; set; }

        public Car(string model, int mileage, int fuel) 
        {
            Model = model;
            Mileage = mileage;
            StartingFuel = fuel ;
        }
    }
}
