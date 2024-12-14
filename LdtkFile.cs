using Ldtk.Converters;
using Microsoft.Xna.Framework;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ldtk
{
    /// <summary>
    /// This file is a JSON schema of files created by LDtk level editor (https://ldtk.io).
    ///
    /// This is the root of any Project JSON file. It contains:  - the project settings, - an
    /// array of levels, - a group of definitions (that can probably be safely ignored for most
    /// users).
    /// </summary>
    public partial class LdtkFile
    {
        /// <summary>
        /// This object is not actually used by LDtk. It ONLY exists to force explicit references to
        /// all types, to make sure QuickType finds them and integrate all of them. Otherwise,
        /// Quicktype will drop types that are not explicitely used.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("__FORCED_REFS")]
        public ForcedRefs ForcedRefs { get; set; }

        /// <summary>
        /// LDtk application build identifier.<br/>  This is only used to identify the LDtk version
        /// that generated this particular project file, which can be useful for specific bug fixing.
        /// Note that the build identifier is just the date of the release, so it's not unique to
        /// each user (one single global ID per LDtk public release), and as a result, completely
        /// anonymous.
        /// </summary>
        [JsonPropertyName("appBuildId")]
        public double AppBuildId { get; set; }

        /// <summary>
        /// Number of backup files to keep, if the `backupOnSave` is TRUE
        /// </summary>
        [JsonPropertyName("backupLimit")]
        public long BackupLimit { get; set; }

        /// <summary>
        /// If TRUE, an extra copy of the project will be created in a sub folder, when saving.
        /// </summary>
        [JsonPropertyName("backupOnSave")]
        public bool BackupOnSave { get; set; }

        /// <summary>
        /// Target relative path to store backup files
        /// </summary>
        [JsonPropertyName("backupRelPath")]
        public string BackupRelPath { get; set; }

        /// <summary>
        /// Project background color
        /// </summary>
        [JsonPropertyName("bgColor")]
        public Color BgColor { get; set; }

        /// <summary>
        /// An array of command lines that can be ran manually by the user
        /// </summary>
        [JsonPropertyName("customCommands")]
        public LdtkCustomCommand[] CustomCommands { get; set; }

        /// <summary>
        /// Default height for new entities
        /// </summary>
        [JsonPropertyName("defaultEntityHeight")]
        public long DefaultEntityHeight { get; set; }

        /// <summary>
        /// Default width for new entities
        /// </summary>
        [JsonPropertyName("defaultEntityWidth")]
        public long DefaultEntityWidth { get; set; }

        /// <summary>
        /// Default grid size for new layers
        /// </summary>
        [JsonPropertyName("defaultGridSize")]
        public long DefaultGridSize { get; set; }

        /// <summary>
        /// Default background color of levels
        /// </summary>
        [JsonPropertyName("defaultLevelBgColor")]
        public Color DefaultLevelBgColor { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Default new level height
        /// </summary>
        [JsonPropertyName("defaultLevelHeight")]
        public long? DefaultLevelHeight { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Default new level width
        /// </summary>
        [JsonPropertyName("defaultLevelWidth")]
        public long? DefaultLevelWidth { get; set; }

        /// <summary>
        /// Default X pivot (0 to 1) for new entities
        /// </summary>
        [JsonPropertyName("defaultPivotX")]
        public double DefaultPivotX { get; set; }

        /// <summary>
        /// Default Y pivot (0 to 1) for new entities
        /// </summary>
        [JsonPropertyName("defaultPivotY")]
        public double DefaultPivotY { get; set; }

        /// <summary>
        /// A structure containing all the definitions of this project
        /// </summary>
        [JsonPropertyName("defs")]
        public Definitions Defs { get; set; }

        /// <summary>
        /// If the project isn't in MultiWorlds mode, this is the IID of the internal "dummy" World.
        /// </summary>
        [JsonPropertyName("dummyWorldIid")]
        public Guid DummyWorldIid { get; set; }

        /// <summary>
        /// If TRUE, the exported PNGs will include the level background (color or image).
        /// </summary>
        [JsonPropertyName("exportLevelBg")]
        public bool ExportLevelBg { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 0.9.3  Replaced
        /// by: `imageExportMode`
        /// </summary>
        [JsonPropertyName("exportPng")]
        public bool? ExportPng { get; set; }

        /// <summary>
        /// If TRUE, a Tiled compatible file will also be generated along with the LDtk JSON file
        /// (default is FALSE)
        /// </summary>
        [JsonPropertyName("exportTiled")]
        public bool ExportTiled { get; set; }

        /// <summary>
        /// If TRUE, one file will be saved for the project (incl. all its definitions) and one file
        /// in a sub-folder for each level.
        /// </summary>
        [JsonPropertyName("externalLevels")]
        public bool ExternalLevels { get; set; }

        /// <summary>
        /// An array containing various advanced flags (ie. options or other states). Possible
        /// values: `DiscardPreCsvIntGrid`, `ExportOldTableOfContentData`,
        /// `ExportPreCsvIntGridFormat`, `IgnoreBackupSuggest`, `PrependIndexToLevelFileNames`,
        /// `MultiWorlds`, `UseMultilinesType`
        /// </summary>
        [JsonPropertyName("flags")]
        public Flag[] Flags { get; set; }

        /// <summary>
        /// Naming convention for Identifiers (first-letter uppercase, full uppercase etc.) Possible
        /// values: `Capitalize`, `Uppercase`, `Lowercase`, `Free`
        /// </summary>
        [JsonPropertyName("identifierStyle")]
        public IdentifierStyle IdentifierStyle { get; set; }

        /// <summary>
        /// Unique project identifier
        /// </summary>
        [JsonPropertyName("iid")]
        public Guid Iid { get; set; }

        /// <summary>
        /// "Image export" option when saving project. Possible values: `None`, `OneImagePerLayer`,
        /// `OneImagePerLevel`, `LayersAndLevels`
        /// </summary>
        [JsonPropertyName("imageExportMode")]
        public ImageExportMode ImageExportMode { get; set; }

        /// <summary>
        /// File format version
        /// </summary>
        [JsonPropertyName("jsonVersion")]
        public string JsonVersion { get; set; }

        /// <summary>
        /// The default naming convention for level identifiers.
        /// </summary>
        [JsonPropertyName("levelNamePattern")]
        public string LevelNamePattern { get; set; }

        /// <summary>
        /// All levels. The order of this array is only relevant in `LinearHorizontal` and
        /// `linearVertical` world layouts (see `worldLayout` value).<br/>  Otherwise, you should
        /// refer to the `worldX`,`worldY` coordinates of each Level.
        /// </summary>
        [JsonPropertyName("levels")]
        public Level[] Levels { get; set; }

        /// <summary>
        /// If TRUE, the Json is partially minified (no indentation, nor line breaks, default is
        /// FALSE)
        /// </summary>
        [JsonPropertyName("minifyJson")]
        public bool MinifyJson { get; set; }

        /// <summary>
        /// Next Unique integer ID available
        /// </summary>
        [JsonPropertyName("nextUid")]
        public long NextUid { get; set; }

        /// <summary>
        /// File naming pattern for exported PNGs
        /// </summary>
        [JsonPropertyName("pngFilePattern")]
        public string PngFilePattern { get; set; }

        /// <summary>
        /// If TRUE, a very simplified will be generated on saving, for quicker & easier engine
        /// integration.
        /// </summary>
        [JsonPropertyName("simplifiedExport")]
        public bool SimplifiedExport { get; set; }

        /// <summary>
        /// All instances of entities that have their `exportToToc` flag enabled are listed in this
        /// array.
        /// </summary>
        [JsonPropertyName("toc")]
        public LdtkTableOfContentEntry[] Toc { get; set; }

        /// <summary>
        /// This optional description is used by LDtk Samples to show up some informations and
        /// instructions.
        /// </summary>
        [JsonPropertyName("tutorialDesc")]
        public string TutorialDesc { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Height of the world grid in pixels.
        /// </summary>
        [JsonPropertyName("worldGridHeight")]
        public long? WorldGridHeight { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Width of the world grid in pixels.
        /// </summary>
        [JsonPropertyName("worldGridWidth")]
        public long? WorldGridWidth { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  An enum that describes how levels are organized in
        /// this project (ie. linearly or in a 2D space). Possible values: &lt;`null`&gt;, `Free`,
        /// `GridVania`, `LinearHorizontal`, `LinearVertical`
        /// </summary>
        [JsonPropertyName("worldLayout")]
        public WorldLayout? WorldLayout { get; set; }

        /// <summary>
        /// This array will be empty, unless you enable the Multi-Worlds in the project advanced
        /// settings.<br/><br/> - in current version, a LDtk project file can only contain a single
        /// world with multiple levels in it. In this case, levels and world layout related settings
        /// are stored in the root of the JSON.<br/> - with "Multi-worlds" enabled, there will be a
        /// `worlds` array in root, each world containing levels and layout settings. Basically, it's
        /// pretty much only about moving the `levels` array to the `worlds` array, along with world
        /// layout related values (eg. `worldGridWidth` etc).<br/><br/>If you want to start
        /// supporting this future update easily, please refer to this documentation:
        /// https://github.com/deepnight/ldtk/issues/231
        /// </summary>
        [JsonPropertyName("worlds")]
        public World[] Worlds { get; set; }
    }

    public partial class LdtkFile
    {
        public static LdtkFile FromJson(string json) => JsonSerializer.Deserialize<LdtkFile>(json, Converter.Settings);
    }

    /// <summary>
    /// Possible values: `Manual`, `AfterLoad`, `BeforeSave`, `AfterSave`
    /// </summary>
    public enum When { AfterLoad, AfterSave, BeforeSave, Manual };

    /// <summary>
    /// Possible values: `Any`, `OnlySame`, `OnlyTags`, `OnlySpecificEntity`
    /// </summary>
    public enum AllowedRefs { Any, OnlySame, OnlySpecificEntity, OnlyTags };

    /// <summary>
    /// Possible values: `Hidden`, `ValueOnly`, `NameAndValue`, `EntityTile`, `LevelTile`,
    /// `Points`, `PointStar`, `PointPath`, `PointPathLoop`, `RadiusPx`, `RadiusGrid`,
    /// `ArrayCountWithLabel`, `ArrayCountNoLabel`, `RefLinkBetweenPivots`,
    /// `RefLinkBetweenCenters`
    /// </summary>
    public enum EditorDisplayMode { ArrayCountNoLabel, ArrayCountWithLabel, EntityTile, Hidden, LevelTile, NameAndValue, PointPath, PointPathLoop, PointStar, Points, RadiusGrid, RadiusPx, RefLinkBetweenCenters, RefLinkBetweenPivots, ValueOnly };

    /// <summary>
    /// Possible values: `Above`, `Center`, `Beneath`
    /// </summary>
    public enum EditorDisplayPos { Above, Beneath, Center };

    /// <summary>
    /// Possible values: `ZigZag`, `StraightArrow`, `CurvedArrow`, `ArrowsLine`, `DashedLine`
    /// </summary>
    public enum EditorLinkStyle { ArrowsLine, CurvedArrow, DashedLine, StraightArrow, ZigZag };

    public enum TextLanguageMode { LangC, LangHaxe, LangJs, LangJson, LangLog, LangLua, LangMarkdown, LangPython, LangRuby, LangXml };

    /// <summary>
    /// Possible values: `DiscardOldOnes`, `PreventAdding`, `MoveLastOne`
    /// </summary>
    public enum LimitBehavior { DiscardOldOnes, MoveLastOne, PreventAdding };

    /// <summary>
    /// If TRUE, the maxCount is a "per world" limit, if FALSE, it's a "per level". Possible
    /// values: `PerLayer`, `PerLevel`, `PerWorld`
    /// </summary>
    public enum LimitScope { PerLayer, PerLevel, PerWorld };

    /// <summary>
    /// Possible values: `Rectangle`, `Ellipse`, `Tile`, `Cross`
    /// </summary>
    public enum RenderMode { Cross, Ellipse, Rectangle, Tile };

    /// <summary>
    /// An enum describing how the the Entity tile is rendered inside the Entity bounds. Possible
    /// values: `Cover`, `FitInside`, `Repeat`, `Stretch`, `FullSizeCropped`,
    /// `FullSizeUncropped`, `NineSlice`
    /// </summary>
    public enum TileRenderMode { Cover, FitInside, FullSizeCropped, FullSizeUncropped, NineSlice, Repeat, Stretch };

    /// <summary>
    /// Checker mode Possible values: `None`, `Horizontal`, `Vertical`
    /// </summary>
    public enum Checker { Horizontal, None, Vertical };

    /// <summary>
    /// Defines how tileIds array is used Possible values: `Single`, `Stamp`
    /// </summary>
    public enum TileMode { Single, Stamp };

    /// <summary>
    /// Type of the layer as Haxe Enum Possible values: `IntGrid`, `Entities`, `Tiles`,
    /// `AutoLayer`
    /// </summary>
    public enum LayerType { AutoLayer, Entities, IntGrid, Tiles };

    public enum EmbedAtlas { LdtkIcons };

    public enum Flag { DiscardPreCsvIntGrid, ExportOldTableOfContentData, ExportPreCsvIntGridFormat, IgnoreBackupSuggest, MultiWorlds, PrependIndexToLevelFileNames, UseMultilinesType };

    public enum BgPos { Contain, Cover, CoverDirty, Repeat, Unscaled };

    public enum WorldLayout { Free, GridVania, LinearHorizontal, LinearVertical };

    /// <summary>
    /// Naming convention for Identifiers (first-letter uppercase, full uppercase etc.) Possible
    /// values: `Capitalize`, `Uppercase`, `Lowercase`, `Free`
    /// </summary>
    public enum IdentifierStyle { Capitalize, Free, Lowercase, Uppercase };

    /// <summary>
    /// "Image export" option when saving project. Possible values: `None`, `OneImagePerLayer`,
    /// `OneImagePerLevel`, `LayersAndLevels`
    /// </summary>
    public enum ImageExportMode { LayersAndLevels, None, OneImagePerLayer, OneImagePerLevel };
}
