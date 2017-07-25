
namespace OneCafeteriaApi.Models.ResponseModels
{
    using System;

    public class Restaurant
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public double Rating { get; set; }

        public Uri PictureUri { get; set; }
    }
}
