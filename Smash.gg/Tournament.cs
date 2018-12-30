using System.Collections.Generic;
using Newtonsoft.Json;
using Smash.gg.JsonConverters;

namespace Smash.gg
{
    public class Tournament
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("seriesId")] public object SeriesId { get; set; }
        [JsonProperty("ownerId")] public int OwnerId { get; set; }
        [JsonProperty("state")] public int State { get; set; }
        [JsonProperty("progressMeter")] public int ProgressMeter { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("slug")] public string Slug { get; set; }
        [JsonProperty("shortSlug")] public object ShortSlug { get; set; }
        [JsonProperty("venueFee")] public object VenueFee { get; set; }
        [JsonProperty("processingFee")] public int ProcessingFee { get; set; }
        [JsonProperty("processingBase")] public object ProcessingBase { get; set; }
        [JsonProperty("tiebreakOrder")] public TiebreakOrder TiebreakOrder { get; set; }
        [JsonProperty("timezone")] public string Timezone { get; set; }
        [JsonProperty("private")] public bool Private { get; set; }
        [JsonProperty("published")] public bool Published { get; set; }
        [JsonProperty("testMode")] public bool TestMode { get; set; }
        [JsonProperty("sandboxMode")] public bool SandboxMode { get; set; }
        [JsonProperty("publicSeeding")] public bool PublicSeeding { get; set; }
        [JsonProperty("tournamentType")] public int TournamentType { get; set; }
        [JsonProperty("hasOnlineEvents")] public bool HasOnlineEvents { get; set; }
        [JsonProperty("includeQRCode")] public bool IncludeQrCode { get; set; }
        [JsonProperty("approved")] public bool Approved { get; set; }
        [JsonProperty("startAt")] public int StartAt { get; set; }
        [JsonProperty("endAt")] public int EndAt { get; set; }
        [JsonProperty("startedAt")] public object StartedAt { get; set; }
        [JsonProperty("completedAt")] public object CompletedAt { get; set; }
        [JsonProperty("registrationClosesAt")] public object RegistrationClosesAt { get; set; }
        [JsonProperty("eventRegistrationClosesAt")] public object EventRegistrationClosesAt { get; set; }
        [JsonProperty("teamCreationClosesAt")] public object TeamCreationClosesAt { get; set; }
        [JsonProperty("stripeMode")] public object StripeMode { get; set; }
        [JsonProperty("paypalMode")] public object PaypalMode { get; set; }
        [JsonProperty("paypalApp")] public string PaypalApp { get; set; }
        [JsonProperty("city")] public string City { get; set; }
        [JsonProperty("addrState")] public string AddrState { get; set; }
        [JsonProperty("postalCode")] public string PostalCode { get; set; }
        [JsonProperty("countryCode")] public string CountryCode { get; set; }
        [JsonProperty("mapsPlaceId")] public string MapsPlaceId { get; set; }
        [JsonProperty("lat")] public double Latitude { get; set; }
        [JsonProperty("lng")] public double Longiude { get; set; }
        [JsonProperty("monitoringRequestedBy")] public object MonitoringRequestedBy { get; set; }
        [JsonProperty("submissionState")] public int SubmissionState { get; set; }
        [JsonProperty("links")][JsonConverter(typeof(DictionaryOrEmptyArrayConverter<string, string>))] public Dictionary<string, string> Links { get; set; }
        [JsonProperty("venueName")] public string VenueName { get; set; }
        [JsonProperty("venueAddress")] public string VenueAddress { get; set; }
        [JsonProperty("region")] public object Region { get; set; }
        [JsonProperty("hashtag")] public object Hashtag { get; set; }
        [JsonProperty("showCity")] public object ShowCity { get; set; }
        [JsonProperty("attendeeLocationInfo")] public int AttendeeLocationInfo { get; set; }
        [JsonProperty("attendeeContactInfo")] public int AttendeeContactInfo { get; set; }
        [JsonProperty("attendeeFieldConfig")] public AttendeeFieldConfig AttendeeFieldConfig { get; set; }
        [JsonProperty("attendeeRequirements")] public object AttendeeRequirements { get; set; }
        [JsonProperty("notifyAdmins")] public bool NotifyAdmins { get; set; }
        [JsonProperty("publicAttendees")] public bool PublicAttendees { get; set; }
        [JsonProperty("hideAdmins")] public bool HideAdmins { get; set; }
        [JsonProperty("videoUrl")] public object VideoUrl { get; set; }
        [JsonProperty("details")] public string Details { get; set; }
        [JsonProperty("registrationMarkdown")] public object RegistrationMarkdown { get; set; }
        [JsonProperty("gettingThere")] public object GettingThere { get; set; }
        [JsonProperty("prizes")] public object Prizes { get; set; }
        [JsonProperty("rules")] public object Rules { get; set; }
        [JsonProperty("contactInfo")] public object ContactInfo { get; set; }
        [JsonProperty("includeInstructions")] public bool IncludeInstructions { get; set; }
        [JsonProperty("emailInstructions")] public object EmailInstructions { get; set; }
        [JsonProperty("includeDirections")] public bool IncludeDirections { get; set; }
        [JsonProperty("emailDirections")] public object EmailDirections { get; set; }
        [JsonProperty("includeMap")] public bool IncludeMap { get; set; }
        [JsonProperty("qrCodeRedirect")] public object QrCodeRedirect { get; set; }
        [JsonProperty("emailNote")] public object EmailNote { get; set; }
        [JsonProperty("includeNote")] public bool IncludeNote { get; set; }
        [JsonProperty("contactEmail")] public object ContactEmail { get; set; }
        [JsonProperty("contactTwitter")] public object ContactTwitter { get; set; }
        [JsonProperty("contactPhone")] public object ContactPhone { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("onsitePaymentMode")] public object OnsitePaymentMode { get; set; }
        [JsonProperty("stripePublishableKey")] public object StripePublishableKey { get; set; }
        [JsonProperty("paypalPayerId")] public object PaypalPayerId { get; set; }
        [JsonProperty("customEmailText")] public object CustomEmailText { get; set; }
        [JsonProperty("registrationOptions")] public List<object> RegistrationOptions { get; set; }
        [JsonProperty("limitsByType")] public object LimitsByType { get; set; }
        [JsonProperty("publishing")] public Publishing Publishing { get; set; }
        [JsonProperty("trackingPixels")] public List<object> TrackingPixels { get; set; }
        [JsonProperty("generatedTabs")] public object GeneratedTabs { get; set; }
        [JsonProperty("defaultTab")] public string DefaultTab { get; set; }
        [JsonProperty("fees")][JsonConverter(typeof(DictionaryOrEmptyArrayConverter<string, object>))]public Dictionary<string, object> Fees { get; set; }
        [JsonProperty("customMarkdown")] public List<object> CustomMarkdown { get; set; }
        [JsonProperty("images")] public List<Image> Images { get; set; }
        [JsonProperty("scheduleId")] public int ScheduleId { get; set; }
        [JsonProperty("expand")] public List<string> Expand { get; set; }
        [JsonProperty("userData")] public List<object> UserData { get; set; }
        [JsonProperty("eventIds")] public List<int> EventIds { get; set; }
        [JsonProperty("regionDisplayName")] public string RegionDisplayName { get; set; }
        [JsonProperty("onlineEvents")] public List<object> OnlineEvents { get; set; }
        [JsonProperty("hasTaskEvents")] public bool HasTaskEvents { get; set; }
        [JsonProperty("taskEvents")][JsonConverter(typeof(DictionaryOrEmptyArrayConverter<string, bool>))]public Dictionary<string, bool> TaskEvents { get; set; }
        [JsonProperty("supportsPayPal")] public bool SupportsPayPal { get; set; }
        [JsonProperty("slugs")] public List<string> Slugs { get; set; }
        [JsonProperty("permissionType")] public string PermissionType { get; set; }
    }
}
