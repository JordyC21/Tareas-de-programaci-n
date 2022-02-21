using System;
using System.Collections.Generic;

class Ejemplo
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" Admins ");
        Console.ResetColor();
        Stack<string> personas = new Stack<string>();
        Console.ForegroundColor = ConsoleColor.Red;
        personas.Push(" Jordy Enrique Cortez Aguilar");
        personas.Push(" Ariel Ediberto Castro ");
        personas.Push(" Wendy Liseth Chacon Pineda");
        personas.Push(" Marvin Johalmo Rivas Ramirez");
        personas.Push(" Victor Ernesto Navarro Monge");


        foreach (string person in personas)
        {
            Console.WriteLine(person);
        }
        Console.ResetColor();

        Console.WriteLine("\nPeek/El primer nombre a desapilar será : {0}",
            personas.Peek());
        Console.WriteLine("Popping/ Eliminando '{0}'", personas.Pop());
        Console.WriteLine("\nPeek/viendo en el siguiente item a desapilar: {0}",
            personas.Peek());
        Console.WriteLine("Popping/ Eliminando '{0}'", personas.Pop());

        Stack<string> Personas2 = new Stack<string>(personas.ToArray());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nContenido de la primer copia:");
        Console.ResetColor();
        foreach (string person in Personas2)
        {
            Console.WriteLine(person);
        }

        //------------------------------------------------

        string[] array2 = new string[personas.Count * 2];
        personas.CopyTo(array2, personas.Count);
        Stack<string> Personas3 = new Stack<string>(array2);

        Console.WriteLine("\nContenido de la segunda copia, con duplicados y nulos:");
        foreach (string person in Personas3)
        {
            Console.WriteLine(person);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nVerificando si la pila # 2 contiene a la persona Victor Ernesto Navarro Monge");
        Console.ResetColor();
        Console.WriteLine("\nLa pila #2 contiene \"Victor Ernesto Navarro Monge\" = {0}",
        Personas2.Contains("Victor Ernesto Navarro Monge"));

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLimpiando la pila #2");
        Console.ResetColor();

        Console.WriteLine("\nPersonas2.Clear()");
        Personas2.Clear();
        Console.WriteLine("\nPersonas2.Count = {0}", Personas2.Count);

    }
}

    


