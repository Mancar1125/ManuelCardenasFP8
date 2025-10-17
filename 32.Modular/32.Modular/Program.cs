namespace _32.Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = CapturarFilas();
            int columnas = CapturarColumnas();
            int[,] multiplosde5 = new int[filas, columnas];
            LlenarMatriz(multiplosde5);
            MostrarMatriz(multiplosde5);
        }

        static void LlenarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = CapturarMultiploDe5($"Ingrese un múltiplo de 5 para la posición [{i},{j}]: ");
                }
            }
        }

        static int CapturarMultiploDe5(string mensaje)
        {
            int numero;
            do
            {
                Console.WriteLine(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out numero) || !EsMultiploDe5(numero));
            return numero;
        }

        static bool EsMultiploDe5(int numero)
        {
            return numero % 5 == 0 && numero != 0;
        }

        static int CapturarFilas()
        {
            int filas;
            Console.WriteLine("Ingrese el número de filas para la matriz:");
            while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido y mayor a 0.");
            }
            return filas;
        }

        static int CapturarColumnas()
        {
            int columnas;
            Console.WriteLine("Ingrese el número de columnas para la matriz:");
            while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido y mayor a 0.");
            }
            return columnas;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz de múltiplos de 5:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
