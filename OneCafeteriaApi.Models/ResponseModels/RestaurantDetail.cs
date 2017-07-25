
namespace OneCafeteriaApi.Models.ResponseModels
{
    using System.Collections.Generic;

    public class RestaurantDetail
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public double Rating { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
