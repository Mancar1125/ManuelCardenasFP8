namespace Tarea3Programacion
{
    /*Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio.Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes.Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, mostrar mensaje de error. 
9.5-10.0 Excelente
8.5-9.4 Muy bien 
7.5-8.4 Bien*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1;
            double Nota2;
            double Nota3;

            Console.WriteLine("Ingresa tu primera calificacion");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa tu segunda calificacion");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa tu tercera calificacion");
            Nota3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (Nota1 + Nota2 + Nota3) / 3.0;

            if (promedio < 7.5)
            {
                Console.WriteLine("Promedio:" + promedio + " (sos una mierda)");
            }
            else if (promedio == 7.5 && promedio <= 8.4)
            {
                Console.WriteLine("Promedio:" + promedio + " (GG)");
            }

            else if (promedio >= 8.5 && promedio <= 9.4)
            {
                Console.WriteLine("Promedio:" + promedio + " (God)");
            }

            else if (promedio >= 9.5 && promedio <= 10.0)
            {
                Console.WriteLine("Promedio:" + promedio + " (Uy pa, sos la verga mi pana)");
            }

            else if (promedio > 10.0)
            {
                Console.WriteLine("Promedio:" + promedio + " (Hermano, tas tostao, porque las calificaciones son de 0 a 10, revise bien)");
            }

        }
    }
}
