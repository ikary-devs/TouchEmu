using Newtonsoft.Json;

namespace TouchEmu.Core.Ankama.Protocol.Data
{
    public class MountBehaviors
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }

        [JsonProperty("descriptionId")]
        public string DescriptionId { get; set; }
    }
}