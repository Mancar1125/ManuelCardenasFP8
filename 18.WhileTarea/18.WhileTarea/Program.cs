namespace _18.WhileTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.
            int usuarios = 0;
            double sumaSaldos = 0;
            string continuar;

            do
            {

                Console.Write("Ingrese el nombre del usuario: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el número de cuenta: ");
                string cuenta = Console.ReadLine();

                Console.Write("Ingrese el saldo: ");
                double saldo = Convert.ToDouble(Console.ReadLine());


                usuarios++;
                sumaSaldos += saldo;


                if (saldo > 3000000)
                {
                    Console.WriteLine($"Usuario: {nombre} | Cuenta: {cuenta} | Saldo: {saldo} → Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"Usuario: {nombre} | Cuenta: {cuenta} | Saldo: {saldo} → No es apto para el crédito");
                }


                Console.Write("¿Desea ingresar otro usuario? (s/n): ");
                continuar = Console.ReadLine();

            } while (continuar.ToLower() != "n");


            Console.WriteLine($"\nCantidad total de usuarios registrados: {usuarios}");
            Console.WriteLine($"Promedio de saldos: {sumaSaldos / usuarios}");

        }
    }
}
