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

    public class Program
    {
        private const string EndpointUrl = "https://onecafeteria.documents.azure.com:443/";
        private const string PrimaryKey = "OBIqLYblGgHKkx58l7IuCIAI7GJGii4ZNWbfMLBcOzeBIcwRsrZMjAzl74ZdyjxtTLWHRNhJe5Lq2wbdotvrJQ==";
        
        static void Main(string[] args)
        {
            
            string json = File.ReadAllText("data.json");
            var restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(json);

            DocumentClient client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);

            return;
        }
    }
}