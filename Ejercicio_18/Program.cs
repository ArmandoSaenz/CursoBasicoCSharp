using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            int cantidad;
            Console.WriteLine("Ingresa la cantidad de nombres:");
            cantidad = int.Parse(Console.ReadLine());
            names = new string[cantidad];
            for(int i = 0; i < cantidad; ++i)
            {
                Console.WriteLine($"Ingresa el nombre numero {i + 1}");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine(String.Join(",", names));
            Console.ReadLine();
        }
    }
}
