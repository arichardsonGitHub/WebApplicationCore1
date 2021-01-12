using Newtonsoft.Json;

public class Geo
{
    [JsonProperty("lat")]
    public double Latitude { get; set; }

    [JsonProperty("lng")]
    public double Longitude { get; set; }
}