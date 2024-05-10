using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Escribe 5 nombres cada uno separado por un enter");
            for(int i = 0; i < 5; ++i)
                names[i] = Console.ReadLine();
            Console.WriteLine(String.Join(",", names));
            Console.ReadLine();
        }
    }
}
