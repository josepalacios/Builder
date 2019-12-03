using System.Collections.Generic;
using static Builder.Sandwich;

namespace Builder
{
    public class BaconSandwichBuilder
    {
        private Sandwich _sandwich;
        public BaconSandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public BaconSandwichBuilder AddCondiments()
        {
            _sandwich.hasMayo = false;
            _sandwich.hasMustard = true;
            return this;
        }

        public BaconSandwichBuilder ApplyMeatandChesse()
        {
            _sandwich.chesseType = Chessetype.American;
            _sandwich.meatType = MeatType.Turkey;
            return this;
        }
        public BaconSandwichBuilder ApplyVegetables()
        {
            _sandwich.vegetables = new List<string> { "Tomato", "Onion" };
            return this;
        }
        public BaconSandwichBuilder PrepareBread()
        {
            _sandwich.breadType = Breadtype.White;
            _sandwich.isToasted = true;
            return this;
        }

        public Sandwich Build()
        {
            return _sandwich;
        }
    }
}
