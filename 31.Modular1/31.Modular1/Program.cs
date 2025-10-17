namespace _31.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //31. Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz. 
            int[,] multiplosDe5=new int[CapturarFilas(), CapturarColumnas()];

        }

        static int[,] LlenarMatriz(int[,] matriz)
        {
            return matriz;
        }

        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el numero de filas para la matriz:");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el numero de columnas para la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }
    }
}
