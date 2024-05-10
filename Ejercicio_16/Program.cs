using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];//nombres  0xA0, 0xA1, 0xA2, 0xA3, 0xA4
            nombres[0] = "A";
            nombres[1] = "B";
            nombres[2] = "C";
            nombres[3] = "D";
            nombres[4] = "E";
            for(int i = 0; i < 5; ++i)
            {
                Console.WriteLine(nombres[i]);
            }
            Console.ReadLine();
        }
    }
}
