namespace FactorioModEditor.Core.Entities;

public interface IProduct
{
    double? Amount { get; set; }
    double? AmountMax { get; set; }
    double? AmountMin { get; set; }
    double? Probability { get; set; }
    double? Temperature { get; set; }
}