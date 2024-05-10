using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operación de incremento en prefijo
            int x = 20;
            Console.WriteLine($"x = {x}"); //Imprime 20
            Console.WriteLine($"++x = {++x}"); //Imprime 21
            Console.WriteLine($"x = {x}"); //Imprime 21
            //Operación de incremento en sufijo
            int y = 30;
            Console.WriteLine($"y = {y}"); //Imprime 30
            Console.WriteLine($"y++ = {y++}"); //Imprime 30
            Console.WriteLine($"y = {y}"); //Imprime 31
            Console.ReadLine();
        }
    }
}
