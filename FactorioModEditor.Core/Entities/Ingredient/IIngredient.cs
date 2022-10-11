namespace FactorioModEditor.Core.Entities.Ingredient;

public interface IIngredient : IRecipeItemIOBase
{
    double Amount { get; set; }

    double? MaximumTemperature { get; set; }

    double? MinimumTemperature { get; set; }
}