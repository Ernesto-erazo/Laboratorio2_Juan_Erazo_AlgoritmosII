namespace Laboratorio2_Juan_Erazo_AlgoritmosII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Cliente: ");
            string cliente = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Cantidad:");
            int cantidad = int.Parse(Console.ReadLine());

            decimal subtotal = precio * cantidad;
            Console.WriteLine($"Subtotal: {subtotal:c}");
        }
    }
}
