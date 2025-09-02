using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes. */

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese Numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Numero 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num2 != num3 && num3 != num1)
            {
                Console.WriteLine("Los Numeros son diferentes");

                //NumeroMayor

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"Número mayor: {num1}");
                }
                else if (num2 > num3 && num2 > num1)
                {
                    Console.WriteLine($"Número mayor: {num2}");
                }
                else if (num3 > num1 && num3 > num2)
                {
                    Console.WriteLine($"Número mayor: {num3}");
                }
                else if (num1 > num2 && num1 < num3)
                {
                    Console.WriteLine($"Numero mayor: {num3}");
                }

                //Numero Medio

                if (num1 < num2 && num1 > num3)
                {
                    Console.WriteLine($"Número medio: {num1}");
                }
                else if (num2 < num3 && num2 > num1)
                {
                    Console.WriteLine($"Número medio: {num2}");
                }
                else if (num3 < num1 && num3 > num2)
                {
                    Console.WriteLine($"Número medio: {num3}");
                }
                else if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine($"Numero medio: {num3}");
                }
                //Numero Menor

                if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine($"Número menor: {num1}");
                }
                else if (num2 < num3 && num2 < num1)
                {
                    Console.WriteLine($"Número menor: {num2}");
                }
                else if (num3 < num1 && num3 < num2)
                {
                    Console.WriteLine($"Número menor: {num3}");
                }
                else if (num1 < num2 && num1 > num3)
                {
                    Console.WriteLine($"Numero menor: {num3}");
                }


            }

            else
            {
                Console.WriteLine("Los numeros no son todos diferentes, pare bolas");

            }

            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
a.Permita ingresar por teclado si el personaje está en estado invencible(True).
b.La cantidad de munición que tiene el personaje en el momento será calculada por el
sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
Ejemplo:
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
            Console.WriteLine(numero);
            c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
            no hacer nada.*/

            bool invencible;
            int municion;

            Random rnd = new Random();
            municion = rnd.Next(0, 5); //Devuelve un número entre 0 y 5 

            Console.WriteLine("El personaje es invencible (true/false): ");
            invencible = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"La municion es: {municion}");

            if (invencible && municion >= 1)
            {
                Console.WriteLine("El personaje esta disparando");
            }

            /*El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha), 
crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
 Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
derecha
 Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
 En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
dirección” */
            char direccion = ' ';

            Console.WriteLine("Ingrese direccion del personaje: d: Derecha, i: Izquierda");
            direccion = Convert.ToChar(Console.ReadLine());

            switch (direccion)
            {
                case 'd':
                    Console.WriteLine("El personaje se mueve hacia la derecha");
                    break;

                case 'i':
                    Console.WriteLine("El personaje se mueve hacia la izquierda");
                    break;

                default:
                    Console.WriteLine("no me puedo mover en otra direccion");
                    break;
            }

            /*Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1, y1), 
P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 
P3.La distancia entre dos puntos está dada por la siguiente formula:
            d = √((x2 - x1)² +(y2 - y1)²) 
Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
condiciones no se cumplen. */

            // Coordenadas de los 3 puntos


            float x1;
            float y1;
            float x2;
            float y2;
            float x3;
            float y3;

            //Coordenadas

            Console.WriteLine("Ingrese la coordenada del punto P1 (x1):");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada del punto P1 (y1):");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada del punto P2 (x2):");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada del punto P2 (y2):");
            y2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada del punto P3 (x3):");
            x3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada del punto P3 (y3):");
            y3 = float.Parse(Console.ReadLine());

            //Cuadrados
            float dTotal1 = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            float dTotal2 = (x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2);
            float dTotal3 = (x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1);


            Console.WriteLine($"Distancia P1 -> P2: {dTotal1}");
            Console.WriteLine($"Distancia P2 -> P3: {dTotal2}");
            Console.WriteLine($"Distancia P1 -> P3: {dTotal3}");



            float area2 = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if (area2 != 0)
            {
                Console.WriteLine("Los puntos forman un triángulo.");
            }
            else
            {
                Console.WriteLine(" Los puntos son colineales, NO forman un triángulo.");
            }

            /*  5.El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
  el usuario ingrese, y de la cantidad de vidas que posee.Crear un programa que permita:
   Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. 
  (Función Random) 
   Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
  caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
  ninguna acción”. 
   Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
  carácter que se ingrese: 
  o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
  o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana” 
  o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
  o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” */

            int vidas;
            char acciones;

            Random rnd2 = new Random();
            vidas = rnd2.Next(0, 5); //Devuelve un número entre 0 y 5 
            Console.WriteLine($"La vida es: {vidas}");

            if (vidas >= 1)
            {
                Console.WriteLine("Puedes realizar acciones");

                Console.WriteLine("Ingrese la accion: c: disparar, x: habla con la rana, t: turbo, i: invencible");

                acciones = Convert.ToChar(Console.ReadLine());
                switch (acciones)

                {
                    case 'c':

                        Console.WriteLine("El personaje esta disparando");
                        break;
                    case 'x':

                        Console.WriteLine("El personaje esta hablando con la rana");
                        break;
                    case 't':

                        Console.WriteLine("El personaje esta modo turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje esta invencible");
                        break;

                }
            }
            else
            {
                Console.WriteLine("No puedes realizar acciones");
            }
        }
    }
}
