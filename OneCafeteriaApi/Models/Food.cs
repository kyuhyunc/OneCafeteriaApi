namespace OneCafeteriaApi.Models
{
    using System.Collections.Generic;

    public class Food
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Price { get; set; }

        public bool IsVegan { get; set; }

        public bool Isvegetarian { get; set; }
    }
}
