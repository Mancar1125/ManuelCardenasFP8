namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que genere y muestre la suma de los cinco primeros numeros enteros
            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador+=contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");

            //17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            string respuesta = "si";
            do
            {
                Console.WriteLine("Ingrese un numero para generar su tabla de multiplicar: ");

                int numero = int.Parse(Console.ReadLine());

                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    int resultado = numero * multiplicador;
                    Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
                }
                Console.WriteLine("Desea generar otra tabla de multiplicar? (si/no)");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "si");

            Console.WriteLine("Gracias por usar el programa.");


        }
    }
}
