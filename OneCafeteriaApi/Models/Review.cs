namespace OneCafeteriaApi.Models
{
    using Newtonsoft.Json;
    using System;

    public class Review
    {
        [JsonProperty(PropertyName = "picture")]
        public Uri Picture { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }

        [JsonProperty(PropertyName = "foodName")]
        public string FoodName { get; set; }
    }
}
