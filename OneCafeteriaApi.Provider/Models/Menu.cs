namespace OneCafeteriaApi.Provider.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Menu
    {
        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        [JsonProperty(PropertyName = "foods")]
        public List<Food> Foods { get; set; }
    }
}
