﻿using Microsoft.Xna.Framework;
using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class LayerInstance
    {
        /// <summary>
        /// Grid-based height
        /// </summary>
        [JsonPropertyName("__cHei")]
        public long CHei { get; set; }

        /// <summary>
        /// Grid-based width
        /// </summary>
        [JsonPropertyName("__cWid")]
        public long CWid { get; set; }

        /// <summary>
        /// Grid size
        /// </summary>
        [JsonPropertyName("__gridSize")]
        public long GridSize { get; set; }

        /// <summary>
        /// Layer definition identifier
        /// </summary>
        [JsonPropertyName("__identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Layer opacity as Float [0-1]
        /// </summary>
        [JsonPropertyName("__opacity")]
        public double Opacity { get; set; }

        /// <summary>
        /// Total layer X pixel offset, including both instance and definition offsets.
        /// </summary>
        [JsonPropertyName("__pxTotalOffsetX")]
        public long PxTotalOffsetX { get; set; }

        /// <summary>
        /// Total layer Y pixel offset, including both instance and definition offsets.
        /// </summary>
        [JsonPropertyName("__pxTotalOffsetY")]
        public long PxTotalOffsetY { get; set; }

        /// <summary>
        /// The definition UID of corresponding Tileset, if any.
        /// </summary>
        [JsonPropertyName("__tilesetDefUid")]
        public long? TilesetDefUid { get; set; }

        /// <summary>
        /// The relative path to corresponding Tileset, if any.
        /// </summary>
        [JsonPropertyName("__tilesetRelPath")]
        public string TilesetRelPath { get; set; }

        /// <summary>
        /// Layer type (possible values: IntGrid, Entities, Tiles or AutoLayer)
        /// </summary>
        [JsonPropertyName("__type")]
        public LayerType Type { get; set; }

        /// <summary>
        /// An array containing all tiles generated by Auto-layer rules. The array is already sorted
        /// in display order (ie. 1st tile is beneath 2nd, which is beneath 3rd etc.).<br/><br/>
        /// Note: if multiple tiles are stacked in the same cell as the result of different rules,
        /// all tiles behind opaque ones will be discarded.
        /// </summary>
        [JsonPropertyName("autoLayerTiles")]
        public TileInstance[] AutoLayerTiles { get; set; }

        [JsonPropertyName("entityInstances")]
        public EntityInstance[] EntityInstances { get; set; }

        [JsonPropertyName("gridTiles")]
        public TileInstance[] GridTiles { get; set; }

        /// <summary>
        /// Unique layer instance identifier
        /// </summary>
        [JsonPropertyName("iid")]
        public Guid Iid { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 1.0.0  Replaced
        /// by: `intGridCsv`
        /// </summary>
        [JsonPropertyName("intGrid")]
        public IntGridValueInstance[] IntGrid { get; set; }

        /// <summary>
        /// A list of all values in the IntGrid layer, stored in CSV format (Comma Separated
        /// Values).<br/>  Order is from left to right, and top to bottom (ie. first row from left to
        /// right, followed by second row, etc).<br/>  `0` means "empty cell" and IntGrid values
        /// start at 1.<br/>  The array size is `__cWid` x `__cHei` cells.
        /// </summary>
        [JsonPropertyName("intGridCsv")]
        public long[] IntGridCsv { get; set; }

        /// <summary>
        /// Reference the Layer definition UID
        /// </summary>
        [JsonPropertyName("layerDefUid")]
        public long LayerDefUid { get; set; }

        /// <summary>
        /// Reference to the UID of the level containing this layer instance
        /// </summary>
        [JsonPropertyName("levelId")]
        public long LevelId { get; set; }

        /// <summary>
        /// An Array containing the UIDs of optional rules that were enabled in this specific layer
        /// instance.
        /// </summary>
        [JsonPropertyName("optionalRules")]
        public long[] OptionalRules { get; set; }

        /// <summary>
        /// This layer can use another tileset by overriding the tileset UID here.
        /// </summary>
        [JsonPropertyName("overrideTilesetUid")]
        public long? OverrideTilesetUid { get; set; }

        /// <summary>
        /// X offset in pixels to render this layer, usually 0 (IMPORTANT: this should be added to
        /// the `LayerDef` optional offset, so you should probably prefer using `__pxTotalOffsetX`
        /// which contains the total offset value)
        /// </summary>
        [JsonPropertyName("pxOffsetX")]
        public long PxOffsetX { get; set; }

        /// <summary>
        /// Y offset in pixels to render this layer, usually 0 (IMPORTANT: this should be added to
        /// the `LayerDef` optional offset, so you should probably prefer using `__pxTotalOffsetX`
        /// which contains the total offset value)
        /// </summary>
        [JsonPropertyName("pxOffsetY")]
        public long PxOffsetY { get; set; }

        /// <summary>
        /// Random seed used for Auto-Layers rendering
        /// </summary>
        [JsonPropertyName("seed")]
        public long Seed { get; set; }

        /// <summary>
        /// Layer instance visibility
        /// </summary>
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }
    }
}