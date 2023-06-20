using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos.Frutas
{
    public class Fruta
    {

        public string name { get; set; }
        public string color { get; set; }

        public Fruta(string name, string color)
        {
            
            this.name = name;

            this.color = color;

        }

    }
}
