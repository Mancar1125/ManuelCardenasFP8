namespace _30.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Manuel");
           // MostrarMensajes("Tengo 20 Años");
            // Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2004)} Años");
        }

        //Modulo 1 - Procedimiento sin parametros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenidos a la clase de programacion modular");
            MostrarMensajes("Estoy desde un procedimiento sin parametros");
        }
        //Modulo 2 - Procedimiento con parametros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Modulo 3 - Funciones
        static int CalcularEdad()
        {
            int edad;
            edad = 2025 - 2004;
            return edad;
        }

        //Modulo 4 - Funciones con parametros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            
            return añoActual - añoNacimiento;
            
        }

    }
}
