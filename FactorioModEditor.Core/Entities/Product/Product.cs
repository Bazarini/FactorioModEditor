using FactorioModEditor.Tools.Attributes;

namespace FactorioModEditor.Core.Entities.Product
{
    public abstract class Product<T> : RecipeItemIOBase<T>, IProduct where T : struct
    {
        private double? _amount;
        private double? _probability;
        private double? _amountMin;
        private double? _amountMax;
        private double? _temperature;

        public double? Amount { get => _amount; set => _amount = value; }

        [LuaPropertyName("amount_min")]
        public double? AmountMin { get => _amountMin; set => _amountMin = value; }

        [LuaPropertyName("amount_max")]
        public double? AmountMax { get => _amountMax; set => _amountMax = value; }

        public double? Probability { get => _probability; set => _probability = value; }

        public double? Temperature { get => _temperature; set => _temperature = value; }
    }
}