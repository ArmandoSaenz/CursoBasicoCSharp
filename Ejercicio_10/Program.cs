using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int z;
            string data;
            Console.WriteLine($"Ingresa un numero:");
            data = Console.ReadLine();
            x = int.Parse(data);
            z = x % 2;
            if(z == 1)
            {
                Console.WriteLine($"El numero {x} es impar");
            }
            else
            {
                Console.WriteLine($"El numero {x} es par");
            }
            Console.ReadLine();
        }
    }
}
