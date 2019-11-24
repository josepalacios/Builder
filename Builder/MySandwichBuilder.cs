using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Sandwich;

namespace Builder
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.hasMayo = false;
            sandwich.hasMustard = true;
        }

        public override void ApplyMeatandChesse()
        {
            sandwich.chesseType = Chessetype.American;
            sandwich.meatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Breadtype.White;
            sandwich.isToasted = true;
        }
    }
}
