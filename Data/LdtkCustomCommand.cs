using System.Text.Json.Serialization;

namespace Ldtk
{
    public partial class LdtkCustomCommand
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }

        /// <summary>
        /// Possible values: `Manual`, `AfterLoad`, `BeforeSave`, `AfterSave`
        /// </summary>
        [JsonPropertyName("when")]
        public When When { get; set; }
    }

  
}
