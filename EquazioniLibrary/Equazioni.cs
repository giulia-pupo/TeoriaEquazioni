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
        public static string CalcoloEquazione (double a, double b, double c)
        {
            string risposta = "";
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                risposta = $"I risultati dell'equazione sono {x1} e {x2}";
            }
            else if (delta == 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                risposta = $"I risultati dell'equazione sono {x1} e {x2}";
            }
            else if (delta < 0)
            {
                risposta = "L'equazione è impossibile";
            }
            return risposta;
        }
        public static string EquationDegree1(double a, double b)
        {
            string risposta = "";
            if (a == 0 || b == 0)
            {
                risposta = "L'equazione è indeterminata";
            }
            else if (a != 0 || b == 0)
            {
                risposta = "L'equazione è impossibile";
            }
            else
            {
                double x = -b / a;
                risposta = $"Il risultato dell'equazione è {x}";
            }
            return risposta;
        }
    }
    }
}
