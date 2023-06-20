using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos
{
    public class Dados
    {

        public Dados()
        {

            Console.WriteLine("Simulador de dado");

            Console.WriteLine("Ingrese la cantidad de lanzamientos");

            int launchCounter = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            Console.WriteLine("Resultado de lanzamiento");

            for (int i = 1; i <= launchCounter; i++)
            {

                int resultado = random.Next(1,7);

                Console.WriteLine($"Lanzamiento {i}: {resultado}");

            }

            Console.ReadLine();

        }

    }
}
