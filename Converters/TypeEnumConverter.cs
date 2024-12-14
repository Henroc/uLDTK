using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class TypeEnumConverter : JsonConverter<LayerType>
    {
        public override bool CanConvert(Type t) => t == typeof(LayerType);

        public override LayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "AutoLayer":
                    return LayerType.AutoLayer;
                case "Entities":
                    return LayerType.Entities;
                case "IntGrid":
                    return LayerType.IntGrid;
                case "Tiles":
                    return LayerType.Tiles;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void Write(Utf8JsonWriter writer, LayerType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case LayerType.AutoLayer:
                    JsonSerializer.Serialize(writer, "AutoLayer", options);
                    return;
                case LayerType.Entities:
                    JsonSerializer.Serialize(writer, "Entities", options);
                    return;
                case LayerType.IntGrid:
                    JsonSerializer.Serialize(writer, "IntGrid", options);
                    return;
                case LayerType.Tiles:
                    JsonSerializer.Serialize(writer, "Tiles", options);
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
