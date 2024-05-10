using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> pila = new Stack<int>();
            stack.Push(0);//stack = [0]
            stack.Push(1);//stack = [1 0]
            stack.Push(2);//stack = [2 1 0]
            stack.Push(3);//stack = [3 2 1 0]
            stack.Push(4);//stack = [4 3 2 1 0]
            string cmd = String.Join(",", stack.ToArray()); //"4,3,2,1,0"
            Console.WriteLine(cmd);
            //stack = [2 1 0]
            if (stack.Pop() == 4 && stack.Pop() == 2 && stack.Pop() == 2)
                Console.WriteLine(String.Join(",", stack.ToArray()));
            else
                Console.WriteLine(String.Join(",", stack.ToArray()));
            Console.ReadLine();
        }
    }
}
