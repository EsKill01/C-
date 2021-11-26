using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class DollFactory : IFactory<Doll>
    {
        public Doll MakeElement() => new Doll();
    }
}
