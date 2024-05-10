using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Perimetro circulo = 2 * PI * radio
            int r;
            double p;
            string data;
            Console.WriteLine("Ingresar radio del circulo");
            data = Console.ReadLine();
            r = int.Parse(data);
            p = 2 * Math.PI * r;
            Console.WriteLine($"El perimetro es: {p.ToString("F4")}");
            Console.ReadLine();
        }
    }
}
