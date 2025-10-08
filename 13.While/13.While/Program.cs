namespace _13.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13.Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.
El algoritmo debe escribir en pantalla: 
La cantidad de números introducidos que son mayores que 0
La cantidad de números introducidos menores que 0
La cantidad de números iguales a 0.*/

            Console.Write("Ingrese la cantidad de números que va a introducir: ");
            int cantidad = int.Parse(Console.ReadLine());
            int mayoresQueCero = 0;
            int menoresQueCero = 0;
            int igualesACero = 0;

            while (cantidad > 0)
            {
                Console.Write("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    mayoresQueCero++;
                }
                else if (numero < 0)
                {
                    menoresQueCero++;
                }
                else
                {
                    igualesACero++;
                }
                cantidad--;
            }

            Console.WriteLine($"Cantidad de números mayores que 0: {mayoresQueCero}");
            Console.WriteLine($"Cantidad de números menores que 0: {menoresQueCero}");
            Console.WriteLine($"Cantidad de números iguales a 0: {igualesACero}");
        }
    }
}
