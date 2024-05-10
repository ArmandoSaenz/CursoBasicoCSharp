using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool v1 = true;// true
            bool v2 = true;// false
            
            //Operadores booleanos &&, ||, ^, !
            Console.WriteLine($"v1 : {v1}");
            Console.WriteLine($"v2 : {v2}");
            Console.WriteLine($"v1 && v2: {v1 && v2}");
            Console.WriteLine($"v1 || v2: {v1 || v2}");
            Console.WriteLine($"v1 ^ v2: {v1 ^ v2}");
            Console.WriteLine($"!v1: {!v1}");
            Console.ReadLine();
        }
    }
}
