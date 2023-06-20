using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_introduccionCSharp.Ejemplos.Frutas
{
    public class AppFrutas
    {

        List<Fruta> fruits = new(); 

        public AppFrutas()
        {

            Console.WriteLine("¡Bienvenido al programa de frutas!");

            bool exit = false;

            while(!exit) 
            {
                Console.WriteLine("\n¿Que acción desea realizar?");
                Console.WriteLine("1. Agregar Frutas");
                Console.WriteLine("2. Mostrar Frutas");
                Console.WriteLine("3. Eliminar Frutas");
                Console.WriteLine("4. Vaciar lista de Frutas");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Ingrese el número de la Opción: ");

                int opc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (opc)
                {

                    case 1:
                        AddFruits();
                        break;

                    case 2:
                        ShowFruits();
                        break;

                    case 3:
                        DeleteFruit();   
                        break;

                    case 4:
                        ClearList();
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }



        }

        private void ClearList()
        {

            fruits.Clear();

            Console.WriteLine("Lista de Frutas borrado");

        }

        private void DeleteFruit()
        {

            Console.WriteLine("Ingrese la fruta a eliminar: ");
            string nombre = Console.ReadLine();

            bool findedFruit = false;

            for (int i = 0; i < fruits.Count; i++)
            {

                if (fruits[i].name == nombre)
                {

                    fruits.RemoveAt(i);
                    findedFruit = true;

                    Console.WriteLine("Fruta Eliminada");
                    
                    break;

                }

            }

            if (!findedFruit)
            {

                Console.WriteLine("No se encontro la fruta en la lista");

            }    

        }

        private void ShowFruits()
        {

            if (fruits.Count == 0)
            {

                Console.WriteLine("No hay frutas en la lista");

            }
            else
            {

                Console.WriteLine("Lista de Frutas");

                foreach (var fruit in fruits)
                {

                    Console.WriteLine($"Nombre: {fruit.name}, Color: {fruit.color}");

                }

            }

        }

        private void AddFruits()
        {

            Console.Write("Ingrese el nombre de la fruta: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese el color de la fruta: ");
            string color = Console.ReadLine();

            fruits.Add(new Fruta(name, color));

            Console.WriteLine("Fruta agregada exitosamente");

        }
    }
}