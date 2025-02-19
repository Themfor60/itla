using System;

class Programa
{
    static void Main()
    {
        
        Console.Write("Ingresa tu fecha de nacimiento (dd/mm/yyyy): ");
        DateTime fecha = Convert.ToDateTime(Console.ReadLine());

      
        Console.WriteLine("El día de la semana fue: " + fecha.DayOfWeek);
    }
}

