// See https://aka.ms/new-console-template for more information

using FactorioModEditor.Core;
using FactorioModEditor.Core.Entities;
using FactorioModEditor.Tools;

LuaWriter Serializer = new LuaWriter(Console.Out);
Recipe Recipe = new Recipe()
{
    Category = "123",
    Description = "234",
    Enabled = true,
    Energy = 0.0,
    Hidden = false,
    LocalizedName = "345",

    Ingredients = new List<IIngredient>() {
        new FluidIngredient() { MaximumTemperature = 20, Amount = 5, Name = "Steel", Type = ItemType.Item
        } },
};
Serializer.Write(Recipe);
Console.ReadKey();