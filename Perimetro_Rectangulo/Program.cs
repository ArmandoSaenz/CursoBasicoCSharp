using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            int l1, l2, p;
            Console.WriteLine("Ingresa el tamaño del primer lado");
            data = Console.ReadLine(); // data = "20"
            l1 = int.Parse(data); // data = "20"
            Console.WriteLine("Ingresa el tamaño del segundo lado");
            data = Console.ReadLine(); //data = "50"
            l2 = int.Parse(data);
            p = l1 + l1 + l2 + l2;
            Console.WriteLine("El perimetro del rectangulo es: {p}");
            Console.ReadLine();
        }
    }
}
