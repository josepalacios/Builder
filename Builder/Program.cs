using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var baconSandwichbuilder = new BaconSandwichBuilder();
            var baconSandwich = baconSandwichbuilder
                .PrepareBread()
                .ApplyMeatandChesse()
                .ApplyVegetables()
                .AddCondiments()
                .Build();
            baconSandwich.Display();

            var clubSandwichbuilder = new BaconSandwichBuilder();
            var clubSandwich = clubSandwichbuilder
                .PrepareBread()
                .ApplyMeatandChesse()
                .ApplyVegetables()
                .AddCondiments()
                .Build();
            clubSandwich.Display();

            Console.ReadKey();
        }
    }
}
