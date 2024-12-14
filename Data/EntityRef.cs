using System.Text.Json.Serialization;

namespace Ldtk
{
    /// <summary>
    /// This object describes the "location" of an Entity instance in the project worlds.
    ///
    /// IID information of this instance
    /// </summary>
    public partial class EntityRef
    {
        /// <summary>
        /// IID of the refered EntityInstance
        /// </summary>
        [JsonPropertyName("entityIid")]
        public Guid EntityIid { get; set; }

        /// <summary>
        /// IID of the LayerInstance containing the refered EntityInstance
        /// </summary>
        [JsonPropertyName("layerIid")]
        public Guid LayerIid { get; set; }

        /// <summary>
        /// IID of the Level containing the refered EntityInstance
        /// </summary>
        [JsonPropertyName("levelIid")]
        public Guid LevelIid { get; set; }

        /// <summary>
        /// IID of the World containing the refered EntityInstance
        /// </summary>
        [JsonPropertyName("worldIid")]
        public Guid WorldIid { get; set; }
    }
}
