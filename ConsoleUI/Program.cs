using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            var vehicles = new List<Vehicle>();

            Car corolla = new Car()
            {
                HasTrunk = true,
                Year = "2003",
                Make = "Toyota",
                Model = "Corolla"
            };
            Motorcycle dyna = new Motorcycle()
            {
                HasSideCart = true,
                Year = "1996",
                Make = "Harley",
                Model = "Dyna Wide Glide"

            };
            Vehicle tacoma = new Car()
            {
                HasTrunk = false,
                Year = "2001",
                Make = "Toyota",
                Model = "Tacoma"
            };
            Vehicle vstrom = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2022",
                Make = "Suzuki",
                Model = "V-strom 650"
            };

            vehicles.Add(corolla);
            vehicles.Add(dyna);
            vehicles.Add(tacoma);
            vehicles.Add(vstrom);

            foreach (var car in vehicles)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                car.DriveAbstract();
                car.DriveVirtual();
                Console.WriteLine();
            }
            #endregion            
            Console.ReadLine();
        }
    }
}
