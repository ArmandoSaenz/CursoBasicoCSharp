using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] calificaciones = 0;
            int cantidad;
            Console.WriteLine("Inidica cuantas calificaciones son:");
            cantidad = int.Parse(Console.ReadLine());
            calificaciones = new double[cantidad];
            for(int i = 0; i < cantidad; ++i)
            {
                Console.WriteLine($"Ingresa la calificación {i + 1}:");
                calificaciones[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El promedio es {calificaciones.Average()}");
            Console.ReadLine();
        }
    }
}
