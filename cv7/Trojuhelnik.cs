using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Trojuhelnik : Objekt2D
    {
        protected double A {  get; set; }
        protected double B { get; set; }
        protected double C { get; set; }

        public Trojuhelnik( double a, double b, double c )
        {
            A = a; 
            B = b; 
            C = c;
        }

        public override double Plocha()
        {
            double pom = (A + B + C) / 2;
            return Math.Sqrt(pom * (pom - A) * (pom - B) * (pom - C));
        }

        public override string ToString()
        {
            return $"Trojuhelnik:  A = {A} B = {B} C = {C} a jeho plocha: {Math.Round(Plocha(), 2)}";
        }
    }
}
