using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class EnumValueDefinition
    {
        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 1.4.0  Replaced
        /// by: `tileRect`
        /// </summary>
        [JsonPropertyName("__tileSrcRect")]
        public long[] TileSrcRect { get; set; }

        /// <summary>
        /// Optional color
        /// </summary>
        [JsonPropertyName("color")]
        public long Color { get; set; }

        /// <summary>
        /// Enum value
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 1.4.0  Replaced
        /// by: `tileRect`
        /// </summary>
        [JsonPropertyName("tileId")]
        public long? TileId { get; set; }

        /// <summary>
        /// Optional tileset rectangle to represents this value
        /// </summary>
        [JsonPropertyName("tileRect")]
        public TilesetRectangle TileRect { get; set; }
    }
}
