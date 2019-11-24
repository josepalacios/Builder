using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Sandwich;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSandwich = new SandwichMaker(new MySandwichBuilder());
            firstSandwich.BuildSandwich();
            var classicSandwich = firstSandwich.GetSandwich();
            classicSandwich.Display();

            var secondSandwich = new SandwichMaker(new ClubSandwichBuilder());
            secondSandwich.BuildSandwich();
            var clubSandwich = secondSandwich.GetSandwich();
            clubSandwich.Display();

            Console.ReadKey();
        }
    }
}
