using System.Timers;

class Program
{
   static void Main()
    {
        PrimerEjercicio();
        SegundoEjercicio();
        TercerEjercicio();
    }

    static void PrimerEjercicio()
    {
        int val1;
        int val2;
        int suma;
        int resta;
        int producto;
        int division;


        Console.WriteLine("Escriba el primer valor: ");
        val1 = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Escribe el segundo valor: ");
        val2 = Convert.ToInt32( Console.ReadLine() );

        if ( val1 > val2 )
        {
            suma = val1 + val2;
            resta = val1 - val2;

            Console.WriteLine($"El resultado de la suma de ambos es {suma} y su diferencia es {resta}");
        }
        else
        {
           producto = val1 * val2;
           division = val1 / val2;

            Console.WriteLine($"El resultado del producto de ambos es {producto} y su division es {division}");

        }
    }

    static void SegundoEjercicio()
    {
        int cantidad = 0;
        int numero;
        Console.WriteLine("Escriba un numero: ");
        numero = Convert.ToInt32( Console.ReadLine() );

        if(numero >= 100) {
            cantidad = 3;
            Console.WriteLine($"La cantidad de cifras es: {cantidad}");
        } else if(numero > 10 && numero <= 99) {
            cantidad = 2;
            Console.WriteLine($"La cantidad de cifras es: {cantidad}");
        } else
        {
            cantidad = 1;
            Console.WriteLine($"La cantidad de cifras es: {cantidad}");
        }

    }

    static void TercerEjercicio()
    {
        int totalpreguntas = 100;
        int correctas;

        int totalc;

        Console.WriteLine($"La cantidad de preguntas son {totalpreguntas}");
        Console.WriteLine($"Cuantas preguntas ha contestado correctamente? ");
        correctas = Convert.ToInt32( Console.ReadLine() );

        totalc = totalpreguntas - correctas;

        Console.WriteLine($"Ha contestado {correctas} correctas");

        if ( correctas >= 90 )
        {
            Console.WriteLine("El postulante ha conseguido un nivel maximo");
        } else if (correctas >= 75 && correctas < 90)
        {
            Console.WriteLine("El postulante ha conseguido un nivel medio");
        } else if (correctas >= 50 && correctas < 75)
        {
            Console.WriteLine("El postulante ha conseguido un nivel regular");
        }
        else
        {
            Console.WriteLine("El postulante esta fuera del nivel");
        }
    }
}