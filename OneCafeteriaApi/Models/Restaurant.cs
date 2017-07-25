
namespace OneCafeteriaApi.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Restaurant
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Locaiton { get; set; }

        public double Rating { get; set; }

        public IEnumerator<Review> Reviews { get; set; }

        public IEnumerator<Menu> Menus { get; set; }
    }
}
