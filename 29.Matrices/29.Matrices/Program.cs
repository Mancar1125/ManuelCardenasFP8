namespace _29.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de 4 filas y 4 columnas y muestre por pantalla la suma de los elementos de cada columna.
            /*
            int[,] numeros = new int[4, 4];
            int[] sumaColumnas = new int[numeros.GetLength(1)];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el numero para la posicion [{i},{j}]");
                    numeros[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"{numeros[i, j]} |");

                }
            }

            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                int suma = 0;
                for (int i = 0; i < numeros.GetLength(0); i++)
                {
                    sumaColumnas[i] += numeros[j,i];
                }
            }

            for (int i = 0; i < sumaColumnas.Length; i++)
            {
                Console.Write($"{sumaColumnas[i]} |");
            }
            */

            //Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas.
            Console.WriteLine("Ingrese la cantidad de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            int columnas = int.Parse(Console.ReadLine());
            char[,] matriz = new char[filas, columnas];
            char[] primeraFila = new char[columnas];
            char[] ultimaFila = new char[columnas];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el caracter para la posicion [{i},{j}]");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                primeraFila[j] = matriz[0, j];
                ultimaFila[j] = matriz[matriz.GetLength(0) - 1, j];
            }
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[0, j] = ultimaFila[j];
                matriz[matriz.GetLength(0) - 1, j] = primeraFila[j];
            }
            Console.WriteLine("Matriz con filas intercambiadas:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }



        }


    }
}
