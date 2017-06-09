using Newtonsoft.Json;

namespace ScrumPoker.Models
{
    public class Session
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        public int MemberCount { get; set; }

        [JsonProperty("cardSet")]
        // TODO to enum or something
        public int Cards
        {
            get;
            set;
        }
    }
}