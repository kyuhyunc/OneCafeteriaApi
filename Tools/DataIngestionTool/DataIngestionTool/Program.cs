namespace DataIngestionTool
{
    using Newtonsoft.Json;
    using OneCafeteriaApi.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Microsoft.Azure.Documents;
    using Microsoft.Azure.Documents.Client;
    using System.Threading.Tasks;

    public class Program
    {
        private const string EndpointUrl = "https://onecafeteria.documents.azure.com:443/";
        private const string PrimaryKey = "OBIqLYblGgHKkx58l7IuCIAI7GJGii4ZNWbfMLBcOzeBIcwRsrZMjAzl74ZdyjxtTLWHRNhJe5Lq2wbdotvrJQ==";
        private const string databaseName = "RestaurantDb";
        private const string collectionName = "OneCafeteriaCollection";
        
        static void Main(string[] args)
        {
            IngestData().Wait();
            
            return;
        }

        static async Task IngestData()
        {
            string json = File.ReadAllText("data.json");
            var restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(json);

            DocumentClient client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);

            foreach (var restaurant in restaurants)
            {
                try
                {
                    await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), restaurant);
                    Console.WriteLine("Succesfully created a restaurant {0}", restaurant.Id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to create a restaurant {0}", restaurant.Id);
                }
            }
        }
    }
}