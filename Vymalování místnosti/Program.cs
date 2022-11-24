using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vymalování_místnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte délku, šířku a výšku stěn místnosti v m^2");
            int d = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            double MalovanaPlocha = 2 * v * (s + d) + (s * d);
            double spotrebaml = MalovanaPlocha * 160 / 1000;
            double spotrebakg = MalovanaPlocha * 220 / 1000;
            Console.WriteLine("Na vymalování místnosti je potřeba {0} ml barvy, neboli {1} kg", spotrebaml, spotrebakg);
            Console.ReadLine();
        }
    }
}