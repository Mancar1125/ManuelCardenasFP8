namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            //Vectores
            int[] numeros=new int[5]; //El vector numeros tiene 5 posiciones
            string[] nombres=new string[4]; //El vector nombres tiene 3 posiciones

            //Asignacion de valores a las posiciones
            numeros[0]=20;
            numeros[1]=15;
            numeros[2]=5;
            numeros[3]=30;
            numeros[4]=45;
            //numeros[5]=85; //Error, fuera de rango
            int [] numeros1 = new int[] {5,12,4,7,9,21};
            int[] numeros2 = { 4, 12, 4, 7, 9, 21 };
            //Yo puedo recorrer un vector para llenarlo de datos o para recuperar sus datos
            char[] caracter = new char[4];

            for (int i=0; i < 4;i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posicion {i+1}, con indice {i}:");
                caracter[i]=Convert.ToChar
                (Console.ReadLine());
            }

            Console.WriteLine($"El vector caracter, en la posicion 3, tiene almacenado el dato: {caracter[2]}");

            for (int i=0; i < 4;i++)
            {
                Console.WriteLine($"El vector caracter, en la posicion {i+1}, con indice {i}, tiene almacenado el dato: {caracter[i]}");
            }

            for (int i = 0; i < caracter.Length; i++) //Length me devuelve el rango del vector
            {
                Console.Write(caracter[i]+ " | ");
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la posición {i + 1}, con índice {i}:");
                nombres[i] = Console.ReadLine();
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write(nombres[i] + " | ");
            }


        }
    }
}
