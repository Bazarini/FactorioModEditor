namespace FactorioModEditor.Tools;

public class SerializerOptions
{
    public static SerializerOptions Default => new SerializerOptions()
    {
        KeyValueDelimeter = "=",
        ObjectsDelimeter = ",",
    };

    public string KeyValueDelimeter { get; private set; }

    public string ObjectsDelimeter { get; private set; }
}
