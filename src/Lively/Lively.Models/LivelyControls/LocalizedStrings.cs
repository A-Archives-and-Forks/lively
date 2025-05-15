using Newtonsoft.Json;

namespace Lively.Models.LivelyControls;

public class LocalizedStrings
{
    [JsonProperty("Text")]
    public string Text { get; set; }

    [JsonProperty("Value")]
    public string Value { get; set; }

    [JsonProperty("Help")]
    public string Help { get; set; }
}
