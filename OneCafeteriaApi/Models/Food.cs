namespace OneCafeteriaApi.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Food
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "price")]
        public List<string> Price { get; set; }

        [JsonProperty(PropertyName = "isVegan")]
        public bool IsVegan { get; set; }

        [JsonProperty(PropertyName = "isVegetarion")]
        public bool IsVegetarian { get; set; }
    }
}
