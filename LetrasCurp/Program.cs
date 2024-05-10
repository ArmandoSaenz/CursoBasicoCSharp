using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasCurp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu apellido paterno");
            string apellidoP = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido materno");
            string apellidoM = Console.ReadLine();
            Console.WriteLine("Ingresa tu primer nombre");
            string nombre = Console.ReadLine();
            string curp = apellidoP.ToUpper().Substring(0, 2); //SA
            //curp = curp + apellidoM.toUpper().subString(0,1);
            curp += apellidoM.ToUpper().Substring(0, 1); //SA + E
            curp += nombre.ToUpper().Substring(0, 1);// SA + E + J
            Console.WriteLine(curp);
            Console.ReadLine();
        }
    }
}
