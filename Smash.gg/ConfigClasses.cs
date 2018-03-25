using Newtonsoft.Json;

namespace Smash.gg
{
    public class AttendeeFieldConfig
    {
        [JsonProperty("nameFirst")] public FieldConfig NameFirst { get; set; }
        [JsonProperty("nameLast")] public FieldConfig NameLast { get; set; }
        [JsonProperty("phoneNumber")] public FieldConfig PhoneNumber { get; set; }
    }

    public class FieldConfig
    {
        [JsonProperty("visible")] public bool Visible { get; set; }
        [JsonProperty("required")] public bool Required { get; set; }
    }

    public class PageConfig
    {
        [JsonProperty("tabs")] public Tabs Tabs { get; set; }
        [JsonProperty("rules")] public object Rules { get; set; }
    }
}
