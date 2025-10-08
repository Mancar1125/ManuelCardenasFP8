namespace _25.ParcialCiclosManuelCardenasVilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En el programa de Ingeniería Mecánica, que cuenta con 20 estudiantes, se desea procesar información sobre la ocupación y el género de los alumnos.El programa debe realizar las siguientes acciones: Ingresar por teclado la ocupación de cada estudiante(trabaja o estudia) y su género(hombre o mujer). Calcular y mostrar el porcentaje de estudiantes que trabajan y el porcentaje de los que estudian respecto al total del grupo. Calcular y mostrar el número de mujeres que trabajan. Calcular y mostrar el número de hombres que estudian.

            int totalEstudiantes = 5;
            int estudiantesQueTrabajan = 0;
            int estudiantesQueEstudian = 0;
            int mujeresQueTrabajan = 0;
            int hombresQueEstudian = 0;
            string ocupacion;
            string genero;

            for (int contador = 1; contador <= totalEstudiantes; contador++)
            {
                
                do
                {
                    Console.WriteLine($"Ingrese la ocupación del estudiante {contador} (trabaja/estudia): ");
                    ocupacion = Console.ReadLine().ToLower();

                    if (ocupacion != "trabaja" && ocupacion != "estudia")
                    {
                        Console.WriteLine("Ocupación inválida. Por favor, ingrese 'trabaja' o 'estudia'.");
                    }

                } while (ocupacion != "trabaja" && ocupacion != "estudia");

                
                do
                {
                    Console.WriteLine($"Ingrese el género del estudiante {contador} (hombre/mujer): ");
                    genero = Console.ReadLine().ToLower();

                    if (genero != "hombre" && genero != "mujer")
                    {
                        Console.WriteLine("Género incorrecto. Por favor, ingrese 'hombre' o 'mujer'.");
                    }

                } while (genero != "hombre" && genero != "mujer");

                
                if (ocupacion == "trabaja")
                {

                    estudiantesQueTrabajan++;
                    if (genero == "mujer")
                    {
                        mujeresQueTrabajan++;
                    }
                }
                else if (ocupacion == "estudia")
                {
                    estudiantesQueEstudian++;
                    if (genero == "hombre")
                    {
                        hombresQueEstudian++;

                    }
                }
            }

            double porcentajeQueTrabajan = (double)estudiantesQueTrabajan / totalEstudiantes * 100;
            double porcentajeQueEstudian = (double)estudiantesQueEstudian / totalEstudiantes * 100;

            Console.WriteLine($"Porcentaje de estudiantes que trabajan: {porcentajeQueTrabajan:F2}%");
            Console.WriteLine($"Porcentaje de estudiantes que estudian: {porcentajeQueEstudian:F2}%");
            Console.WriteLine($"Número de mujeres que trabajan: {mujeresQueTrabajan}");
            Console.WriteLine($"Número de hombres que estudian: {hombresQueEstudian}");


        }
    }
}
