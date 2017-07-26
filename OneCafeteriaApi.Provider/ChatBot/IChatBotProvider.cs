using System;
using System.Collections.Generic;
using System.Text;

namespace OneCafeteriaApi.Provider.ChatBot
{
    public interface IChatBotProvider
    {
        IEnumerable<OneCafeteriaApi.Models.ResponseModels.Restaurant> GetSuggestions(string query);
    }
}
