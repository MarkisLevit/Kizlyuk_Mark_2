using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasketballBall basketballBall1 = new BasketballBall(430, 2020, "avarage");
            FootballBall footballBall = new FootballBall(90, 2010, "bad");
            FootballBall footballTrainers = new FootballBall(30, 2009, "bad");
            FootballBoots footballBoots = new FootballBoots(1000, 2022, "good");
            BasketballBall basketballBall2 = new BasketballBall(700, 2021, "good");
            BasketballTrainers basketballTrainers = new BasketballTrainers(790, 2016, "awarage");
            FootballGlaves footballGlaves = new FootballGlaves(200, 2017, "awarage");
            SportShop sportShop = new SportShop(footballTrainers, footballGlaves, basketballTrainers, footballBoots, footballBall, basketballBall1, basketballBall2);
            Console.WriteLine();
            sportShop.SortByType();
            sportShop.ShowInfo();
            Console.WriteLine();
            sportShop.SortBySeason();
            sportShop.ShowInfo();
            Console.WriteLine();
            List<SportEquipment> arr = new List<SportEquipment>()
            {footballTrainers, footballGlaves, basketballTrainers, footballBoots, footballBall, basketballBall1, basketballBall2};
            arr.Sort();
            foreach (SportEquipment equip in arr)
            {
                Console.WriteLine(equip.ToString());
            }
            Console.WriteLine();
            BAS bas1 = new BAS(120);
            BAS bas2 = new BAS(60);
            BAS bas3 = new BAS(30);
            Vitamin vitamin1 = new Vitamin(33);
            Vitamin vitamin2 = new Vitamin(66);
            Vitamin vitamin3 = new Vitamin(99);
            SportShop.FindFoodAdditives(60, 100, bas1, bas2, bas3, vitamin1, vitamin2, vitamin3);
        }
    }
}
