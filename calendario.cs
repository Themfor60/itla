using System;

class Programa
{
    static void Main()
    {
        // tener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // tener el primer día del mes
        DateTime primerDiaDelMes = new DateTime(fechaActual.Year, fechaActual.Month, 1);

        // Nombre del mes
        string mes = fechaActual.ToString("MMMM");

        
        Console.WriteLine($"{mes} {fechaActual.Year}\n");

        
        Console.WriteLine("lu ma mi ju vi sá do");

        // Calcular cuántos espacios vacíos hay antes del primer día del mes
        int diasPrevios = (int)primerDiaDelMes.DayOfWeek;

        // Imprimir espacios para alinear el primer día
        for (int i = 0; i < diasPrevios; i++)
        {
            Console.Write("   ");
        }

        // Imprimir los días del mes
        int totalDiasDelMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);
        for (int dia = 1; dia <= totalDiasDelMes; dia++)
        {
            Console.Write($"{dia,2} ");

            
            if ((diasPrevios + dia) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

  
        Console.WriteLine();
    }
}
