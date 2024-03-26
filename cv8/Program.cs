
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv8
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArchivTeplot archivTeplot = new ArchivTeplot();
            archivTeplot.Load("teploty.txt");

            Console.WriteLine("\nHodnoty ze souboru:");
            archivTeplot.TiskTeplot();

            Console.WriteLine("\nPrumerne rocni hodnoty:");
            archivTeplot.TiskPrumernychRocnichHodnot();

            Console.WriteLine("\nPrumerne mesicni hodnoty:");
            archivTeplot.TiskPrumernychMesicnichHodnot();

            Console.WriteLine("\nMetoda Vyhledej:");
            int rok = 2019;
            RocniTeplota hledej = archivTeplot.Vyhledej(rok);
            if (hledej != null)
            {
                Console.Write($"{rok}: ");
                Console.WriteLine(string.Join(", ", hledej.MesicniTeploty));
            } 
            else
                Console.WriteLine($"Hodnoty pro rok {rok} nebyly nalezeny.");


            archivTeplot.Kalibrace(-0.1);
            Console.WriteLine("\nHodnoty po kalibraci:");
            archivTeplot.TiskTeplot();

           // archivTeplot.Save("ulozeno.txt");
            Console.WriteLine("\nHodnoty byly ulozeny");
        }
    }
}
