using System.Text.Json.Serialization;


namespace ApiClient
{
    public class People
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("mass")]
        public int Mass { get; set; }
        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }
        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; }
        [JsonPropertyName("eye_color")]
        public string EyeColor { get; set; }
        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }


    }
}