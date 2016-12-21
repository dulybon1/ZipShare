using Newtonsoft.Json;

namespace ZipShare.Models
{
    public class State
    {
        [JsonProperty("text")]
        public string StateName  { get; set; }

        [JsonProperty("value")]
        public string StateAbbreviation {get; set;}
    }
}