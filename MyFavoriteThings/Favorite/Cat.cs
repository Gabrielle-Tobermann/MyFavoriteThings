using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Favorite
{
    class Cat
    {
        public string Name { get; set; }
        public bool IsScreaming { get; set; }
        public int LastFed { get; set; }
        public bool wantsToGoOut { get; set; }

        public Cat(string name, bool isScreaming)
        {
            Name = name;
            IsScreaming = isScreaming;
        }

        public void WhyIsTheCatScreaming()
        {
            if (IsScreaming == true)
            {
                Console.WriteLine($"Enter the number of hours since {Name} had a snack");
                LastFed = Int16.Parse(Console.ReadLine());

                if (LastFed > 1)
                {
                    Console.WriteLine($"{Name} is screaming because he wants another snack.");
                }
                else
                {
                    Console.WriteLine($"{Name} is screaming because he wants to go outside.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is not screaming. {Name} is probably asleep");
            }
        }
    }
}
