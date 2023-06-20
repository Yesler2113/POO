using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos
{
    internal class Calculadora
    {

        public Calculadora()
        {

            Console.WriteLine("Calculadora Básica");

            Console.WriteLine("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seleccione una Operación: ");
            Console.WriteLine("1. Suma (+)");
            Console.WriteLine("2. Resta (-)");
            Console.WriteLine("3. Multiplicación (*)");
            Console.WriteLine("4. División (/)");

            Console.Write("Ingrese el número que corresponde a la operación a realizar: ");
            int opc = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (opc)
            {

                case 1: result = num1 + num2;
                    Console.WriteLine($"El Resultado de  {num1} + {num2} es: {result} ");
                    break;

                case 2: result = num1 - num2;
                    Console.WriteLine($"El Resultado de  {num1} - {num2} es: {result} ");
                    break;

                case 3: result = num1 * num2;
                    Console.WriteLine($"El Resultado de  {num1} * {num2} es: {result} ");
                    break;

                case 4:
                    if (num2!=0)
                    {

                        result = num1 / num2;
                        Console.WriteLine($"El Resultado de  {num1} / {num2} es: {result} ");

                    }
                    else
                    {

                        Console.WriteLine("No se puede dividir entre 0");

                    }
                    break;

                default:
                    Console.WriteLine("Por favor, elija una opción válida");
                    break;
            }
                       
        }

    }

}
