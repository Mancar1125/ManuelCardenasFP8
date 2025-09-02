using System;

namespace _5.CondicionalAnidado
{
    //Diseñar un algoritmo que lea tres números A, B, C y visualice en pantalla el valor más grande.El usuario debe ingresar tres valores diferentes. //
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el primer número");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Número mayor: {num1}");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"Número mayor: {num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"Número mayor: {num3}");
            }
            else if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine($"Numero mayor: {num3}");
            }
        }
    }
}
