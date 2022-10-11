namespace FactorioModEditor.Core.Entities;

public interface IIngredient : IRecipeItemIOBase
{
    double Amount { get; set; }

    double? MaximumTemperature { get; set; }

    double? MinimumTemperature { get; set; }
}