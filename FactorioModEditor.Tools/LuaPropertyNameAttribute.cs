namespace FactorioModEditor.Tools;

[AttributeUsage(AttributeTargets.Property)]
public class LuaPropertyNameAttribute : Attribute
{
    private string _name;

    public LuaPropertyNameAttribute(string name)
    {
        _name = name;
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class LuaIgnoreAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public class LuaConvertedValue : Attribute
{
    private readonly string _propertyName;

    public LuaConvertedValue(string propertyName)
    {
        _propertyName = propertyName;
    }
}