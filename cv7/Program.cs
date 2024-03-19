using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] poleInt = { 1, 3, 5, 7, 9 };
            string[] poleString = { "ahoj", "konomrd", "fotbalista", "dostanu", "za", "f" };
            Kruh[] poleKruhu = { new Kruh(5), new Kruh(7), new Kruh(2), new Kruh(10)  };
            Obdelnik[] poleObdelniku = { new Obdelnik(2, 5), new Obdelnik(3, 1), new Obdelnik(2, 3) };
            Elipsa[] poleElips = { new Elipsa(4, 2), new Elipsa(2, 3), new Elipsa(6, 4), new Elipsa(2, 4) };
            Trojuhelnik[] poleTrojuhelniku = { new Trojuhelnik(2, 4, 3), new Trojuhelnik(4, 6, 7), new Trojuhelnik(4, 2, 5) };
            Ctverec[] poleCtvercu = { new Ctverec(2), new Ctverec(5), new Ctverec(3), new Ctverec(4) };
            Objekt2D[] poleObjekt2D = { new Kruh(5), new Obdelnik(2, 5), new Elipsa(4, 2), new Trojuhelnik(2, 4, 3), new Ctverec(2) };

            //Int
            Console.WriteLine("Nejvetsi prvek v poli int: " + Extremy.Nejvetsi(poleInt));
            Console.WriteLine("Nejmensi prvek v poli int: " + Extremy.Nejmensi(poleInt));
            Console.WriteLine("");
            //String
            Console.WriteLine("Nejvetsi prvek v poli string: " + Extremy.Nejvetsi(poleString));
            Console.WriteLine("Nejmensi prvek v poli string: " + Extremy.Nejmensi(poleString));
            Console.WriteLine("");
            //Kruh
            Console.WriteLine("Nejvetsi prvek v poli kruh: " + Extremy.Nejvetsi(poleKruhu));
            Console.WriteLine("Nejmensi prvek v poli kruh: " + Extremy.Nejmensi(poleKruhu));
            Console.WriteLine("");
            //Obdelnik
            Console.WriteLine("Nejvetsi prvek v poli obdelnik: " + Extremy.Nejvetsi(poleObdelniku));
            Console.WriteLine("Nejmensi prvek v poli obdelnik: " + Extremy.Nejmensi(poleObdelniku));
            Console.WriteLine("");
            //Elipsa
            Console.WriteLine("Nejvetsi prvek v poli elipsa: " + Extremy.Nejvetsi(poleElips));
            Console.WriteLine("Nejmensi prvek v poli elipsa: " + Extremy.Nejmensi(poleElips));
            Console.WriteLine("");
            //Trojuhelnik
            Console.WriteLine("Nejvetsi prvek v poli trojuhelnik: " + Extremy.Nejvetsi(poleTrojuhelniku));
            Console.WriteLine("Nejmensi prvek v poli trojuhelnik: " + Extremy.Nejmensi(poleTrojuhelniku));
            Console.WriteLine("");
            //Ctverec
            Console.WriteLine("Nejvetsi prvek v poli ctverec: " + Extremy.Nejvetsi(poleCtvercu));
            Console.WriteLine("Nejmensi prvek v poli ctverec: " + Extremy.Nejmensi(poleCtvercu));
            Console.WriteLine("");
            //Objekt2D
            Console.WriteLine("Nejvetsi prvek v poli objekt2d: " + Extremy.Nejvetsi(poleObjekt2D));
            Console.WriteLine("Nejmensi prvek v poli objekt2d: " + Extremy.Nejmensi(poleObjekt2D));
            Console.WriteLine("");

            Console.WriteLine("Hodnoty v intervalu <4,8> = " + String.Join(", ", poleInt.Where(x  => x >= 4 && x <= 8).ToArray())); 
        }
    }
}


