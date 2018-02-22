using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1415926;
            // Pedir a altura do cilindro
            Console.WriteLine("Qual a altura do cilindro?");
            string alt = Console.ReadLine();
            int a = Convert.ToInt32(alt);
            // Pedir o raio do cilindro
            Console.WriteLine("\nQual o raio do cilindro?");
            string raio = Console.ReadLine();
            int r = Convert.ToInt32(raio);
            // Calculos
            double volume = pi * (r * r) * a;
            double areaS = 2 * pi * r * (r + a);
            // Resultados
            Console.WriteLine("\nVolume = " + volume + "\n\nArea da Superficie = " + areaS + "\n");
        }
    }
}
