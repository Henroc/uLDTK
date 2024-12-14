using Microsoft.Xna.Framework;
using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class AutoLayerRuleGroup
    {
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("biomeRequirementMode")]
        public long BiomeRequirementMode { get; set; }

        /// <summary>
        /// *This field was removed in 1.0.0 and should no longer be used.*
        /// </summary>
        [JsonPropertyName("collapsed")]
        public bool? Collapsed { get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; }

        [JsonPropertyName("icon")]
        public TilesetRectangle Icon { get; set; }

        [JsonPropertyName("isOptional")]
        public bool IsOptional { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("requiredBiomeValues")]
        public string[] RequiredBiomeValues { get; set; }

        [JsonPropertyName("rules")]
        public AutoLayerRuleDefinition[] Rules { get; set; }

        [JsonPropertyName("uid")]
        public long Uid { get; set; }

        [JsonPropertyName("usesWizard")]
        public bool UsesWizard { get; set; }
    }
}
