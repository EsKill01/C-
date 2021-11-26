using System;
using System.Linq;

namespace FruitOrchard
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<Apple>(40000);
            box.FullBox(new FruitTree<Apple>());

            var apples = box.ToList();
            Console.WriteLine($"La manzama más grande pesa {apples.Max(i => i.Weight)} ");

            Console.WriteLine($"Esta caja pesa {box.Sum(i => i.Weight)}");

            var smallApples = apples.Where(i => i.Weight <= 250);

            Console.WriteLine($"Hay {smallApples.Count()} manzanas que pesan manzanas de 250 gramos");


            Console.WriteLine($"En la caja han cabido {box.Count()} manzanas");
            Console.ReadLine();
        }
    }
}
