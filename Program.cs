using System;

///////////////////////////////////////////
// 1 - Hacer un programa que divida dos números.
///////////////////////////////////////////

class DivisionProgram
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
            Console.WriteLine($"Resultado: {num1 / num2}");
        else
            Console.WriteLine("Error: No se puede dividir por cero.");
    }
}

///////////////////////////////////////////
// 2 - Desarrollar un programa que multiplique dos números.
///////////////////////////////////////////

class MultiplicacionProgram
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 * num2;

        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
    }
}

///////////////////////////////////////////
// 3 - Hacer un programa que diga si el número digitado es primo o no.
///////////////////////////////////////////

class PrimoProgram
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(num))
            Console.WriteLine($"{num} es un número primo.");
        else
            Console.WriteLine($"{num} no es un número primo.");
    }

    static bool EsPrimo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}

///////////////////////////////////////////
// 4 - Realizar un programa que imprima los números impares del 1 al 30.
///////////////////////////////////////////

class ImparesProgram
{
    static void Main()
    {
        Console.WriteLine("Números impares del 1 al 30:");

        for (int i = 1; i <= 30; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}

///////////////////////////////////////////
// 5 - Desarrollar un programa que imprima la serie Fibonacci del 1 al 50.
///////////////////////////////////////////

class FibonacciProgram
{
    static void Main()
    {
        Console.WriteLine("Serie de Fibonacci hasta 50:");

        int a = 0, b = 1, temp;

        while (a <= 50)
        {
            Console.Write(a + " ");
            temp = a + b;
            a = b;
            b = temp;
        }
    }
}
