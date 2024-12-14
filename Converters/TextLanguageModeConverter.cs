using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class TextLanguageModeConverter : JsonConverter<TextLanguageMode>
    {
        public override bool CanConvert(Type t) => t == typeof(TextLanguageMode);

        public override TextLanguageMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "LangC":
                    return TextLanguageMode.LangC;
                case "LangHaxe":
                    return TextLanguageMode.LangHaxe;
                case "LangJS":
                    return TextLanguageMode.LangJs;
                case "LangJson":
                    return TextLanguageMode.LangJson;
                case "LangLog":
                    return TextLanguageMode.LangLog;
                case "LangLua":
                    return TextLanguageMode.LangLua;
                case "LangMarkdown":
                    return TextLanguageMode.LangMarkdown;
                case "LangPython":
                    return TextLanguageMode.LangPython;
                case "LangRuby":
                    return TextLanguageMode.LangRuby;
                case "LangXml":
                    return TextLanguageMode.LangXml;
            }
            throw new Exception("Cannot unmarshal type TextLanguageMode");
        }

        public override void Write(Utf8JsonWriter writer, TextLanguageMode value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case TextLanguageMode.LangC:
                    JsonSerializer.Serialize(writer, "LangC", options);
                    return;
                case TextLanguageMode.LangHaxe:
                    JsonSerializer.Serialize(writer, "LangHaxe", options);
                    return;
                case TextLanguageMode.LangJs:
                    JsonSerializer.Serialize(writer, "LangJS", options);
                    return;
                case TextLanguageMode.LangJson:
                    JsonSerializer.Serialize(writer, "LangJson", options);
                    return;
                case TextLanguageMode.LangLog:
                    JsonSerializer.Serialize(writer, "LangLog", options);
                    return;
                case TextLanguageMode.LangLua:
                    JsonSerializer.Serialize(writer, "LangLua", options);
                    return;
                case TextLanguageMode.LangMarkdown:
                    JsonSerializer.Serialize(writer, "LangMarkdown", options);
                    return;
                case TextLanguageMode.LangPython:
                    JsonSerializer.Serialize(writer, "LangPython", options);
                    return;
                case TextLanguageMode.LangRuby:
                    JsonSerializer.Serialize(writer, "LangRuby", options);
                    return;
                case TextLanguageMode.LangXml:
                    JsonSerializer.Serialize(writer, "LangXml", options);
                    return;
            }
            throw new Exception("Cannot marshal type TextLanguageMode");
        }

        public static readonly TextLanguageModeConverter Singleton = new TextLanguageModeConverter();
    }
}
