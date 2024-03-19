using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Ctverec : Objekt2D
    {
        protected double A {  get; set; }
        
        public Ctverec(double a)
        { 
            this.A = a;
        }

        public override double Plocha()
        {
            return A * A;
        }

        public override string ToString()
        {
            return $"Ctverec:   A = {A} a jeho plocha: {Math.Round(Plocha(),2)}";
        }
    }
}
