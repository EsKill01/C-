using System;

namespace ToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var doll = new Doll();
            var box = new Box<Doll>();
            var box2 = new Box<Carr>();


            box.Put(doll);
            box2.Put(new Carr());

            Console.WriteLine("Hello World!");
        }
    }
}
