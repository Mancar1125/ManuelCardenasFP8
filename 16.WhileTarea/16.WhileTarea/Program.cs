namespace _16.WhileTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. 
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intento = 0;
            while (intento != numeroAleatorio)
            {
                Console.Write("Adivina el número (entre 1 y 100): ");
                intento = int.Parse(Console.ReadLine());
                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
                }
            }
        }
    }
}
