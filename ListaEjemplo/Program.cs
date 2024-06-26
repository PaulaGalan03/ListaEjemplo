using System;
using System.Collections.Generic;

namespace ListaEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> listadeusuarios = new List<Usuario>()
            {
            new Usuario() { Nombre = "Frank", Edad = 38 },
            new Usuario() { Nombre = "Carlos", Edad = 34 },
            new Usuario() { Nombre = "Jose", Edad = 8 },
            };

            for (int i = 0; i < listadeusuarios.Count; i++)
            {
                Console.WriteLine(listadeusuarios[i].Nombre + " tiene " + listadeusuarios[i].Edad + " años");
            }

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("a string");
            listOfStrings.AddRange(new string[]
            {
            "Jenna Doe",
            "Another Doe"
            });
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.WriteLine(listOfStrings[i]);
            }
            listOfStrings.Remove("Joe Doe");


            Console.ReadKey();
        }
    }
}
