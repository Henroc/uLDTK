using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class TileModeConverter : JsonConverter<TileMode>
    {
        public override bool CanConvert(Type t) => t == typeof(TileMode);

        public override TileMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Single":
                    return TileMode.Single;
                case "Stamp":
                    return TileMode.Stamp;
            }
            throw new Exception("Cannot unmarshal type TileMode");
        }

        public override void Write(Utf8JsonWriter writer, TileMode value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case TileMode.Single:
                    JsonSerializer.Serialize(writer, "Single", options);
                    return;
                case TileMode.Stamp:
                    JsonSerializer.Serialize(writer, "Stamp", options);
                    return;
            }
            throw new Exception("Cannot marshal type TileMode");
        }

        public static readonly TileModeConverter Singleton = new TileModeConverter();
    }
}
