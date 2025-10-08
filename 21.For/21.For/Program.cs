namespace _21.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que genera y suma los 5 primeros numeros enteros

            int acumulador = 0;
            for (int i = 1; i <= 5; i++)
            {
                acumulador += i;
            }
            Console.WriteLine($"La suma de los 5 primeros numeros enteros es: {acumulador}");

        }
    }
}
