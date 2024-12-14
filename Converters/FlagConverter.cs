using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class FlagConverter : JsonConverter<Flag>
    {
        public override bool CanConvert(Type t) => t == typeof(Flag);

        public override Flag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "DiscardPreCsvIntGrid":
                    return Flag.DiscardPreCsvIntGrid;
                case "ExportOldTableOfContentData":
                    return Flag.ExportOldTableOfContentData;
                case "ExportPreCsvIntGridFormat":
                    return Flag.ExportPreCsvIntGridFormat;
                case "IgnoreBackupSuggest":
                    return Flag.IgnoreBackupSuggest;
                case "MultiWorlds":
                    return Flag.MultiWorlds;
                case "PrependIndexToLevelFileNames":
                    return Flag.PrependIndexToLevelFileNames;
                case "UseMultilinesType":
                    return Flag.UseMultilinesType;
            }
            throw new Exception("Cannot unmarshal type Flag");
        }

        public override void Write(Utf8JsonWriter writer, Flag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Flag.DiscardPreCsvIntGrid:
                    JsonSerializer.Serialize(writer, "DiscardPreCsvIntGrid", options);
                    return;
                case Flag.ExportOldTableOfContentData:
                    JsonSerializer.Serialize(writer, "ExportOldTableOfContentData", options);
                    return;
                case Flag.ExportPreCsvIntGridFormat:
                    JsonSerializer.Serialize(writer, "ExportPreCsvIntGridFormat", options);
                    return;
                case Flag.IgnoreBackupSuggest:
                    JsonSerializer.Serialize(writer, "IgnoreBackupSuggest", options);
                    return;
                case Flag.MultiWorlds:
                    JsonSerializer.Serialize(writer, "MultiWorlds", options);
                    return;
                case Flag.PrependIndexToLevelFileNames:
                    JsonSerializer.Serialize(writer, "PrependIndexToLevelFileNames", options);
                    return;
                case Flag.UseMultilinesType:
                    JsonSerializer.Serialize(writer, "UseMultilinesType", options);
                    return;
            }
            throw new Exception("Cannot marshal type Flag");
        }

        public static readonly FlagConverter Singleton = new FlagConverter();
    }
}
