using System;

namespace ToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory<Doll> factory = new DollFactory();

            var boxes = BoxHelper.GenerateBoxes<Doll>(50, factory.MakeElement);

            Console.WriteLine("Hello World!");
        }
    }
}
