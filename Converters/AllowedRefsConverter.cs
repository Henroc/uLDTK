using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class AllowedRefsConverter : JsonConverter<AllowedRefs>
    {
        public override bool CanConvert(Type t) => t == typeof(AllowedRefs);

        public override AllowedRefs Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Any":
                    return AllowedRefs.Any;
                case "OnlySame":
                    return AllowedRefs.OnlySame;
                case "OnlySpecificEntity":
                    return AllowedRefs.OnlySpecificEntity;
                case "OnlyTags":
                    return AllowedRefs.OnlyTags;
            }
            throw new Exception("Cannot unmarshal type AllowedRefs");
        }

        public override void Write(Utf8JsonWriter writer, AllowedRefs value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AllowedRefs.Any:
                    JsonSerializer.Serialize(writer, "Any", options);
                    return;
                case AllowedRefs.OnlySame:
                    JsonSerializer.Serialize(writer, "OnlySame", options);
                    return;
                case AllowedRefs.OnlySpecificEntity:
                    JsonSerializer.Serialize(writer, "OnlySpecificEntity", options);
                    return;
                case AllowedRefs.OnlyTags:
                    JsonSerializer.Serialize(writer, "OnlyTags", options);
                    return;
            }
            throw new Exception("Cannot marshal type AllowedRefs");
        }

        public static readonly AllowedRefsConverter Singleton = new AllowedRefsConverter();
    }
}
