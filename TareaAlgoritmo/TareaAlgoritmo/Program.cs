namespace TareaAlgoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingresa tu edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Welcome to my dirty side");
            }
            else
            {
                Console.WriteLine("No te queremos aqui abusadol");
            }

            Console.WriteLine("Ingresa Numero 1");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa Numero 2");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + numero2);
                Console.WriteLine(numero1 - numero2);
            }

            else
            {
                Console.WriteLine(numero1 * numero2);
                Console.WriteLine(numero1 / numero2);
            }



        } 
    }
}
