namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales simples
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingresa el nombre");
            nombre = Console.ReadLine(); //Todo lo que se lee desde la consola llega como un string

            Console.WriteLine("Ingresa el sueldo");
            sueldo = Convert.ToInt32( Console.ReadLine());

            if (sueldo>3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            
            
        }
    }
}
