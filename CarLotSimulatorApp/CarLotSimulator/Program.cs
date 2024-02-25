using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            

            //Done - Create a seperate class file called Car
            //Done - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var akCar = new Car();
            akCar.Make = "Honda";
            akCar.Model = "Civic";
            akCar.Year = 2012;
            akCar.EngineNoise = "vroom";
            akCar.HonkNoise = "beep";
            akCar.IsDriveable = true;

            lot.Cars.Add(akCar);

            var popiCar = new Car()
            {
                Year = 2019,
                Make = "Chevy",
                Model = "Impala",
                EngineNoise = "broom",
                HonkNoise = "beeeep",
                IsDriveable = true
            };

            lot.Cars.Add(popiCar);

            var januCar = new Car(2013, "Ford", "Focus", "...", "beep beep", false);

            lot.Cars.Add(januCar);


            akCar.MakeEngineNoise();
            popiCar.MakeEngineNoise();
            januCar.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
