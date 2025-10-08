namespace _19.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19 . Realizar un programa que solicite el ingreso de 100 edades y el género de cada persona. 

            int edad = 0;
            char genero = ' ';
            int mayorEdad = 0;
            int menorEdad = 0;
            int hombres = 0;
            int mujeres = 0;
            int numeroEstudiantes = 0;
            int cantidad = 5;

            do
            {
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el género: ");
                Console.WriteLine("M para masculino, F para femenino");
                genero = char.Parse(Console.ReadLine().ToUpper());

                if (edad >= 18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }
                if (genero == 'M')
                {
                    hombres++;
                }
                else if (genero == 'F')
                {
                    mujeres++;
                }
                else
                {
                    Console.WriteLine("Género no válido. Ingrese 'M' para masculino o 'F' para femenino.");
                }
                numeroEstudiantes++;
            } while (numeroEstudiantes < cantidad);
            Console.WriteLine($"De {cantidad} personas los resultados son:");
            Console.WriteLine($"Cantidad de personas mayores de edad: {mayorEdad}");
            Console.WriteLine($"Cantidad de personas menores de edad: {menorEdad}");
            Console.WriteLine($"Cantidad de hombres: {hombres}");
            Console.WriteLine($"Cantidad de mujeres: {mujeres}");

        }
    }
}
