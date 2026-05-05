using Newtonsoft.Json;

namespace TouchEmu.Core.Ankama.Protocol.Data
{
    public class Months
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }
    }
}