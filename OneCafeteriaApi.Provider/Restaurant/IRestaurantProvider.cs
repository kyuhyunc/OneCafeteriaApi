using System;
using System.Collections.Generic;

namespace OneCafeteriaApi.Provider.Restaurant
{
    public interface IRestaurantProvider
    {
        IEnumerable<OneCafeteriaApi.Models.ResponseModels.Restaurant> GetAllRestaurants();

        OneCafeteriaApi.Models.ResponseModels.RestaurantDetail GetRestaurantDetail(string id);
    }
}
