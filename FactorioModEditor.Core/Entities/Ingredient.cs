namespace FactorioModEditor.Core.Entities
{
    public abstract class Ingredient<T> : RecipeItemIOBase<T> where T : struct
    {
        private double _amount;

        public double Amount { get => _amount; set => _amount = value; }

        private double? _maximumTemperature;
        private double? _minimumTemperature;

        public double? MaximumTemperature { get => _maximumTemperature; set => _maximumTemperature = value; }

        public double? MinimumTemperature { get => _minimumTemperature; set => _minimumTemperature = value; }
    }

    public class FluidIngredient : Ingredient<double>, IIngredient
    {
    }

    public class ItemIngredient : Ingredient<uint>, IIngredient
    {
    }
}