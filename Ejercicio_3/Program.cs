using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pidiendo el nombre de pila
            Console.Write("Ingresa tu nombre de pila: ");
            string nombre = Console.ReadLine();
            //Pidiendo apellidos
            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            //Formando nombre completo
            string nombrecompleto = $"{nombre} {apellido}";
            //Imprimiendo en pantalla nombre completo
            Console.WriteLine(nombrecompleto);
            //Imprimiendo en pantalla nombre completo en mayusculas
            Console.WriteLine(nombrecompleto.ToUpper());
            //Imprimiendo en pantalla nombre completo en minusculas
            Console.WriteLine(nombrecompleto.ToLower());
            //Imprimiendo los primeros 5 caracteres del nombre
            Console.WriteLine(nombrecompleto.Substring(0, 5));
            //Formando correo
            string correo = $"{nombre.Substring(0, 3)}{apellido.Substring(0, 3)}@gmail.com";
            Console.WriteLine(correo);
            //Eliminando los dos primers caracteres de nombre y apellido
            string nombre2 = nombre.Remove(0, 2);
            string apellido2 = apellido.Remove(0, 2);
            Console.WriteLine($"{nombre2} {apellido2}");
            Console.ReadLine();
        }
    }
}
