using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            float y, z;
            string data;
            Console.WriteLine("Ingresa el divisor");
            data = Console.ReadLine();
            x = double.Parse(data);
            Console.WriteLine("Ingresa el dividendo");
            data = Console.ReadLine();
            y = float.Parse(data);
            z = (float)x / y;
            Console.WriteLine($"{x}/{y} = {z}");
            Console.WriteLine($"La parte entera es = {(int)z}");
            Console.ReadLine();
        }
    }
}
