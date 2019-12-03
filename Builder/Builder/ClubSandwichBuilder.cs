using Builder.Enumerables;
using System.Collections.Generic;

namespace Builder
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        private Sandwich _sandwich;
        public ClubSandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public ClubSandwichBuilder AddCondiments()
        {
            _sandwich.HasMayo = true;
            _sandwich.HasMustard = true;
            return this;
        }

        public ClubSandwichBuilder ApplyMeatandChesse()
        {
            _sandwich.chesseType = ChesseType.Swiss;
            _sandwich.meatType = MeatType.Turkey;
            return this;
        }
        public ClubSandwichBuilder ApplyVegetables()
        {
            _sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
            return this;
        }
        public ClubSandwichBuilder PrepareBread()
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
