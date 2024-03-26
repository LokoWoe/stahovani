using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv8
{
    public class RocniTeplota
    {
        public int Rok;
        public List<double> MesicniTeploty;
        public RocniTeplota(int rok)
        {
            Rok = rok;
            MesicniTeploty = new List<double>(12);
        }   
        double MaxTeplota => MesicniTeploty.Max();
        double MinTeplota => MesicniTeploty.Min();
        double PrumRocniTeplota => MesicniTeploty.Average();
    }
}
