using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can create 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            
            //car #1
            Car myfirstCar = new Car();
            myfirstCar.Make = "Audi";
            myfirstCar.Model = "Q7";
            myfirstCar.Year = 2021;
            myfirstCar.EngineNoise = "medium";
            myfirstCar.HonkNoise = "soft";
            myfirstCar.IsDriveable = true;

            myfirstCar.Type();
            myfirstCar.MakeEngineNoise();
            myfirstCar.MakeHonkNoise();
            myfirstCar.MakeIsDriveable();
            
            
            //Car #2
            var mysecondCar = new Car()
            {
                Make = "Ford",
                Model = "Mustang",
                Year = 2022,
                EngineNoise = "medium",
                HonkNoise = "medium",
                IsDriveable = true

            };
            
            mysecondCar.Type();
            mysecondCar.MakeEngineNoise();
            mysecondCar.MakeHonkNoise();
            mysecondCar.MakeIsDriveable();
            
            
            //Car #3

            var mythirdCar = new Car()
            {
                Make = "Nissan",
                Model = "GTR",
                Year = 2023,
                EngineNoise = "loud",
                HonkNoise = "very loud",
                IsDriveable = true

            };
            
            mythirdCar.Type();
            mythirdCar.MakeEngineNoise();
            mythirdCar.MakeHonkNoise();
            mythirdCar.MakeIsDriveable();
            
            
            



            

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
