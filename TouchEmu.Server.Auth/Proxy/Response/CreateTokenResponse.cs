using Newtonsoft.Json;

namespace TouchEmu.Server.Auth.Proxy.Response
{
    public class CreateTokenResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}