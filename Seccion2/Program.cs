using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int opcion;
            double n1, n2;
            double suma, resta, multiplicacion, division;
            //Mensaje de bienvenida
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Ingrese la opcion que desea hacer con dos numeros: \n1.Sumar \n2.Restar \n3.Multiplicar \n4.Dividir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Digite el primer numero: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero: ");
                    n2 = double.Parse(Console.ReadLine());

                    suma = n1 + n2;
                    Console.WriteLine("Resultado = {0}" ,suma);
                    break;
                case 2:
                    Console.WriteLine("Digite el primer numero: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero: ");
                    n2 = double.Parse(Console.ReadLine());

                    resta = n1 - n2;
                    Console.WriteLine("Resultado = {0}", resta);
                    break;
                case 3:
                    Console.WriteLine("Digite el primer numero: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero: ");
                    n2 = double.Parse(Console.ReadLine());

                    multiplicacion = n1 * n2;
                    Console.WriteLine("Resultado = {0}", multiplicacion);
                    break;
                case 4:
                    Console.WriteLine("Digite el primer numero: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero: ");
                    n2 = double.Parse(Console.ReadLine());

                    division = n1 / n2;
                    Console.WriteLine("Resultado = {0}", division);
                    break;
                default: Console.WriteLine("Opcion incorrecta");
                    break;
            }

        }
    }
}
