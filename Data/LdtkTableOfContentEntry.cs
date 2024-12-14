using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class LdtkTableOfContentEntry
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value will be *removed* completely on version 1.7.0+
        /// Replaced by: `instancesData`
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("instances")]
        public EntityRef[] Instances { get; set; }

        [JsonPropertyName("instancesData")]
        public LdtkTocInstanceData[] InstancesData { get; set; }
    }

  
}
