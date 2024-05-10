using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 15;
            string resultado;
            if(edad >= 18)
            {
                resultado = "mayor de edad";
            }
            else
            {
                resultado = "menor de edad";
            }
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
