using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class Vitamin : FoodAdditives
    {
        public Vitamin(double Price)
        {
            this.Price = Price;
        }
        public override double Price { get; set; }
        public override void ShowInfoAboutAdditive()
        {
            Console.WriteLine($"Food supplement cost: {Price}$");
        }
    }
}
