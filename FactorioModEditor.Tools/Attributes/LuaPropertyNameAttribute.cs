namespace FactorioModEditor.Tools.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class LuaPropertyNameAttribute : Attribute
{
    private string _name;

    public LuaPropertyNameAttribute(string name)
    {
        _name = name;
    }
}