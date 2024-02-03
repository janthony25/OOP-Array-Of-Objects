using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage =
            {
                new Car("Mustang"),
                new Car("BMW"),
                new Car("Mercedes Benz")
            };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }




            Console.ReadKey();
        }
    }

    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}