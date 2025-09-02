namespace Tarea2Programacion
{
    internal class Program
    {
        /*Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares. 
Si el usuario se queda más de 3 noches se le aplica un porcentaje de descuento del 17% y si no se aplica un porcentaje de descuento del 2%. 
Mostrar un mensaje con el monto total que debe pagar el cliente, sabiendo que el usuario indica cuántas noches se va a quedar en la hostería.*/
        static void Main(string[] args)
        {
            int Noches = 1;
            int PrecioNoche = 200;
            double descuento;

            Console.WriteLine("Ingresa el numero de noches de hospedaje");

            Noches = Convert.ToInt32(Console.ReadLine());

            if (Noches > 3)
            {
                descuento = 0.17;
            }
            else
            {
                descuento = 0.02;
            }

            // Calcular el precio total
            double totalSinDescuento = Noches * PrecioNoche;

            //Precio Total - descuento
            double totalConDescuento = totalSinDescuento - (totalSinDescuento * descuento);

            Console.WriteLine($"El monto total a pagar es: ${totalConDescuento:F2}");
        }
    }
}
