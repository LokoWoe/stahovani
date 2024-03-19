using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Elipsa : Objekt2D
    {
        protected double A {  get; set; } 
        protected double B { get; set; }

        public Elipsa(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Plocha()
        {
            return Math.PI * A * B; 
        }

        public override string ToString()
        {
            return $"Elipsa:  A = {A} B = {B} a jeji plocha: {Math.Round(Plocha(), 2)}";
        }
    }
}
