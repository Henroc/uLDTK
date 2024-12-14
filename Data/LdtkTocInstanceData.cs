using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class LdtkTocInstanceData
    {
        /// <summary>
        /// An object containing the values of all entity fields with the `exportToToc` option
        /// enabled. This object typing depends on actual field value types.
        /// </summary>
        [JsonPropertyName("fields")]
        public object Fields { get; set; }

        [JsonPropertyName("heiPx")]
        public long HeiPx { get; set; }

        /// <summary>
        /// IID information of this instance
        /// </summary>
        [JsonPropertyName("iids")]
        public EntityRef Iids { get; set; }

        [JsonPropertyName("widPx")]
        public long WidPx { get; set; }

        [JsonPropertyName("worldX")]
        public long WorldX { get; set; }

        [JsonPropertyName("worldY")]
        public long WorldY { get; set; }
    }

  
}
