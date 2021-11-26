using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrchard
{
    public static class BoxExtensions
    {
        public static void FullBox<T>(this Box<T> box, FruitTree<T> tree) where T : Fruit, new()
        {
            do
            {
                try
                {
                    box.Add(tree.CreateFruit());
                }
                catch (Exception)
                {

                    break;
                }
            } while (true);
        }
    }
}
