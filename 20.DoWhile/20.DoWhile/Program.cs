using System.Security.Cryptography;

namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20.Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber: El número de partidos perdidos, El número de partidos empatados, El número de partidos ganados, El porcentaje de partidos perdidos, El porcentaje de partidos empatados, El porcentaje de partidos ganados
            int partidosGanados = 0;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
            int partidosJugados = 0;
            int totalPartidos = 30;
            do
            {
                Console.WriteLine("Ingrese el resultado del partido (G: Ganado, P: Perdido, E: Empatado): ");
                string resultado = Console.ReadLine().ToUpper();
                switch (resultado)
                {
                    case "G":
                        partidosGanados++;
                        break;
                    case "P":
                        partidosPerdidos++;
                        break;
                    case "E":
                        partidosEmpatados++;
                        break;

                }
                partidosJugados++;
            } while (partidosJugados < totalPartidos);
            Console.WriteLine($"Total de partidos jugados: {totalPartidos}");
            Console.WriteLine($"Partidos Ganados: {partidosGanados} ({(partidosGanados * 100) / totalPartidos}%)");
            Console.WriteLine($"Partidos Empatados: {partidosEmpatados} ({(partidosEmpatados * 100) / totalPartidos}%)");
            Console.WriteLine($"Partidos Perdidos: {partidosPerdidos} ({(partidosPerdidos * 100) / totalPartidos}%)");
        }
    }
}
