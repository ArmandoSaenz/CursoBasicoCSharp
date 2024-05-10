using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número con signo");
            Console.WriteLine($"sbyte: {sbyte.MinValue} a {sbyte.MaxValue}");
            Console.WriteLine($"short o Int16: {short.MinValue} a {short.MaxValue}");
            Console.WriteLine($"int o Int32: {int.MinValue} a {int.MaxValue}");
            Console.WriteLine($"long o Int64: {long.MinValue} a {long.MaxValue}");
            Console.WriteLine("Números sin signo");
            Console.WriteLine($"byte: {byte.MinValue} a {byte.MaxValue}");
            Console.WriteLine($"ushort o UInt16: {ushort.MinValue} a {ushort.MaxValue}");
            Console.WriteLine($"uint o UInt32: {uint.MinValue} a {uint.MaxValue}");
            Console.WriteLine($"ulong o UInt64: {ulong.MinValue} a {ulong.MaxValue}");
            Console.ReadLine();
        }
    }
}
