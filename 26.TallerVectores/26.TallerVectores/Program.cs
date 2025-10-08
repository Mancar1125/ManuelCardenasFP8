using System.Drawing;
using System.Net;

namespace _26.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados. 
            int[] vector = new int[15];
            int max = 0;
            int min = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese un número entero para la posicion {i + 1}, con indice {i}:");
                vector[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = vector[i];
                    min = vector[i];
                }
                else
                {
                    if (vector[i] > max)
                    {
                        max = vector[i];
                    }
                    if (vector[i] < min)
                    {
                        min = vector[i];
                    }
                }
            }
                Console.Clear();

            for (int j = 0; j < vector.Length; j++)
            {
                Console.Write(vector[j] + " | ");
            }

            Console.WriteLine($"El valor máximo es: {max}");
            Console.WriteLine($"El valor mínimo es: {min}");

            //Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el orden de los elementos del vector. Se deben mostrar lo dos vectores.
            char[] vectorChar = new char[10];
            char[] vectorCharInvertido = new char[10];
            for (int k = 0; k < vectorChar.Length; k++)
            {
                Console.Write($"Ingrese un caracter para la posicion {k + 1}, con indice {k}:");
                vectorChar[k] = char.Parse(Console.ReadLine());
                vectorCharInvertido[vectorChar.Length - 1 - k] = vectorChar[k];
            }
            Console.Clear();
            Console.WriteLine("Vector original:");
            for (int l = 0; l < vectorChar.Length; l++)
            {
                Console.Write(vectorChar[l] + " | ");
            }
            Console.WriteLine("\nVector invertido:");
            for (int m = 0; m < vectorCharInvertido.Length; m++)
            {
                Console.Write(vectorCharInvertido[m] + " | ");
            }
           */
            //Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 0 y 50.Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el vector resaltando el número en un color diferente.Si no se encuentra el número, se debe devolver y mostrar -1.
            Random random = new Random();
            int[] vectorAleatorio = new int[20];
            for (int n = 0; n < vectorAleatorio.Length; n++)
            {
                vectorAleatorio[n] = random.Next(0, 51);
            }
            Console.Write("Ingrese un número para buscar en el vector (entre 0 y 50): ");
            int numeroBuscar = int.Parse(Console.ReadLine());
            int posicion = -1;
            for (int p = 0; p < vectorAleatorio.Length; p++)
            {
                if (vectorAleatorio[p] == numeroBuscar)
                {
                    posicion = p;
                    break;
                }
            }
            Console.Clear();
            if (posicion != -1)
            {
                Console.WriteLine($"El número {numeroBuscar} se encuentra en la posición {posicion}.");
                for (int q = 0; q < vectorAleatorio.Length; q++)
                {
                    if (vectorAleatorio[q] == numeroBuscar)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(vectorAleatorio[q] + " | ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(vectorAleatorio[q] + " | ");
                    }
                }
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscar} no se encuentra en el vector. Posición: -1");
                for (int r = 0; r < vectorAleatorio.Length; r++)
                {
                    Console.Write(vectorAleatorio[r] + " | ");
                }
            }











        }
    }
}
