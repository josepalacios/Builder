using Builder.Enumerables;
using System.Collections.Generic;

namespace Builder
{
    public class BaconSandwichBuilder : SandwichBuilder
    {
        private Sandwich _sandwich;
        public BaconSandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public BaconSandwichBuilder AddCondiments()
        {
            _sandwich.HasMayo = false;
            _sandwich.HasMustard = true;
            return this;
        }

        public BaconSandwichBuilder ApplyMeatandChesse()
        {
            _sandwich.chesseType = ChesseType.American;
            _sandwich.meatType = MeatType.Turkey;
            return this;
        }
        public BaconSandwichBuilder ApplyVegetables()
        {
            _sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
            return this;
        }
        public BaconSandwichBuilder PrepareBread()
        {
            _sandwich.breadType = Breadtype.White;
            _sandwich.IsToasted = true;
            return this;
        }
        public override Sandwich Build()
        {
            return _sandwich;
        }
    }
}
