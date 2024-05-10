using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double referencia = 10.00000;
            int x = 10;
            //Operadores de comparación <, <=, >, >=, ==, !=
            Console.WriteLine($"Referencia = {referencia}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"x < Referencia: {x < referencia}");
            Console.WriteLine($"x <= Referencia: {x <= referencia}");
            Console.WriteLine($"x > Referencia: {x > referencia}");
            Console.WriteLine($"x >= Referencia: {x >= referencia}");
            Console.WriteLine($"x == Referencia: {x == referencia}");
            Console.WriteLine($"x != Referencia: {x != referencia}");
            Console.ReadLine();
        }
    }
}
