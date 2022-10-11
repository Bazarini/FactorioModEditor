namespace FactorioModEditor.Tools.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class LuaConvertedValue : Attribute
{
    private readonly string _propertyName;

    public LuaConvertedValue(string propertyName)
    {
        _propertyName = propertyName;
    }
}