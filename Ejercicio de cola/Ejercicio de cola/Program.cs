using System;
using System.Collections;
public class EjemploQueue
{

    public static void Main()
    {

        Queue miQ = new Queue();
        miQ.Enqueue("Uno");
        miQ.Enqueue("Dos");
        miQ.Enqueue("Tres");
        miQ.Enqueue("Cuatro");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nElementos guardados en la cola de nombre miQ");
        Console.ResetColor();

        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nConteo de la cantidad de elementos en la cola {0}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(miQ.Count);
        Console.ResetColor();


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nValores dentro de la cola:");
        Console.ResetColor();


        Console.ForegroundColor = ConsoleColor.Red;
        PrintValues(miQ);
        Console.ResetColor();


        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Removiendo un número de la cola (Dequeue){0}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine("{0}", miQ.Dequeue());
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nMostrando valores de Queue:");
        Console.ResetColor();


        Console.ForegroundColor = ConsoleColor.Red;
        PrintValues(miQ);
        Console.ResetColor();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Removiendo otro número  (Dequeue)");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0}", miQ.Dequeue());
        Console.ResetColor();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nMostrando valores de la Queue:");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        PrintValues(miQ);
        Console.ResetColor();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Mostrando primer elemento sin removerlos (Peek)");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0}", miQ.Peek());
        Console.ResetColor();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nMostrando los valores de la Queue:");
        Console.ResetColor();


        Console.ForegroundColor = ConsoleColor.Red;
        PrintValues(miQ);
        Console.ResetColor();

        Console.WriteLine("");


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nConteo de los valores: {0}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(miQ.Count);
        Console.ResetColor();

        Console.WriteLine("");

        //Commentare este por que no lo pedia en la tarea.
        //miQ.Clear();


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nValores que quedaron en la cola:");
        Console.ForegroundColor = ConsoleColor.Red;
        PrintValues(miQ);
        Console.ResetColor();
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("\t {0}", obj);
        Console.WriteLine();
    }


}
