namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de compra");
            valorCompra=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana: l:Lunes, m:Martes, x:Miercoles, j:Jueves, v:Viernes, s:Sabado, d:Domingo");
            dia = Convert.ToChar(Console.ReadLine());
            switch(dia)
            {
                case 'l':
                    descuento=valorCompra*0.1f;
                    Console.WriteLine($"Hoy es Lunes, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miercoles, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sabado, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'd':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es Domingo, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                default:
                    Console.WriteLine("Debe ingresar un dia de la semana valido");
                    break;
            }

           
        }
    }
}
