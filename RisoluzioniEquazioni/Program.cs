using System;
using EquazioniLibrary;

namespace RisoluzioniEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i termini dell'equazione di primo grado:");
            Console.Write("a = ");
            int ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Equazioni.EquationDegree1(ax, b)); 
            Console.WriteLine(Equazioni.SolutionDegree1(ax, b)); 

            Console.WriteLine();

            Console.WriteLine("Inserisci i termini dell'equazione di scondo grado:");
            Console.Write("a = ");
            int ax2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());


            if(Equazioni.IsDegree2(ax2) == false)
            {
                Console.WriteLine("L'equazione NON è di secondo grado");
            }

            Console.WriteLine($"Il delta dell'equazuione è: {Equazioni.Delta(ax2, bx, c)}");
            Console.WriteLine(Equazioni.CalcoloEquazione(ax2, bx, c));
        }
    }
}
