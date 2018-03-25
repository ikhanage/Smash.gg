using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class RankingIteration
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("seriesId")] public int SeriesId { get; set; }
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("slug")] public string Slug { get; set; }
        [JsonProperty("published")] public bool Published { get; set; }
        [JsonProperty("status")] public int Status { get; set; }
        [JsonProperty("active")] public bool Active { get; set; }
        [JsonProperty("description")] public object Description { get; set; }
        [JsonProperty("publishedAt")] public int PublishedAt { get; set; }
        [JsonProperty("startAt")] public int? StartAt { get; set; }
        [JsonProperty("endAt")] public int? EndAt { get; set; }
        [JsonProperty("createdAt")] public int CreatedAt { get; set; }
        [JsonProperty("updatedAt")] public int UpdatedAt { get; set; }
        [JsonProperty("submittedAt")] public int SubmittedAt { get; set; }
        [JsonProperty("createdBy")] public int CreatedBy { get; set; }
        [JsonProperty("images")] public List<Image> Images { get; set; }
        [JsonProperty("permissionType")] public string PermissionType { get; set; }
    }
}
