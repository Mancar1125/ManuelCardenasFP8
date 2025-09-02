namespace Parcial1.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mesNacimiento = "";
            string signoZodiacal = "";

            Console.WriteLine("Ingresa el mes de nacimiento (ejemplo: marzo):");
            mesNacimiento = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese el signo zodiacal (ejemplo: aries):");
            signoZodiacal = Console.ReadLine().ToLower();

            //Fuego

            if ((mesNacimiento == "marzo" || mesNacimiento == "abril" || mesNacimiento == "julio" || mesNacimiento == "agosto" || mesNacimiento == "noviembre" || mesNacimiento == "diciembre") && (signoZodiacal == "aries" || signoZodiacal == "leo" || signoZodiacal == "sagitario"))
            {
                Console.WriteLine("El elemento de la persona es Fuego");
            }

            //Tierra
            else if ((mesNacimiento == "abril" || mesNacimiento == "mayo" || mesNacimiento == "agosto" || mesNacimiento == "septiembre" || mesNacimiento == "diciembre" || mesNacimiento == "enero") && (signoZodiacal == "tauro" || signoZodiacal == "virgo" || signoZodiacal == "capricornio"))
            {
                Console.WriteLine("El elemento de la persona es Tierra");
            }

            //Aire
            else if ((mesNacimiento == "mayo" || mesNacimiento == "junio" || mesNacimiento == "septiembre" || mesNacimiento == "octubre" || mesNacimiento == "enero" || mesNacimiento == "febrero") && (signoZodiacal == "geminis" || signoZodiacal == "libra" || signoZodiacal == "acuario"))
            {
                Console.WriteLine("El elemento de la persona es Aire");
            }

            //Agua
            else if ((mesNacimiento == "marzo" || mesNacimiento == "junio" || mesNacimiento == "julio" || mesNacimiento == "octubre" || mesNacimiento == "noviembre" || mesNacimiento == "febrero") && (signoZodiacal == "cancer" || signoZodiacal == "escorpio" || signoZodiacal == "piscis"))
            {
                Console.WriteLine("El elemento de la persona es Aire");
            }

            else
            {
                Console.WriteLine("No corresponde");
            }
        }
    }
}