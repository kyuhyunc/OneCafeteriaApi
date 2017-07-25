namespace OneCafeteriaApi.Models
{
    using Newtonsoft.Json;
    using System;

    public class Review
    {
        public Uri Picture { get; set; }

        public int Rating { get; set; }

        public string FoodName { get; set; }
    }
}
