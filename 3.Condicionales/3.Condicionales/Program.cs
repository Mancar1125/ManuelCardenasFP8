namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales simples
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
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

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. 
            int edad = 0;

            Console.WriteLine("Ingresa tu edad");
            edad = Convert.ToInt32( Console.ReadLine());

            if (edad > 18);
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }

        }
    }
}
