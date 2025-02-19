using System;

class Programa
{
    static void Main()
    {
        // Preguntar al usuario su nombre
        Console.Write("¿Cuál es tu nombre? ");
        string nombre = Console.ReadLine();

       
        char inicial = nombre[0];

      
        Console.WriteLine($"La inicial de tu nombre es: {inicial}");
    }
}
