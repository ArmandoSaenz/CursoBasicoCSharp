using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            Console.WriteLine("Ingresa un numero:");
            data = Console.ReadLine();
            int x = int.Parse(data);
            float y = float.Parse(data);
            double z = double.Parse(data);
            decimal w = decimal.Parse(data);
            Console.WriteLine($"int {x}");
            Console.WriteLine($"float {y}");
            Console.WriteLine($"double {z}");
            Console.WriteLine($"decimal {w}");
            Console.ReadLine();
        }
    }
}
