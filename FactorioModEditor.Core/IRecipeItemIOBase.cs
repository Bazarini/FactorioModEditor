namespace FactorioModEditor.Core;

public interface IRecipeItemIOBase
{
    object? CatalystAmount { get; set; }

    string Name { get; set; }

    ItemType Type { get; set; }
}