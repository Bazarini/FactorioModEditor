namespace FactorioModEditor.Core.Entities.Product;

public interface IProduct : IRecipeItemIOBase
{
    double? Amount { get; set; }

    double? AmountMax { get; set; }

    double? AmountMin { get; set; }

    double? Probability { get; set; }

    double? Temperature { get; set; }
}