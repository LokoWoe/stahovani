using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv8
{
    public  class ArchivTeplot
    {
        private SortedDictionary<int , RocniTeplota> _archiv;
        public ArchivTeplot() 
        {
            _archiv = new SortedDictionary<int, RocniTeplota> ();
        }

        public void Load (string cesta)
        {
            _archiv.Clear ();
            string[] text = File.ReadAllLines (cesta);
            foreach (string radek in text) 
            {
                string[] radky = radek.Split(';',':');
                int rok = int.Parse(radky[0]);
                radky = radky.Skip (1).ToArray ();
                RocniTeplota rocniTeplota = new RocniTeplota(rok);
                foreach (string teploty in radky)
                    rocniTeplota.MesicniTeploty.Add(double.Parse(teploty));
                _archiv.Add(rok, rocniTeplota);
            }
        }
        public void Save (string cesta) 
        {
            StreamWriter sw = File.CreateText (cesta);
            foreach(var hodnoty in  _archiv) 
            {
                sw.Write (hodnoty.Key + ": ");
                sw.WriteLine(String.Join("; ", hodnoty.Value.MesicniTeploty));
            }
            sw.Close ();
        }

        public void Kalibrace(double kalibrace)
        {
            foreach(var hodnoty in _archiv.Values)
                for(int i = 0; i < hodnoty.MesicniTeploty.Count; i++)
                {
                    hodnoty.MesicniTeploty[i] += kalibrace;
                    hodnoty.MesicniTeploty[i] = Math.Round(hodnoty.MesicniTeploty[i], 1);
                }
                    
        }

        public RocniTeplota Vyhledej(int rok)
        {
            if (_archiv.ContainsKey(rok))
                return _archiv[rok];
            return null;
        }

        public void TiskTeplot()
        {
            foreach (var hodnoty in _archiv)
            {
                Console.Write($"{hodnoty.Key}:");
                Console.WriteLine(String.Join("; ", hodnoty.Value.MesicniTeploty));
            }
        }

        public void TiskPrumernychRocnichHodnot()
        {
            foreach (var hodnoty in _archiv)
            {
                Console.Write($"{hodnoty.Key}: ");
                Console.WriteLine(Math.Round(hodnoty.Value.MesicniTeploty.Average(),1));
            }
        }
        public void TiskPrumernychMesicnichHodnot()
        {
            Console.Write("Prum: ");
            for (int i = 0; i < 12; i++)
            {
                double prumer = _archiv.Values.Select(x => x.MesicniTeploty[i]).Average();
                Console.Write(Math.Round(prumer, 1));
                if (i != 11)
                    Console.Write("; ");
                else
                    Console.WriteLine();

            }
        }

    }
}
