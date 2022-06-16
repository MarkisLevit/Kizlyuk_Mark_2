using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class SportShop
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
        public void SortByPrice()
        {
            for (int i = 0; i < sportEquipment.Length - 1; i++)
            {
                for (int j = 0; j < sportEquipment.Length - 1; j++)
                {
                    if (sportEquipment[j].Price > sportEquipment[j + 1].Price)
                    {
                        SportEquipment temp = sportEquipment[j];
                        sportEquipment[j] = sportEquipment[j + 1];
                        sportEquipment[j + 1] = temp;
                    }
                }
            }
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
