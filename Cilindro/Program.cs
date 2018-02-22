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
            // Fazer as variaveis e constantes
            int a, r;
            double volume, areaS;
            string str;
            // Pedir a altura do cilindro
            Console.WriteLine("Qual a altura do cilindro?");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            // Pedir o raio do cilindro
            Console.WriteLine("\nQual o raio do cilindro?");
            str = Console.ReadLine();
            r = Convert.ToInt32(str);
            // Calculos
            volume = Math.PI * (r * r) * a;
            areaS = 2 * Math.PI * r * (r + a);
            // Resultados
            Console.WriteLine("\nVolume = " + volume + "\n\nArea da Superficie = " + areaS + "\n");
        }
    }
}
