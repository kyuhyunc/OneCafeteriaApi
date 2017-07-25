namespace OneCafeteriaApi.Models
{
    using System;

    public class Review
    {
        public Uri Picture { get; set; }

        public int Rating { get; set; }

        public string Name { get; set; }
    }
}
