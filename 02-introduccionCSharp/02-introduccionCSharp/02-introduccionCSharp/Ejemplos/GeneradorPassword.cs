using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos
{
    public class GeneradorPassword
    {

        public GeneradorPassword()
        {

            Console.WriteLine("Generador de Contraseñas");

            Console.WriteLine("Ingrese la longitud que espera de la contraseña");

            int l = Convert.ToInt32(Console.ReadLine());

            string password = GenerateKey(l);

            Console.WriteLine($"Contraseña generada: {password}");

            Console.ReadLine();

        }

        private string GenerateKey(int l)
        {

            const string caracteresMayus = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string caracteresMinus = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string specialCaracteres = "!@#$%*()_-=+<>?.";

            StringBuilder password = new StringBuilder(); 

            Random random = new Random();

            password.Append(caracteresMayus[random.Next(caracteresMayus.Length)]);
            password.Append(caracteresMinus[random.Next(caracteresMinus.Length)]);
            password.Append(numbers[random.Next(numbers.Length)]);
            password.Append(specialCaracteres[random.Next(specialCaracteres.Length)]);

            for (int i = 4; i < l; i++)
            {

                string caracteresDisponibles = caracteresMayus + caracteresMinus 
                    + numbers + specialCaracteres;

                password.Append(caracteresDisponibles[random.Next(caracteresDisponibles.Length)]);

            }

            // Mix the password

            for (int i = 0; i < password.Length; i++)
            {

                int randomPosition = random.Next(password.Length);

                char temp = password[i];

                password[i] = password[randomPosition];

                password[randomPosition] = temp;

            }

            return password.ToString();

        }

    }
}
