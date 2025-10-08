namespace _26._Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];
            string[,] nombres = new string[2, 3]; //rango=6 posiciones
            

            //Asignacion de valores
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 58;
            numeros[1, 1] = 12;

            //Otra forma de declarar e inicializar una matriz
            string[,] apellidos =
                {
                {"Cárdenas", "Villa" },
                {"Alfaro", "Quijano"},
                {"Escobar", "Vanegas"},
                };

            //Recuperar datos de la matriz
            Console.WriteLine(apellidos[1, 1]);

            //Recorrer una matriz - almacenar datos
            char[,] caracteres = new char[3, 2]; //rango=6 posiciones

            for (int i = 0; i < 3; i++) //Recorre las filas
            {
                for (int j = 0; j < 2; j++) //Recorre las columnas de cada una de las filas
                {
                    Console.WriteLine($"Ingrese el caracter para la posición [{i},{j}]: ");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer una matriz - recuperar datos
            for (int i = 0; i < caracteres.GetLength(0); i++) //.GetLength(0) devuelve el número de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) //.GetLength(1) devuelve el número de columnas
                {
                    Console.Write($"Caracter posición {i}, {j}: {caracteres[i,j]}");
                }
                Console.WriteLine();
            }

            //Crear una matriz de 4x4 y llenarla con el número 10
            int[,] matrizDiez = new int[4, 4];
            for (int i = 0; i < matrizDiez.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDiez.GetLength(1); j++)
                {
                    matrizDiez[i, j] = 10;
                    Console.Write($"{matrizDiez[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
