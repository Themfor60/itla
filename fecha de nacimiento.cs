using System;

class Programa
{
    static void Main()
    {
        // Solicitar al usuario su fecha de nacimiento
        Console.Write("Ingresa tu fecha de nacimiento (dd/mm/yyyy): ");
        DateTime fecha = Convert.ToDateTime(Console.ReadLine());

        // Mostrar el día de la semana
        Console.WriteLine("El día de la semana fue: " + fecha.DayOfWeek);
    }
}

