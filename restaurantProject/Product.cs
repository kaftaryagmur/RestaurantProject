using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantProject
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string SellByDate { get; set; }
        public int Calorie { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, int stock, string sellByDate, int calorie, decimal price)
        {
            ProductName = productName;
            Stock = stock;
            SellByDate = sellByDate;
            Calorie = calorie;
            Price = price;
        }
    }



}
