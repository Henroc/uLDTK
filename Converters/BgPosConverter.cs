using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class BgPosConverter : JsonConverter<BgPos>
    {
        public override bool CanConvert(Type t) => t == typeof(BgPos);

        public override BgPos Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Contain":
                    return BgPos.Contain;
                case "Cover":
                    return BgPos.Cover;
                case "CoverDirty":
                    return BgPos.CoverDirty;
                case "Repeat":
                    return BgPos.Repeat;
                case "Unscaled":
                    return BgPos.Unscaled;
            }
            throw new Exception("Cannot unmarshal type BgPos");
        }

        public override void Write(Utf8JsonWriter writer, BgPos value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case BgPos.Contain:
                    JsonSerializer.Serialize(writer, "Contain", options);
                    return;
                case BgPos.Cover:
                    JsonSerializer.Serialize(writer, "Cover", options);
                    return;
                case BgPos.CoverDirty:
                    JsonSerializer.Serialize(writer, "CoverDirty", options);
                    return;
                case BgPos.Repeat:
                    JsonSerializer.Serialize(writer, "Repeat", options);
                    return;
                case BgPos.Unscaled:
                    JsonSerializer.Serialize(writer, "Unscaled", options);
                    return;
            }
            throw new Exception("Cannot marshal type BgPos");
        }

        public static readonly BgPosConverter Singleton = new BgPosConverter();
    }
}
