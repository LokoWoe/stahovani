using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Obdelnik : Objekt2D
    {
        protected double A {  get; set; }
        protected double B { get; set; }

        public Obdelnik(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Plocha()
        {
            return A * B;
        }

        public override string ToString()
        {
            return $"Obdelnik:  A = {A} B = {B} a jeho plocha: {Math.Round(Plocha(), 2)}";
        }
    }
}
