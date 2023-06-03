using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForCarApp.cs
{
    public class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public DateTime Year { get; set; } // note  
        public string PlateNumber { get; set; }
        public int Age => DateTime.Now.Year - Year.Year; // note

        public Car(string make, string color, string year, string plateNumber)
        {
            Make = make;
            Color = color;
            Year = Convert.ToDateTime(year); // note
            PlateNumber = plateNumber;
        }

        //public Car(string a, string b, string d, string c)
        //{
        //    Make = a;
        //    Color = b;
        //    Year = c;
        //    PlateNumber = d;
        //}


    }
}

