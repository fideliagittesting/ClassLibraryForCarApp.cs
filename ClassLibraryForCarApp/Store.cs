using ClassLibraryForCarApp.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForCarApp
{
    public class Store 
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

       
        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public Store(List<Car> carList, List<Car> shoppingList)
        {
            CarList = carList;
            ShoppingList = shoppingList;
        }

        //public decimal Checkout
        //{
        //    get
        //    {
        //        // initialize the total cost
        //        decimal totalCost = 0;

        //        foreach (var d in ShoppingList)
        //        {
        //            totalCost = totalCost + d.PlateNumber;
        //        }

        //        ShoppingList.Clear();

        //        return totalCost;
        //    }

       // }

    }
}
