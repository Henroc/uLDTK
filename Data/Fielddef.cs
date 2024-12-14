using Microsoft.Xna.Framework;

namespace Ldtk.Data
{
    public class Fielddef
    {
        public string identifier { get; set; }
        public object doc { get; set; }
        public string __type { get; set; }
        public int uid { get; set; }
        public string type { get; set; }
        public bool isArray { get; set; }
        public bool canBeNull { get; set; }
        public object arrayMinLength { get; set; }
        public object arrayMaxLength { get; set; }
        public string editorDisplayMode { get; set; }
        public int editorDisplayScale { get; set; }
        public string editorDisplayPos { get; set; }
        public string editorLinkStyle { get; set; }
        public Color editorDisplayColor { get; set; }
        public bool editorAlwaysShow { get; set; }
        public bool editorShowInWorld { get; set; }
        public bool editorCutLongValues { get; set; }
        public object editorTextSuffix { get; set; }
        public object editorTextPrefix { get; set; }
        public bool useForSmartColor { get; set; }
        public bool exportToToc { get; set; }
        public bool searchable { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object regex { get; set; }
        public object acceptFileTypes { get; set; }
        public object defaultOverride { get; set; }
        public object textLanguageMode { get; set; }
        public bool symmetricalRef { get; set; }
        public bool autoChainRef { get; set; }
        public bool allowOutOfLevelRef { get; set; }
        public string allowedRefs { get; set; }
        public object allowedRefsEntityUid { get; set; }
        public object[] allowedRefTags { get; set; }
        public object tilesetUid { get; set; }
    }
}