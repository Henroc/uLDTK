﻿using System.Text.Json.Serialization;
using System.Text.Json;

namespace Ldtk.Converters
{
    internal class TileRenderModeConverter : JsonConverter<TileRenderMode>
    {
        public override bool CanConvert(Type t) => t == typeof(TileRenderMode);

        public override TileRenderMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Cover":
                    return TileRenderMode.Cover;
                case "FitInside":
                    return TileRenderMode.FitInside;
                case "FullSizeCropped":
                    return TileRenderMode.FullSizeCropped;
                case "FullSizeUncropped":
                    return TileRenderMode.FullSizeUncropped;
                case "NineSlice":
                    return TileRenderMode.NineSlice;
                case "Repeat":
                    return TileRenderMode.Repeat;
                case "Stretch":
                    return TileRenderMode.Stretch;
            }
            throw new Exception("Cannot unmarshal type TileRenderMode");
        }

        public override void Write(Utf8JsonWriter writer, TileRenderMode value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case TileRenderMode.Cover:
                    JsonSerializer.Serialize(writer, "Cover", options);
                    return;
                case TileRenderMode.FitInside:
                    JsonSerializer.Serialize(writer, "FitInside", options);
                    return;
                case TileRenderMode.FullSizeCropped:
                    JsonSerializer.Serialize(writer, "FullSizeCropped", options);
                    return;
                case TileRenderMode.FullSizeUncropped:
                    JsonSerializer.Serialize(writer, "FullSizeUncropped", options);
                    return;
                case TileRenderMode.NineSlice:
                    JsonSerializer.Serialize(writer, "NineSlice", options);
                    return;
                case TileRenderMode.Repeat:
                    JsonSerializer.Serialize(writer, "Repeat", options);
                    return;
                case TileRenderMode.Stretch:
                    JsonSerializer.Serialize(writer, "Stretch", options);
                    return;
            }
            throw new Exception("Cannot marshal type TileRenderMode");
        }

        public static readonly TileRenderModeConverter Singleton = new TileRenderModeConverter();
    }
}
