using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class FootballGlaves : FootballEquipment
    {
        public FootballGlaves(double Price, int YearOfProduction, string Quality)
        {
            this.Price = Price;
            this.Year = YearOfProduction;
            this.Quality = Quality;
        }
        public override double Price { get; set; }
        public override int Year { get; set; }
        public override string Quality { get; set; }

        public override void ShowInfoAboutGood()
        {
            Console.WriteLine($"Football glaves was create in {Year}, cost: {Price}$ and has quality: {Quality}");
        }
    }
}
