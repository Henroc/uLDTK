using Microsoft.Xna.Framework;
using System.Text.Json.Serialization;

namespace Ldtk
{
    /// <summary>
    /// IntGrid value definition
    /// </summary>
    public partial class IntGridValueDefinition
    {
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// Parent group identifier (0 if none)
        /// </summary>
        [JsonPropertyName("groupUid")]
        public long GroupUid { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("tile")]
        public TilesetRectangle Tile { get; set; }

        /// <summary>
        /// The IntGrid value itself
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
