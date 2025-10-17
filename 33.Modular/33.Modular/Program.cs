using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            MostrarMenu();
            opcion = CapturarOpcion();

            switch (opcion)
            {
                case 1: // Suma (N números)
                    RealizarSuma();
                    break;

                case 2: // Resta (2 números)
                    RealizarResta();
                    break;

                case 3: // Multiplicación (N números)
                    RealizarMultiplicacion();
                    break;

                case 4: // División (2 números)
                    RealizarDivision();
                    break;

                case 5:
                    Console.WriteLine("¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }

    
    static void MostrarMenu()
    {
        Console.WriteLine("===== CALCULADORA =====");
        Console.WriteLine("1) Suma (N números)");
        Console.WriteLine("2) Resta (2 números)");
        Console.WriteLine("3) Multiplicación (N números)");
        Console.WriteLine("4) División (2 números)");
        Console.WriteLine("5) Salir");
        Console.Write("Elige una opción: ");
    }

    static int CapturarOpcion()
    {
        int op;
        bool valido;
        do
        {
            string? s = Console.ReadLine();
            valido = int.TryParse(s, out op) && op >= 1 && op <= 5;

            if (!valido)
                Console.Write("Entrada inválida. Elige 1-5: ");

        } while (!valido);

        return op;
    }

    
    static void RealizarSuma()
    {
        int n = LeerEnteroPositivo("¿Cuántos números quieres sumar? (>=1): ", minimo: 1);
        double resultado = 0;
        for (int i = 1; i <= n; i++)
            resultado += LeerDouble($"Número #{i}: ");

        Console.WriteLine($"\nResultado de la suma: {resultado}");
    }

    static void RealizarMultiplicacion()
    {
        int n = LeerEnteroPositivo("¿Cuántos números quieres multiplicar? (>=1): ", minimo: 1);
        double resultado = 1;
        for (int i = 1; i <= n; i++)
            resultado *= LeerDouble($"Número #{i}: ");

        Console.WriteLine($"\nResultado de la multiplicación: {resultado}");
    }

    static void RealizarResta()
    {
        Console.WriteLine("Resta de 2 números (a - b):");
        double a = LeerDouble("a: ");
        double b = LeerDouble("b: ");
        Console.WriteLine($"\nResultado de la resta: {a - b}");
    }

    static void RealizarDivision()
    {
        Console.WriteLine("División de 2 números (a / b):");
        double a = LeerDouble("a: ");
        double b = LeerDoubleNoCero("b (≠ 0): ");
        Console.WriteLine($"\nResultado de la división: {a / b}");
    }

   
    static int LeerEnteroPositivo(string prompt, int minimo = 1)
    {
        int val;
        bool valido;
        do
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            valido = int.TryParse(s, out val) && val >= minimo;

            if (!valido)
                Console.WriteLine($"Entrada inválida. Debe ser un entero >= {minimo}.");

        } while (!valido);

        return val;
    }

    static double LeerDouble(string prompt)
    {
        double val;
        bool valido;
        do
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();

            if (s != null) s = s.Replace(',', '.');

            valido = double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out val);

            if (!valido)
                Console.WriteLine("Número inválido. Intenta de nuevo (puedes usar coma o punto).");

        } while (!valido);

        return val;
    }

    static double LeerDoubleNoCero(string prompt)
    {
        double val;
        bool valido;
        do
        {
            val = LeerDouble(prompt);
            valido = val != 0;

            if (!valido)
                Console.WriteLine("El divisor no puede ser 0. Intenta de nuevo.");

        } while (!valido);

        return val;
    }
}
