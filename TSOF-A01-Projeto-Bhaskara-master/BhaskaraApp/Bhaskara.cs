using System;

namespace BhaskaraApp
{
    public class Bhaskara
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalcularDelta()
        {
            return B * B - 4 * A * C;
        }

        public bool TemRaizesReais()
        {
            double delta = CalcularDelta();
            return delta > 0; 
        }

        public (double?, double?) CalcularRaizes()
        {
            double delta = CalcularDelta();

            if (delta < 0)
            {
           
                return (null, null);
            }

            double raizDelta = Math.Sqrt(delta);

            double x1 = (-B + raizDelta) / (2 * A);
            double x2 = (-B - raizDelta) / (2 * A);
            return (x1, x2);
        }
    }
}