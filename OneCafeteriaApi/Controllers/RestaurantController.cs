namespace OneCafeteriaApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using OneCafeteriaApi.Provider.Restaurant;
    using OneCafeteriaApi.Models.ResponseModels;

    public class RestaurantController : Controller
    {
        private readonly IRestaurantProvider restaurantProvider;

        public RestaurantController(IRestaurantProvider restaurantProvider)
        {
            this.restaurantProvider = restaurantProvider;
        }

        [HttpGet]
        [Route("api/restaurant/getallrestaurants")]
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return this.restaurantProvider.GetAllRestaurants();
        }

        [HttpGet]
        [Route("api/restaurant/getrestaurantdetail/{id}")]
        public RestaurantDetail GetRestaurantDetail(string id)
        {
            return this.restaurantProvider.GetRestaurantDetail(id);
        }
    }
}
