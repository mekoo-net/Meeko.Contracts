using System.Text.Json;
using System.Text.Json.Serialization;

namespace Meeko.Common.Web;

/// <summary>把 <see cref="long"/> 序列化为 JSON string，反序列化兼容 string 与 number。</summary>
public sealed class LongToStringConverter : JsonConverter<long>
{
    public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (long.TryParse(s, out var v)) return v;
            throw new JsonException($"Cannot convert \"{s}\" to long.");
        }

        return reader.GetInt64();
    }

    public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString());
}

/// <summary>可空版本，用于 <c>long?</c> 字段。</summary>
public sealed class NullableLongToStringConverter : JsonConverter<long?>
{
    public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;
        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (string.IsNullOrEmpty(s)) return null;
            if (long.TryParse(s, out var v)) return v;
            throw new JsonException($"Cannot convert \"{s}\" to long.");
        }

        return reader.GetInt64();
    }

    public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
    {
        if (value is null) writer.WriteNullValue();
        else writer.WriteStringValue(value.Value.ToString());
    }
}
