using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos
{
    public class Vocales
    {

        public Vocales()
        {

            Console.WriteLine("Ingrese una cadeana de texto: ");
            
            string text = Console.ReadLine();

            int vowelCount = 0;

            foreach (var caracter in text)
            {

                if (IsAVowel(caracter))
                {

                    vowelCount++;

                }

            }

            Console.WriteLine($"El número de vocales en el texto son: {vowelCount}");

        }

        private bool IsAVowel(char caracter)
        {

            return "aeiouáéíóúAEIOUÁÉÍÓÚ".Contains(caracter);

        }

    }
}
