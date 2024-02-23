using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la calificación del examen: ");

        if (int.TryParse(Console.ReadLine(), out int calificacion))
        {
            EvaluarDesempeno(calificacion);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese una calificación numérica.");
        }
    }

    static void EvaluarDesempeno(int calificacion)
    {
        switch (calificacion)
        {
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Sobresaliente");
                break;
            case int n when (n >= 80 && n <= 89):
                Console.WriteLine("Notable");
                break;
            case int n when (n >= 70 && n <= 79):
                Console.WriteLine("Aprobatoria");
                break;
            case int n when (n >= 60 && n <= 69):
                Console.WriteLine("No aprobatoria");
                break;
            default:
                Console.WriteLine("Calificación no válida. Por favor, ingrese una calificación entre 0 y 100.");
                break;
        }
    }
}

