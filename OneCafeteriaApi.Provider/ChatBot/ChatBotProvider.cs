using System;
using System.Collections.Generic;
using System.Text;
using OneCafeteriaApi.Models.ResponseModels;

namespace OneCafeteriaApi.Provider.ChatBot
{
    public class ChatBotProvider : IChatBotProvider
    {
        public IEnumerable<OneCafeteriaApi.Models.ResponseModels.Restaurant> GetSuggestions(string query)
        {
            throw new NotImplementedException();
        }
    }
}
