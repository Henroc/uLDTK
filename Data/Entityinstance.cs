using Ldtk.Converters;
using Microsoft.Xna.Framework;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class EntityInstance
    {
        /// <summary>
        /// Grid-based coordinates (`[x,y]` format)
        /// </summary>
        [JsonPropertyName("__grid")]
        public Point Grid { get; set; }

        /// <summary>
        /// Entity definition identifier
        /// </summary>
        [JsonPropertyName("__identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Pivot coordinates  (`[x,y]` format, values are from 0 to 1) of the Entity
        /// </summary>
        [JsonPropertyName("__pivot")]
        public Point Pivot { get; set; }

        /// <summary>
        /// The entity "smart" color, guessed from either Entity definition, or one its field
        /// instances.
        /// </summary>
        [JsonPropertyName("__smartColor")]
        public Color SmartColor { get; set; }

        /// <summary>
        /// Array of tags defined in this Entity definition
        /// </summary>
        [JsonPropertyName("__tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Optional TilesetRect used to display this entity (it could either be the default Entity
        /// tile, or some tile provided by a field value, like an Enum).
        /// </summary>
        [JsonPropertyName("__tile")]
        public TilesetRectangle Tile { get; set; }

        /// <summary>
        /// X world coordinate in pixels. Only available in GridVania or Free world layouts.
        /// </summary>
        [JsonPropertyName("__worldX")]
        public long? WorldX { get; set; }

        /// <summary>
        /// Y world coordinate in pixels Only available in GridVania or Free world layouts.
        /// </summary>
        [JsonPropertyName("__worldY")]
        public long? WorldY { get; set; }

        /// <summary>
        /// Reference of the **Entity definition** UID
        /// </summary>
        [JsonPropertyName("defUid")]
        public long DefUid { get; set; }

        /// <summary>
        /// An array of all custom fields and their values.
        /// </summary>
        [JsonPropertyName("fieldInstances")]
        public FieldInstance[] FieldInstances { get; set; }

        /// <summary>
        /// Entity height in pixels. For non-resizable entities, it will be the same as Entity
        /// definition.
        /// </summary>
        [JsonPropertyName("height")]
        public long Height { get; set; }

        /// <summary>
        /// Unique instance identifier
        /// </summary>
        [JsonPropertyName("iid")]
        public Guid Iid { get; set; }

        /// <summary>
        /// Pixel coordinates (`[x,y]` format) in current level coordinate space. Don't forget
        /// optional layer offsets, if they exist!
        /// </summary>
        [JsonPropertyName("px")]
        public Point Px { get; set; }

        /// <summary>
        /// Entity width in pixels. For non-resizable entities, it will be the same as Entity
        /// definition.
        /// </summary>
        [JsonPropertyName("width")]
        public long Width { get; set; }
    }


    public partial class EntityInstance
    {
        public T GetField<T>(string name)
        {
            foreach (var field in FieldInstances)
            {
                if (name != field.Identifier)
                    continue;

                return JsonSerializer.Deserialize<T>(field.Value.ToString(), Converter.Settings);
            }

            throw new Exception($"Field {name} not found in entity {Identifier}");
        }
    }
}