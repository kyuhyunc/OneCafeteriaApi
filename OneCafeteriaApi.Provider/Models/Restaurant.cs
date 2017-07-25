
namespace OneCafeteriaApi.Provider.Models
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
        public string Location { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; set; }

        [JsonProperty(PropertyName = "reviews")]
        public List<OneCafeteriaApi.Models.Review> Reviews { get; set; }

        [JsonProperty(PropertyName = "menus")]
        public List<OneCafeteriaApi.Models.Menu> Menus { get; set; }
    }
}
