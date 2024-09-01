
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>
    {
        { "tiempo", "time" },
        { "persona", "person" },
        { "año", "year" },
        { "camino", "way" },
        { "forma", "way" },
        { "día", "day" },
        { "cosa", "thing" },
        { "hombre", "man" },
        { "mundo", "world" },
        { "vida", "life" },
        { "mano", "hand" },
        { "parte", "part" },
        { "niño", "child" },
        { "niña", "child" },
        { "ojo", "eye" },
        { "mujer", "woman" },
        { "lugar", "place" },
        { "trabajo", "work" },
        { "semana", "week" },
        { "caso", "case" },
        { "punto", "point" },
        { "tema", "point" },
        { "gobierno", "government" },
        { "empresa", "company" },
        { "compañía", "company" }
    };

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase en español: ");
        string frase = Console.ReadLine().ToLower();
        string[] palabras = frase.Split(' ');

        List<string> traduccion = new List<string>();
        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra))
            {
                traduccion.Add(diccionario[palabra]);
            }
            else
            {
                traduccion.Add(palabra); // Dejar la palabra original si no está en el diccionario
            }
        }

        Console.WriteLine("Traducción: " + string.Join(" ", traduccion));
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string palabraEsp = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en inglés: ");
        string palabraIng = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(palabraEsp))
        {
            diccionario.Add(palabraEsp, palabraIng);
            Console.WriteLine("Palabra agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}