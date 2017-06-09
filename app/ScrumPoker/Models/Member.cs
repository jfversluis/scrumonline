using Newtonsoft.Json;

namespace ScrumPoker.Models
{
    public class Member
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}