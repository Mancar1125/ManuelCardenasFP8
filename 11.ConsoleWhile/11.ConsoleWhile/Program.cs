namespace _11.ConsoleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo.Se debe mostrar por pantalla el total de la suma de los números ingresados.//
            
            {
                int numero;
                int suma = 0;

                Console.WriteLine("Ingrese un número entero positivo (o un número negativo para finalizar): ");
                numero = int.Parse(Console.ReadLine());

                while (numero >= 0)
                {
                    suma += numero;
                    Console.WriteLine("Ingrese otro número entero positivo (o un número negativo para finalizar): ");
                    numero = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("La suma total de los números ingresados es: " + suma);
            }
        }
    }
}
