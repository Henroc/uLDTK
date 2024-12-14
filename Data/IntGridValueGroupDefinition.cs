using Microsoft.Xna.Framework;
using System.Text.Json.Serialization;

namespace Ldtk
{
    /// <summary>
    /// IntGrid value group definition
    /// </summary>
    public partial class IntGridValueGroupDefinition
    {
        /// <summary>
        /// User defined color
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// User defined string identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Group unique ID
        /// </summary>
        [JsonPropertyName("uid")]
        public long Uid { get; set; }
    }
}
