using System.Collections;
using System.Reflection;
using System.Text;

namespace FactorioModEditor.Tools;

public class LuaWriter
{
    private readonly Encoding _encoding;
    private ushort _currentDepth = 0;
    private SerializerOptions _serializerOptions;
    private StringBuilder _valueBuilder;
    private TextWriter _stream;

    public LuaWriter(TextWriter stream, Encoding encoding)
    {
        _valueBuilder = new StringBuilder();
        _serializerOptions = SerializerOptions.Default;
        _stream = stream;
        _encoding = encoding;
    }

    public LuaWriter(TextWriter stream) : this(stream, Encoding.UTF8)
    {
    }

    public void Write(object obj)
    {
        WriteObject(obj);
        _stream.Write(_valueBuilder);
    }

    private void WriteDelimeter()
    {
        _valueBuilder.Append(_serializerOptions.KeyValueDelimeter);
    }

    private void WriteEnd()
    {
        _valueBuilder.Append(new string('\t', _currentDepth));
        _valueBuilder.Append("}");
    }

    private void WriteNewLine()
    {
        _valueBuilder.AppendLine();
    }

    private void WriteObject(object? obj)
    {
        if (obj == null)
            return;

        switch (obj)
        {
            case string castedObj:
                _valueBuilder.Append(castedObj.Enquote());
                return;

            case int castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case double castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case bool castedObj:
                _valueBuilder.Append(castedObj.ToString().ToLowerInvariant());
                return;

            case uint castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case ulong castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case long castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case char castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case short castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case ushort castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case byte castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case sbyte castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case float castedObj:
                _valueBuilder.Append(castedObj);
                return;

            case IEnumerable castedObject:

                WriteNewLine();
                WriteStart();
                WriteNewLine();
                _currentDepth++;

                var enumerator = castedObject.GetEnumerator();
                bool canMove = enumerator.MoveNext();
                while (canMove)
                {
                    WriteObject(enumerator.Current);
                    if (canMove = enumerator.MoveNext())
                    {
                        WriteObjectDelimeter();
                        WriteNewLine();
                    }
                }
                _currentDepth--;
                WriteNewLine();
                WriteEnd();
                return;

            default:
                break;
        }

        var objType = obj.GetType();

        if (objType.IsEnum)
        {
            WriteObject(obj.ToString());
            return;
        }

        if (_currentDepth > 0)
            WriteNewLine();

        var props = objType.GetProperties();

        WriteStart();
        WriteNewLine();
        _currentDepth++;

        bool writeDelimeter = false;
        for (int i = 0; i < props.Length; i++)
        {
            PropertyInfo? prop = props[i];
            var value = prop?.GetValue(obj);
            if (value == null)
            {
                continue;
            }

            if (writeDelimeter)
            {
                WriteObjectDelimeter();
                WriteNewLine();
            }

            WriteProperty(prop);
            WriteDelimeter();
            WriteObject(value);
            writeDelimeter = props.Length - i > 1;
        }
        _currentDepth--;

        WriteNewLine();
        WriteEnd();
    }

    private void WriteObjectDelimeter()
    {
        _valueBuilder.Append(_serializerOptions.ObjectsDelimeter);
    }

    private bool WriteProperty(PropertyInfo? propertyInfo)
    {
        if (propertyInfo == null)
            return false;

        var nameFromAttribute = propertyInfo?.CustomAttributes?.FirstOrDefault(a => a.AttributeType == typeof(LuaPropertyNameAttribute));
        _valueBuilder.Append(new string('\t', _currentDepth));

        if (nameFromAttribute != null)
        {
            _valueBuilder.Append(nameFromAttribute.ConstructorArguments[0].Value);
            return true;
        }

        _valueBuilder.Append(propertyInfo?.Name.ToLower());
        return true;
    }

    private void WriteStart()
    {
        _valueBuilder.Append(new string('\t', _currentDepth));
        _valueBuilder.Append("{");
    }
}