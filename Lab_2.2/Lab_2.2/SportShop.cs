using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    internal class SportShop 
    {
        SportEquipment[] sportEquipment;
        public SportShop(params SportEquipment[] sportEquipment)
        {
            this.sportEquipment = sportEquipment;
        }
        public void SortByType()
        {
            SportEquipment[] newSportEquipment = new SportEquipment[sportEquipment.Length];
            int index = 0;
            for (int i = 0; i < sportEquipment.Length; i++)
            {
                if (sportEquipment[i] is FootballEquipment)
                {
                    newSportEquipment[index] = sportEquipment[i];
                    index++;
                }
            }
            for (int i = 0; i < sportEquipment.Length; i++)
            {
                if (sportEquipment[i] is BasketballEquipment)
                {
                    newSportEquipment[index] = sportEquipment[i];
                    index++;
                }
            }
            sportEquipment = newSportEquipment;
        }
        public void SortBySeason()
        {
            SportEquipment[] newSportEquipment = new SportEquipment[sportEquipment.Length];
            int index = 0;
            for (int i = 0; i < sportEquipment.Length; i++)
            {
                if (sportEquipment[i].ForWinterSport)
                {
                    newSportEquipment[index] = sportEquipment[i];
                    index++;
                }
            }
            for (int i = 0; i < sportEquipment.Length; i++)
            {
                if (!sportEquipment[i].ForWinterSport)
                {
                    newSportEquipment[index] = sportEquipment[i];
                    index++;
                }
            }
            sportEquipment = newSportEquipment;
        }
        public void ShowInfo()
        {
            for (int i = 0; i < sportEquipment.Length; i++)
            {
                sportEquipment[i].ShowInfoAboutGood();
            }
        }
        static public void FindFoodAdditives(double StartPrice, double FinalPrice, params FoodAdditives[] foodAdditives)
        {
            Console.WriteLine($"Food suplement in the range from {StartPrice}$ to {FinalPrice}$ :");
            for (int i = 0; i < foodAdditives.Length; i++)
            {
                if (foodAdditives[i].Price >= StartPrice && foodAdditives[i].Price <= FinalPrice)
                {
                    foodAdditives[i].ShowInfoAboutAdditive();
                }
            }
        }
    }
}
