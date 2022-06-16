using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    abstract class SportEquipment : SportShop /*, IComparable<SportEquipment> */
    {
        public abstract void ShowInfoAboutGood();
        public abstract double Price { get; set; }
        public abstract int Year { get; set; }
        public abstract string Quality { get; set; }
        public abstract bool ForWinterSport { get; }
        //public int CompareTo(SportEquipment s)
        //{
        //        if (this.Price > s.Price)
        //        {
        //            return 1;
        //        }
        //        else if (this.Price < s.Price)
        //        {
        //            return -1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //}
        //public override string ToString()
        //{
        //    return $"This equipment cost {Price}, create in {Year} and has quality:{Quality}$";
        //}
    }
}
