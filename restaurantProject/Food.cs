using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantProject
{
     public class Food
    {
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public float FoodPrice { get; set; }
        public string FoodTaxPercent { get; set; }
    }
    public class MainDish : Food
    {
    }

    public class MeatDish : Food
    {
    }

    public class VegetableDish : Food
    {
    }

    public class SideDish : Food
    {
    }

    public class Drink : Food
    {
    }

    public class Dessert : Food
    {
    }

    public class Soup : Food
    {
    }

}
