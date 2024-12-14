using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class WorldLayoutConverter : JsonConverter<WorldLayout>
    {
        public override bool CanConvert(Type t) => t == typeof(WorldLayout);

        public override WorldLayout Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Free":
                    return WorldLayout.Free;
                case "GridVania":
                    return WorldLayout.GridVania;
                case "LinearHorizontal":
                    return WorldLayout.LinearHorizontal;
                case "LinearVertical":
                    return WorldLayout.LinearVertical;
            }
            throw new Exception("Cannot unmarshal type WorldLayout");
        }

        public override void Write(Utf8JsonWriter writer, WorldLayout value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case WorldLayout.Free:
                    JsonSerializer.Serialize(writer, "Free", options);
                    return;
                case WorldLayout.GridVania:
                    JsonSerializer.Serialize(writer, "GridVania", options);
                    return;
                case WorldLayout.LinearHorizontal:
                    JsonSerializer.Serialize(writer, "LinearHorizontal", options);
                    return;
                case WorldLayout.LinearVertical:
                    JsonSerializer.Serialize(writer, "LinearVertical", options);
                    return;
            }
            throw new Exception("Cannot marshal type WorldLayout");
        }

        public static readonly WorldLayoutConverter Singleton = new WorldLayoutConverter();
    }
}
