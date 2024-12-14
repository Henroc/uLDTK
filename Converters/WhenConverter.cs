using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class WhenConverter : JsonConverter<When>
    {
        public override bool CanConvert(Type t) => t == typeof(When);

        public override When Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "AfterLoad":
                    return When.AfterLoad;
                case "AfterSave":
                    return When.AfterSave;
                case "BeforeSave":
                    return When.BeforeSave;
                case "Manual":
                    return When.Manual;
            }
            throw new Exception("Cannot unmarshal type When");
        }

        public override void Write(Utf8JsonWriter writer, When value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case When.AfterLoad:
                    JsonSerializer.Serialize(writer, "AfterLoad", options);
                    return;
                case When.AfterSave:
                    JsonSerializer.Serialize(writer, "AfterSave", options);
                    return;
                case When.BeforeSave:
                    JsonSerializer.Serialize(writer, "BeforeSave", options);
                    return;
                case When.Manual:
                    JsonSerializer.Serialize(writer, "Manual", options);
                    return;
            }
            throw new Exception("Cannot marshal type When");
        }

        public static readonly WhenConverter Singleton = new WhenConverter();
    }
}
