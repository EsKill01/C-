using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrchard
{
    public class FruitTree<T> where T : Fruit, new()
    {
        public T CreateFruit()
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            return new T()
            {
                Weight = rnd.Next(180, 301)
            };
        }
    }
}
