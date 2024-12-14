using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class EditorLinkStyleConverter : JsonConverter<EditorLinkStyle>
    {
        public override bool CanConvert(Type t) => t == typeof(EditorLinkStyle);

        public override EditorLinkStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "ArrowsLine":
                    return EditorLinkStyle.ArrowsLine;
                case "CurvedArrow":
                    return EditorLinkStyle.CurvedArrow;
                case "DashedLine":
                    return EditorLinkStyle.DashedLine;
                case "StraightArrow":
                    return EditorLinkStyle.StraightArrow;
                case "ZigZag":
                    return EditorLinkStyle.ZigZag;
            }
            throw new Exception("Cannot unmarshal type EditorLinkStyle");
        }

        public override void Write(Utf8JsonWriter writer, EditorLinkStyle value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EditorLinkStyle.ArrowsLine:
                    JsonSerializer.Serialize(writer, "ArrowsLine", options);
                    return;
                case EditorLinkStyle.CurvedArrow:
                    JsonSerializer.Serialize(writer, "CurvedArrow", options);
                    return;
                case EditorLinkStyle.DashedLine:
                    JsonSerializer.Serialize(writer, "DashedLine", options);
                    return;
                case EditorLinkStyle.StraightArrow:
                    JsonSerializer.Serialize(writer, "StraightArrow", options);
                    return;
                case EditorLinkStyle.ZigZag:
                    JsonSerializer.Serialize(writer, "ZigZag", options);
                    return;
            }
            throw new Exception("Cannot marshal type EditorLinkStyle");
        }

        public static readonly EditorLinkStyleConverter Singleton = new EditorLinkStyleConverter();
    }
}
