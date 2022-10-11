namespace FactorioModEditor.Tools;

public static class StringExtensions
{
    public static string Enquote(this string data)
    {
        return string.Format("\"{0}\"", data);
    }
}
