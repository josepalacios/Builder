using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Sandwich
    {
        public readonly Breadtype breadtype;
        public bool isToasted;
        public readonly List<string> vegetables;
    }
}
