using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class Box<T>
    {

        public T Content { get; private set; }

        private bool hasContent;

        public void Put(T content)
        {
            if (hasContent)
            {
                throw new Exception("Ya hay algo en la caja");

            }

            this.Content = content;

            hasContent = true;
        }

        public T Extract()
        {
            if (!hasContent)
            {
                throw new Exception("No hay nada en la caja para extraer");
            }

            var content = this.Content;
            this.Content = default(T);
            hasContent = false;
            return content;

        }

    }
}
