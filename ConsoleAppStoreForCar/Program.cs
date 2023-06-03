using ClassLibraryForCarApp;
using ClassLibraryForCarApp.cs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppStoreForCar
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store. First you must creat some car inventory.  Then you may add some car to the shopping cart.  Finally you may add the return details of the car when the plate number of the car is supplied. ");

            /* int action = ChooseAction();

             while (action != 0)
             {
                 Console.WriteLine("You chose" + action);
             */


            Car c = new Car(" Nissan ", "Color Red", "05/05/2005", "A567FQ788");
            Car d = new Car(" Ford ", "Color Black", "05/24/2002", "G983YZ228");
            Car e = new Car(" Chevrolet ", " Color Grey", "05/05/2005", "E332DL487");
            Car f = new Car(" BMW ", " Color Red", "02/07/1999", "C662DL487");
            Car g = new Car(" Acura ", " Color White", "05/05/2005", "L632DL555");
            Car h = new Car(" Lada ", " Color White", "05/04/2015", "MY669T663");
            Car i = new Car(" Audi ", " Color Black", "05/05/2005", "W009TY755");
            Car j = new Car(" Bentley ", " Color Red", "05/05/2005", "T789YU567");
            Car k = new Car(" Mercedes ", " Color White", "05/05/2022", "Q543HY560");
            Car l = new Car(" Cadillac ", " Color Black", "05/09/2000", "W455OP889");
            Car m = new Car(" Buick ", " Color White", "05/05/2005", "E689RI593");
            Car n = new Car(" Alfa ", " Color White", "05/05/2005", "D489JT879");

            //Console.WriteLine("Car is as follow" + c.Make + " " + c.Color + " " + Convert.ToDateTime(c.Year).Year + " " + c.PlateNumber);
            //Console.WriteLine("Car is as follow" + d.Make + " " + d.Color + " " + Convert.ToDateTime(d.Year).Year + " " + d.PlateNumber);
            //Console.WriteLine("Car is as follow" + e.Make + " " + e.Color + " " + Convert.ToDateTime(e.Year).Year + " " + e.PlateNumber);
            //Console.WriteLine("Car is as follow" + f.Make + " " + f.Color + " " + Convert.ToDateTime(f.Year).Year + " " + f.PlateNumber);
            //Console.WriteLine("Car is as follow" + g.Make + " " + g.Color + " " + Convert.ToDateTime(g.Year).Year + " " + g.PlateNumber);
            //Console.WriteLine("Car is as follow" + h.Make + " " + h.Color + " " + Convert.ToDateTime(h.Year).Year + " " + h.PlateNumber);
            //Console.WriteLine("Car is as follow" + i.Make + " " + i.Color + " " + Convert.ToDateTime(i.Year).Year + " " + i.PlateNumber);
            //Console.WriteLine("Car is as follow" + j.Make + " " + j.Color + " " + Convert.ToDateTime(j.Year).Year + " " + j.PlateNumber);
            //Console.WriteLine("Car is as follow" + k.Make + " " + k.Color + " " + Convert.ToDateTime(k.Year).Year + " " + k.PlateNumber);
            //Console.WriteLine("Car is as follow" + l.Make + " " + l.Color + " " + Convert.ToDateTime(l.Year).Year + " " + l.PlateNumber);
            //Console.WriteLine("Car is as follow" + m.Make + " " + m.Color + " " + Convert.ToDateTime(m.Year).Year + " " + m.PlateNumber);
            //Console.WriteLine("Car is as follow" + n.Make + " " + n.Color + " " + Convert.ToDateTime(n.Year).Year + " " + n.PlateNumber);


            List<Car> CarList = new List<Car>();
            CarList.Add(c);
            CarList.Add(d);
            CarList.Add(e);
            CarList.Add(f);
            CarList.Add(g);
            CarList.Add(h);
            CarList.Add(i);
            CarList.Add(j);
            CarList.Add(k);
            CarList.Add(l);
            CarList.Add(m);
            CarList.Add(n);

            //Store s = new Store();

            //    s.ShoppingList.Add(c);
            //    s.ShoppingList.Add(d);
            //    s.ShoppingList.Add(e);


            do
            {
                Console.WriteLine("");
                Console.WriteLine("Commands: l (list all cars, note use a lower case value), f (find a car, note use a lower case value)");
                Console.Write("> ");
                var  command = Console.ReadLine();   
                switch (command) 
                {
                    case "l":
                        ListAllCars(CarList);
                        break;
                    case "f":
                        FindCarByPlateNumber(CarList); 
                        break;
                    default:
                        Console.WriteLine("Unknow command.");
                        break;
                }

            } while (true);
        }

        public static void FindCarByPlateNumber(List<Car> listOfCars)
        {
            Console.WriteLine("Enter plate number");
            Console.Write("> ");
            string plateNumberToFind = Console.ReadLine();
            var car = listOfCars.FirstOrDefault(x => x.PlateNumber == plateNumberToFind);
            if (car == null)
            {
                Console.WriteLine($"Car with plate number {plateNumberToFind} not found");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"color -- {car.Color}");
                Console.WriteLine($"make -- {car.Make}");
                Console.WriteLine($"age -- {car.Age}");
                Console.WriteLine($"plateNumber -- {car.PlateNumber}");
                Console.WriteLine($"year -- {car.Year.Year}");
            }
        }

        public static void ListAllCars(List<Car> carList)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine($"---------{i + 1} ---------");
                Console.WriteLine($"color -- {carList[i].Color}");
                Console.WriteLine($"make -- {carList[i].Make}");
                Console.WriteLine($"age -- {carList[i].Age}");
                Console.WriteLine($"plateNumber -- {carList[i].PlateNumber}");
                Console.WriteLine($"year -- {carList[i].Year.Year}");
            }
        }

        public static int ChooseAction()
        {
            Console.WriteLine("choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");
            return 1;

        }

    } 
}

