namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.
            Console.WriteLine("Ingrese un número entero positivo:");
            int n = int.Parse(Console.ReadLine());
            int contadorPares = 0;
            int contador = 1;
            while (contador <= n)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }
                contador++;

            }
            Console.WriteLine($"Hay {contadorPares} números pares entre 1 y {n}.");
        }
    }
}
