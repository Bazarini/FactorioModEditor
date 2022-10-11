namespace FactorioModEditor.Core
{
    public abstract class RecipeItemIOBase<T> : IRecipeItemIOBase where T : struct
    {
        private T? _catalystAmount;
        private string _name;
        private ItemType _type;

        public T? CatalystAmount { get => _catalystAmount; set => _catalystAmount = value; }

        public string Name { get => _name; set => _name = value; }

        public ItemType Type { get => _type; set => _type = value; }

        object? IRecipeItemIOBase.CatalystAmount { get => CatalystAmount; set => CatalystAmount = value as T?; }
    }
}