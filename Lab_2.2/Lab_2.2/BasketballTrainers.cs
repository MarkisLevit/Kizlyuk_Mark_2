using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class BasketballTrainers : BasketballEquipment
    {
        public BasketballTrainers(double Price, int Year, string Quality)
        {
            this.Price = Price;
            this.Year = Year;
            this.Quality = Quality;
        }
        public override double Price { get; set; }
        public override int Year { get; set; }
        public override string Quality { get; set; }

        public override void ShowInfoAboutGood()
        {
            Console.WriteLine($"Basketball trainers was create in {Year}, cost: {Price}$ and has quality: {Quality}");
        }
    }
}
