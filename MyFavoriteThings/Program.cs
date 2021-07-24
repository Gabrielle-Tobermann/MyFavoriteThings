using MyFavoriteThings.Favorite;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var peaceLilly = new Plant("Peace Lilly", "low light", false);
            peaceLilly.Water();
            peaceLilly.DetermineLocation();

            var aloe = new Plant("Aloe", "low light", true);
            aloe.Water();
            aloe.DetermineLocation();

            var Momert = new Cat("Momert", true);
            Momert.WhyIsTheCatScreaming();

            var Holden = new Cat("Holen", false);
            Holden.WhyIsTheCatScreaming();
        }
    }
}
