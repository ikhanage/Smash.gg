using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class EventGroup
    {
        [JsonProperty("entities")] public EventEntities Entities { get; set; }
        [JsonProperty("result")] public int Result { get; set; }
        [JsonProperty("resultEntity")] public string ResultEntity { get; set; }
        [JsonProperty("actionRecords")] public List<object> ActionRecords { get; set; }
    }
}
