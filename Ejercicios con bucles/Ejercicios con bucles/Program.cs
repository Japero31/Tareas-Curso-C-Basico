class Program
{
    static void Main()
    {
        SuperficieTriangulo();
        CargaNumeros();
    }

    static void SuperficieTriangulo()
    {
        int pares;
        double Base = 0;
        double Altura = 0;
        double superficie = 0;
        double mayor12 = 0;

        Console.WriteLine("Ingrese la cantidad de pares: ");
        pares = int.Parse(Console.ReadLine());

        for (int i = 1; i <= pares; i++) 
        {
            Console.WriteLine("Ingrese la base del triangulo: ");
            Base =  int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo: ");
            Altura = int.Parse(Console.ReadLine());

            superficie = Base * Altura;

            Console.WriteLine($"Del triangulo numero {i}");
            Console.WriteLine($"La base del triangulo es {Base}");
            Console.WriteLine($"La altura del triangulo es {Altura}");
            Console.WriteLine($"La superficie del triangulo es {superficie}");

            if (superficie>=12)
            {
                mayor12++;
            }

        }

        Console.WriteLine($"La cantidad de triangulos con la superficie mayor a 12 son: {mayor12}");
    }

    static void CargaNumeros() 
    {
        int suma = 0;
        int numeros;
        int cantidad;
        for (int i = 1;i <= 10;i++)
        {
            Console.WriteLine($"Ingrese el numero {i}");
            cantidad = int.Parse(Console.ReadLine());

            if (i > 5)
            {
                suma += cantidad;
            }
        }

        Console.WriteLine($"La suma de los ultimos 5 numeros es: {suma}");
    }
}