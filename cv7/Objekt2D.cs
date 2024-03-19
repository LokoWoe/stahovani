using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public abstract class Objekt2D : I2D, IComparable<Objekt2D>
    {
        public int CompareTo(Objekt2D other)
        {
            if(other == null) return 1;
            return this.Plocha().CompareTo(other.Plocha());
        }

        public abstract double Plocha();
    }
}
