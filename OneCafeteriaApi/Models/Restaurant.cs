
namespace OneCafeteriaApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;

    public class Restaurant
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Locaiton { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; set; }

        [JsonProperty(PropertyName = "reviews")]
        public List<Review> Reviews { get; set; }

        [JsonProperty(PropertyName = "menus")]
        public List<Menu> Menus { get; set; }
    }
}
