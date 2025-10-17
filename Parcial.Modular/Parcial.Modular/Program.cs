using System;
using System.Collections.Generic;

namespace Parcial.Modular
{
    internal class Program
    {
        // Lista de tareas compartida (static para accesibilidad desde métodos estáticos)
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Contar vocales y consonantes en una palabra");
                Console.WriteLine("2. Gestionar lista de tareas");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                string? opt = Console.ReadLine();

                if (opt == "0") break;
                if (opt == "1") EjecutarContadorVocales();
                else if (opt == "2") EjecutarGestorTareas();
                else Console.WriteLine("Opción no válida.");
            }
        }

        // ---------- Programa 1: contar vocales y consonantes ----------
        static void EjecutarContadorVocales()
        {
            Console.Write("Ingrese una palabra: ");
            string? input = Console.ReadLine()?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No se ingresó ninguna palabra.");
                return;
            }

            // Tomar el primer token si el usuario ingresó espacios
            string palabra = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)[0];
            char[] vector = ToCharVector(palabra);
            var (vocales, consonantes) = CountVowelsAndConsonants(vector);

            Console.WriteLine();
            Console.WriteLine($"Palabra: {palabra}");
            Console.WriteLine($"Vector de caracteres: [{string.Join(", ", vector)}]");
            Console.WriteLine($"Vocales: {vocales}");
            Console.WriteLine($"Consonantes: {consonantes}");
        }

        static char[] ToCharVector(string s) => s.ToCharArray();

        static (int vowels, int consonants) CountVowelsAndConsonants(char[] chars)
        {
            int v = 0, c = 0;
            foreach (char ch in chars)
            {
                if (!char.IsLetter(ch))
                    continue; // Ignorar números y signos

                if (IsVowel(ch)) v++;
                else c++;
            }
            return (v, c);
        }

        static bool IsVowel(char ch)
        {
            // Comprueba vocales en minúscula (incluye acentuadas y diéresis)
            char lower = char.ToLowerInvariant(ch);
            return "aeiouáéíóúü".IndexOf(lower) >= 0;
        }

        // ---------- Programa 2: gestor de tareas ----------
        static void EjecutarGestorTareas()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Gestor de tareas - opciones:");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea por índice");
                Console.WriteLine("3. Mostrar tareas");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Opción: ");
                string? opt = Console.ReadLine();

                if (opt == "0") break;
                if (opt == "1")
                {
                    Console.Write("Descripción de la tarea: ");
                    string? desc = Console.ReadLine()?.Trim() ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(desc))
                        AgregarTarea(desc);
                    else
                        Console.WriteLine("Tarea vacía no agregada.");
                }
                else if (opt == "2")
                {
                    MostrarTareas();
                    if (tareas.Count == 0) continue;
                    Console.Write("Índice a eliminar (1-based): ");
                    if (int.TryParse(Console.ReadLine(), out int idx))
                        EliminarTarea(idx - 1);
                    else
                        Console.WriteLine("Índice inválido.");
                }
                else if (opt == "3")
                {
                    MostrarTareas();
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }

        static void AgregarTarea(string tarea)
        {
            tareas.Add(tarea);
            Console.WriteLine("Tarea agregada.");
        }

        static void EliminarTarea(int indice)
        {
            if (indice < 0 || indice >= tareas.Count)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }
            tareas.RemoveAt(indice);
            Console.WriteLine("Tarea eliminada.");
        }

        static void MostrarTareas()
        {
            Console.WriteLine();
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas.");
                return;
            }

            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
    }
}
