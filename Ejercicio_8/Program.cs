using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            int l, p;
            Console.WriteLine("Escribe cuanto mide el lado del cuadrado");
            data = Console.ReadLine();
            l = int.Parse(data);
            p = l + l + l + l;
            Console.WriteLine($"El perimetro es: {p}");
            Console.ReadLine();
        }
    }
}
