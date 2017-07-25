using System;
using System.Collections.Generic;
using System.Text;
using OneCafeteriaApi.Models.ResponseModels;

namespace OneCafeteriaApi.Provider.Restaurant
{
    public class RestaurantProvider : IRestaurantProvider
    {
        public IEnumerable<RestaurantDetail> GetRestaurantDetail()
        {
            throw new NotImplementedException();
        }

        IEnumerable<OneCafeteriaApi.Models.ResponseModels.Restaurant> IRestaurantProvider.GetAllRestaurants()
        {
            throw new NotImplementedException();
        }
    }
}
