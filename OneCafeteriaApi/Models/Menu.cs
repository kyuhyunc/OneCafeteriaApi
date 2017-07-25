namespace OneCafeteriaApi.Models
{
    using System.Collections.Generic;

    public class Menu
    {
        public string Day { get; set; }

        public IEnumerable<Food> Foods { get; set; }
    }
}
