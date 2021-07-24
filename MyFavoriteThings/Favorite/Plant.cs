using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Favorite
{
    class Plant
    {
        public string Name { get; set; }
        public string LightConditions { get; set; }
        public bool IsWilting { get; set; }

        public Plant(string name, string lightConditions, bool isWilting)
        {
            Name = name;
            LightConditions = lightConditions;
            IsWilting = isWilting;
        }

        public void Water()
        {
            if (IsWilting == true)
            {
                Console.WriteLine($"Go water the {Name}");
            }
            else
            {
                Console.WriteLine($"Don't water your {Name}");
            }
        }

        public void DetermineLocation()
        {
            if (LightConditions.ToLower() == "low light")
            {
                Console.WriteLine("Place the plant in indirect sunlight.");
            }
            else if (LightConditions.ToLower() == "high light")
            {
                Console.WriteLine("Place the plant on a window.");
            }
        }
    }
}
