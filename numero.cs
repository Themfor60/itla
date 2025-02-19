using System;

class Programa
{
    static void Main()
    {
        int[] numeros = new int[10];

        // Ingreso de 10 números
        Console.WriteLine("Ingresa 10 números:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

      
        Array.Sort(numeros);

   
        Console.WriteLine("\nNúmeros ordenados:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
