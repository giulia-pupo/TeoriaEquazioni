using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool n = false;
            if (a != 0)
            {
                n = true;
            }
            return n;
        }
        public static bool IsInconsisted(double a, double b)
        {
            bool n = false;
            if (a == 0)
            {
                if (b != 0)
                {
                    n = true; 
                }
            }
            return n;
        }
        public static bool IsDegree2(double ax)
        {
            bool n = true;
            if (ax == 0)
            {
                n = false;
            }
            return n;
        }
        public static double IsDegree2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            return delta;
        }
    }
}
