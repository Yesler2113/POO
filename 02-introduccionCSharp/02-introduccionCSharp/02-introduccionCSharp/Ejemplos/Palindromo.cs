using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos
{
    public class Palindromo
    {

        public Palindromo()
        {

            Console.WriteLine("Ingrese la frase o palabra");

            string word = Console.ReadLine();

            if (determinate(word) == true)
            {

                Console.WriteLine("La palabra Ingresada es palindroma");

            }
            else
            {

                Console.WriteLine("La palabra ingresada no es palindroma");

            }


        }

        private bool determinate(string word)
        {

            string palabra = word.ToLower().Replace(" ", "").Replace(",", "").
                Replace(".","").Replace("?", "").Replace("¿", "").Replace(";", "");


            for (int i = 0; i < palabra.Length; i++)
            {

                char c = palabra[i];

                char c2 = palabra[palabra.Length - (i + 1)];

                if (c != c2)
                {

                    return false;

                    break;

                }

            }

            return true;
        }

    }
}
