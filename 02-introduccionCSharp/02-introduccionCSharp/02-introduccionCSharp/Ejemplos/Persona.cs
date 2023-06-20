using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos
{
    public class Persona
    {

        public String Names { get; set; }
        public int Age { get; set; }

        public String LNames { get; set; }

        public Persona(string names, string lnames, int age)
        {
            
            this.Names = names;

            this.LNames = lnames;

            this.Age = age;

        }

        public Persona()
        {
            
        }

        public void Saludar()
        {

            Console.WriteLine($"¡Hola! Mi nombre es {this.Names} {this.LNames} y tengo {Age} años de edad");    
        
        }

    }
}
