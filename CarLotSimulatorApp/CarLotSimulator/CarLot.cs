using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public static int numberofcars;
    
    public List<Car> ListOfCars { get; set; } = new List<Car>();

    public void PrintCars()
    {
        Console.WriteLine("The cars in my lot: ");

        foreach (var car in ListOfCars)
        {
            Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
        }
    }
    
    
    
}