using System;

namespace TP1_EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenasss");
            Console.Title = "Superficie y Perimetro de un Rectángulo.. ";

            float LadoMayor, Ladomenor, Superficie, Perimetro;

            Console.Write("Ingrese el lado mayor del rectángulo: ");
            LadoMayor = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el lado menor del rectángulo: ");
            Ladomenor = Convert.ToSingle(Console.ReadLine());

            Superficie = LadoMayor * Ladomenor;
            Perimetro = (2 * LadoMayor) + (2 * Ladomenor);

            Console.WriteLine($"Para esas dimensiones, tendremos una superficie de {Superficie} mtrs^2 y un Perímetro de {Perimetro} mtrs ");
        }
    }
}
