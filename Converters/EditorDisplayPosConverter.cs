using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class EditorDisplayPosConverter : JsonConverter<EditorDisplayPos>
    {
        public override bool CanConvert(Type t) => t == typeof(EditorDisplayPos);

        public override EditorDisplayPos Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Above":
                    return EditorDisplayPos.Above;
                case "Beneath":
                    return EditorDisplayPos.Beneath;
                case "Center":
                    return EditorDisplayPos.Center;
            }
            throw new Exception("Cannot unmarshal type EditorDisplayPos");
        }

        public override void Write(Utf8JsonWriter writer, EditorDisplayPos value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EditorDisplayPos.Above:
                    JsonSerializer.Serialize(writer, "Above", options);
                    return;
                case EditorDisplayPos.Beneath:
                    JsonSerializer.Serialize(writer, "Beneath", options);
                    return;
                case EditorDisplayPos.Center:
                    JsonSerializer.Serialize(writer, "Center", options);
                    return;
            }
            throw new Exception("Cannot marshal type EditorDisplayPos");
        }

        public static readonly EditorDisplayPosConverter Singleton = new EditorDisplayPosConverter();
    }
}
