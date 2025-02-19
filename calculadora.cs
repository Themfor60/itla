using System;

class Calculadora
{
    static void Main()
    {
        double num1, num2, resultado;
        int opcion;

        do
        {
            Console.WriteLine("Calculadora:");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicación");
            Console.WriteLine("4- División");
            Console.WriteLine("5- Potencia");
            Console.WriteLine("6- Salir");
            Console.Write("Selecciona una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 6)
            {
                Console.Write("Ingresa el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;

                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 6:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 6);
    }
}

