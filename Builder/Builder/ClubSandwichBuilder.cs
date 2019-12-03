using System.Collections.Generic;
using static Builder.Sandwich;

namespace Builder
{
    public class ClubSandwichBuilder 
    {
        private Sandwich _sandwich;
        public ClubSandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public ClubSandwichBuilder AddCondiments()
        {
            _sandwich.hasMayo = true;
            _sandwich.hasMustard = true;
            return this;
        }

        public ClubSandwichBuilder ApplyMeatandChesse()
        {
            _sandwich.chesseType = Chessetype.Swiss;
            _sandwich.meatType = MeatType.Turkey;
            return this;
        }
        public ClubSandwichBuilder ApplyVegetables()
        {
            _sandwich.vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
            return this;
        }
        public ClubSandwichBuilder PrepareBread()
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
