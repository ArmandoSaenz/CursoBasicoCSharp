using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subtotal, iva, total;
            string data;
            Console.WriteLine("Ingresa el subtotal de la factura");
            data = Console.ReadLine();
            subtotal = double.Parse(data);
            iva = subtotal * 0.16;
            total = subtotal * 1.16;
            Console.WriteLine($"El IVA es: {iva.ToString("C2")}");
            Console.WriteLine($"El Total es: {total.ToString("C2")}");
            Console.ReadLine();
        }
    }
}
