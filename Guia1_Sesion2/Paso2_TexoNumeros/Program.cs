namespace Paso2_TexoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "10";
            string texto2 = "5";
            string suma_de_textos = texto1 + texto2;
            Console.WriteLine("suma de textos:" + suma_de_textos);

            int numero1 = 10;
            int numero2 = 5;
            int suma_de_numeros = numero1 + numero2;
            Console.WriteLine("suma de enteros:" + suma_de_numeros);    

            Console.WriteLine($"Multiplicacion de enteros: {numero1 * numero2}");
            
        }
    }
}
