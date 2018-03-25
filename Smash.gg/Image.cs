using Newtonsoft.Json;

namespace Smash.gg
{
    public class Image
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("width")] public int Width { get; set; }
        [JsonProperty("height")] public int Height { get; set; }
        [JsonProperty("ratio")] public double Ratio { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("isOriginal")] public bool IsOriginal { get; set; }
        [JsonProperty("entity")] public object Entity { get; set; }
        [JsonProperty("entityId")] public object EntityId { get; set; }
        [JsonProperty("uploadedBy")] public object UploadedBy { get; set; }
        [JsonProperty("createdAt")] public object CreatedAt { get; set; }
        [JsonProperty("updatedAt")] public object UpdatedAt { get; set; }
    }
}
