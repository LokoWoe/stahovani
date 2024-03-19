using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Extremy
    {
        public static T Nejvetsi<T>(T[] pole) where T : IComparable<T>
        {
            T nejvetsi = pole[0];
            foreach (T prvek in pole)
            {
                if(prvek.CompareTo(nejvetsi) > 0)
                    nejvetsi = prvek;
            }
            return nejvetsi;
        }
        public static T Nejmensi<T>(T[] pole) where T : IComparable<T>
        {
            T nejmensi = pole[0];
            foreach (T prvek in pole)
            {
                if (prvek.CompareTo(nejmensi) < 0)
                    nejmensi = prvek;
            }
            return nejmensi;
        }
    }
}
