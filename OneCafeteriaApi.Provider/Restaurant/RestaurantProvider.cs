using System;
using System.Collections.Generic;
using System.Text;
using OneCafeteriaApi.Models.ResponseModels;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using System.Linq;

namespace OneCafeteriaApi.Provider.Restaurant
{
    public class RestaurantProvider : IRestaurantProvider
    {
        private const string EndpointUrl = "https://onecafeteria.documents.azure.com:443/";
        private const string PrimaryKey = "OBIqLYblGgHKkx58l7IuCIAI7GJGii4ZNWbfMLBcOzeBIcwRsrZMjAzl74ZdyjxtTLWHRNhJe5Lq2wbdotvrJQ==";
        private const string databaseName = "RestaurantDb";
        private const string collectionName = "OneCafeteriaCollection";

        private readonly DocumentClient client;

        public RestaurantProvider()
        {
            this.client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
        }

        public IEnumerable<OneCafeteriaApi.Models.ResponseModels.Restaurant> GetAllRestaurants()
        {
            List<OneCafeteriaApi.Models.ResponseModels.Restaurant> results = new List<OneCafeteriaApi.Models.ResponseModels.Restaurant>();

            IQueryable<OneCafeteriaApi.Provider.Models.Restaurant> queryResults = this.client.CreateDocumentQuery<OneCafeteriaApi.Provider.Models.Restaurant>(
                UriFactory.CreateDocumentCollectionUri(databaseName, collectionName));

            foreach (var queryResult in queryResults)
            {
                OneCafeteriaApi.Models.ResponseModels.Restaurant result = new OneCafeteriaApi.Models.ResponseModels.Restaurant();
                result.Id = queryResult.Id;
                result.Name = queryResult.Name;
                result.Location = queryResult.Location;
                result.Rating = queryResult.Rating;

                // Pick a random picture from reviews
                if (queryResult.Reviews != null && queryResult.Reviews.Any())
                {
                    var pictures = queryResult.Reviews.Where(r => !string.IsNullOrWhiteSpace(r.Picture.OriginalString)).Select(rr => rr.Picture);

                    if (pictures.Count() > 0)
                    {
                        Random rnd = new Random();
                        int picIdx = rnd.Next(0, pictures.Count());

                        result.PictureUri = pictures.ElementAt(picIdx);
                    }
                }             

                results.Add(result);
            }

            return results;
        }

        public OneCafeteriaApi.Models.ResponseModels.RestaurantDetail GetRestaurantDetail(string id)
        {
            List<OneCafeteriaApi.Models.ResponseModels.RestaurantDetail> results = new List<OneCafeteriaApi.Models.ResponseModels.RestaurantDetail>();

            IQueryable<OneCafeteriaApi.Provider.Models.Restaurant> queryResults = this.client.CreateDocumentQuery<OneCafeteriaApi.Provider.Models.Restaurant>(
                UriFactory.CreateDocumentCollectionUri(databaseName, collectionName)).Where(r => r.Id.ToLower().Equals(id.ToLower()));

            foreach (var queryResult in queryResults)
            {
                OneCafeteriaApi.Models.ResponseModels.RestaurantDetail result = new OneCafeteriaApi.Models.ResponseModels.RestaurantDetail();
                result.Id = queryResult.Id;
                result.Name = queryResult.Name;
                result.Location = queryResult.Location;
                result.Rating = queryResult.Rating;
                result.Menus = queryResult.Menus;
                result.Reviews = queryResult.Reviews;

                results.Add(result);
            }

            return results.FirstOrDefault();
        }
    }
}
