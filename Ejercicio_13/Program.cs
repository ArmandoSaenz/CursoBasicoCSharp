using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string data;
            string respuesta;
            Console.WriteLine("Ingresa tu edad");
            data = Console.ReadLine();
            edad = int.Parse(data);
            respuesta = (edad >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
            Console.WriteLine(respuesta);
            Console.ReadLine();
        }
    }
}
