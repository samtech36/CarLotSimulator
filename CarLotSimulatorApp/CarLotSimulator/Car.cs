using System;

namespace CarLotSimulator;

public class Car
{
    
    //Create a separate class file called Car (DONE)
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    
    
    
    //properties of a car
    
    public string Make { get; set; }
    
    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public string EngineNoise { get; set; }
    
    public string HonkNoise { get; set; }
    
    public bool IsDriveable { get; set; }
    
    
    //methods for the car simulator
    
    public void Type()
    {
        Console.WriteLine($"The Car i have is a {Year} {Make} {Model}.");
    }
    

    public void MakeEngineNoise()
    {
        Console.WriteLine($"The engine noise is {EngineNoise}.");
        
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine($"The honk noise is {HonkNoise} enough.");
        
    }

    public void MakeIsDriveable()
    {
        Console.WriteLine($"it is {IsDriveable} that the car is drivable after testing the engine.");
    }
    
    
    
}