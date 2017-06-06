using Newtonsoft.Json;

namespace ScrumPoker.Models
{
    public class JoinSessionMessage
    {
        [JsonProperty("id")]
        public int Id { get; set; }

		[JsonProperty("name")]

		public string Name { get; set; }
    }
}