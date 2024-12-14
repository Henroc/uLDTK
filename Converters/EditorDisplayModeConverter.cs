using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class EditorDisplayModeConverter : JsonConverter<EditorDisplayMode>
    {
        public override bool CanConvert(Type t) => t == typeof(EditorDisplayMode);

        public override EditorDisplayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "ArrayCountNoLabel":
                    return EditorDisplayMode.ArrayCountNoLabel;
                case "ArrayCountWithLabel":
                    return EditorDisplayMode.ArrayCountWithLabel;
                case "EntityTile":
                    return EditorDisplayMode.EntityTile;
                case "Hidden":
                    return EditorDisplayMode.Hidden;
                case "LevelTile":
                    return EditorDisplayMode.LevelTile;
                case "NameAndValue":
                    return EditorDisplayMode.NameAndValue;
                case "PointPath":
                    return EditorDisplayMode.PointPath;
                case "PointPathLoop":
                    return EditorDisplayMode.PointPathLoop;
                case "PointStar":
                    return EditorDisplayMode.PointStar;
                case "Points":
                    return EditorDisplayMode.Points;
                case "RadiusGrid":
                    return EditorDisplayMode.RadiusGrid;
                case "RadiusPx":
                    return EditorDisplayMode.RadiusPx;
                case "RefLinkBetweenCenters":
                    return EditorDisplayMode.RefLinkBetweenCenters;
                case "RefLinkBetweenPivots":
                    return EditorDisplayMode.RefLinkBetweenPivots;
                case "ValueOnly":
                    return EditorDisplayMode.ValueOnly;
            }
            throw new Exception("Cannot unmarshal type EditorDisplayMode");
        }

        public override void Write(Utf8JsonWriter writer, EditorDisplayMode value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EditorDisplayMode.ArrayCountNoLabel:
                    JsonSerializer.Serialize(writer, "ArrayCountNoLabel", options);
                    return;
                case EditorDisplayMode.ArrayCountWithLabel:
                    JsonSerializer.Serialize(writer, "ArrayCountWithLabel", options);
                    return;
                case EditorDisplayMode.EntityTile:
                    JsonSerializer.Serialize(writer, "EntityTile", options);
                    return;
                case EditorDisplayMode.Hidden:
                    JsonSerializer.Serialize(writer, "Hidden", options);
                    return;
                case EditorDisplayMode.LevelTile:
                    JsonSerializer.Serialize(writer, "LevelTile", options);
                    return;
                case EditorDisplayMode.NameAndValue:
                    JsonSerializer.Serialize(writer, "NameAndValue", options);
                    return;
                case EditorDisplayMode.PointPath:
                    JsonSerializer.Serialize(writer, "PointPath", options);
                    return;
                case EditorDisplayMode.PointPathLoop:
                    JsonSerializer.Serialize(writer, "PointPathLoop", options);
                    return;
                case EditorDisplayMode.PointStar:
                    JsonSerializer.Serialize(writer, "PointStar", options);
                    return;
                case EditorDisplayMode.Points:
                    JsonSerializer.Serialize(writer, "Points", options);
                    return;
                case EditorDisplayMode.RadiusGrid:
                    JsonSerializer.Serialize(writer, "RadiusGrid", options);
                    return;
                case EditorDisplayMode.RadiusPx:
                    JsonSerializer.Serialize(writer, "RadiusPx", options);
                    return;
                case EditorDisplayMode.RefLinkBetweenCenters:
                    JsonSerializer.Serialize(writer, "RefLinkBetweenCenters", options);
                    return;
                case EditorDisplayMode.RefLinkBetweenPivots:
                    JsonSerializer.Serialize(writer, "RefLinkBetweenPivots", options);
                    return;
                case EditorDisplayMode.ValueOnly:
                    JsonSerializer.Serialize(writer, "ValueOnly", options);
                    return;
            }
            throw new Exception("Cannot marshal type EditorDisplayMode");
        }

        public static readonly EditorDisplayModeConverter Singleton = new EditorDisplayModeConverter();
    }
}
