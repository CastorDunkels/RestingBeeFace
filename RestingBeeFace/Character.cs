using System.Text.Json.Serialization;

public class Character
{
    [JsonPropertyName("name")]
    public string name {get; set;}

    [JsonPropertyName("height")]
    public string height {get; set;}

    [JsonPropertyName("mass")]
    public string mass {get; set;}

    [JsonPropertyName("bir")]
    public string birthYear {get; set;}

    [JsonPropertyName("hairColor")]
    public string hairColor {get; set;}

    [JsonPropertyName("eyeColor")]
    public string eyeColor {get; set;}

    [JsonPropertyName("gender")]
    public string gender {get; set;}

    
}
