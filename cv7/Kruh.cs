using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Kruh : Objekt2D
    {
        protected double Polomer {  get; set; }
        public Kruh(double polomer) 
        { 
            Polomer = polomer;
        }
        public override double Plocha()
        {
            return Math.PI * Math.Pow(Polomer, 2);
        }

        public override string ToString()
        {
            return $"Kruh:  Polomer = {Polomer} a jeho plocha: {Math.Round(Plocha(), 2)}";
        }
    }
}
