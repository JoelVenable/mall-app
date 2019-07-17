using System;

namespace MallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();

            DollarItem MultiColorPen = new DollarItem()
            { Name = "Multi Colored Pen with 12 Colors"};

            Dollarama.AddToInventory("mcp", MultiColorPen);


            FoodStore Cinnabon = new FoodStore();

            FoodItem ClassicRoll = new FoodItem()
            {
                Name = "Classic Roll",
                Price = 3.50,
                Calories = 880
            };

            FoodItem CaramelPecanBon = new FoodItem()
            {
                Name = "Caramel PecanBon",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cpb", CaramelPecanBon);

        }
    }
}
