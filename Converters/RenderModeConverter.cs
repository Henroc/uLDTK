using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class RenderModeConverter : JsonConverter<RenderMode>
    {
        public override bool CanConvert(Type t) => t == typeof(RenderMode);

        public override RenderMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Cross":
                    return RenderMode.Cross;
                case "Ellipse":
                    return RenderMode.Ellipse;
                case "Rectangle":
                    return RenderMode.Rectangle;
                case "Tile":
                    return RenderMode.Tile;
            }
            throw new Exception("Cannot unmarshal type RenderMode");
        }

        public override void Write(Utf8JsonWriter writer, RenderMode value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case RenderMode.Cross:
                    JsonSerializer.Serialize(writer, "Cross", options);
                    return;
                case RenderMode.Ellipse:
                    JsonSerializer.Serialize(writer, "Ellipse", options);
                    return;
                case RenderMode.Rectangle:
                    JsonSerializer.Serialize(writer, "Rectangle", options);
                    return;
                case RenderMode.Tile:
                    JsonSerializer.Serialize(writer, "Tile", options);
                    return;
            }
            throw new Exception("Cannot marshal type RenderMode");
        }

        public static readonly RenderModeConverter Singleton = new RenderModeConverter();
    }
}
