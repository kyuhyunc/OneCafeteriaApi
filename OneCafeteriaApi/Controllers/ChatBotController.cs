namespace OneCafeteriaApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using OneCafeteriaApi.Provider.ChatBot;
    using OneCafeteriaApi.Models.ResponseModels;

    public class ChatBotController : Controller
    {
        private readonly IChatBotProvider chatBotProvider;

        public ChatBotController(IChatBotProvider chatBotProvider)
        {
            this.chatBotProvider = chatBotProvider;
        }

        [HttpGet]
        [Route("api/chatbot/getsuggestions/{query}")]
        public IEnumerable<Restaurant> GetSuggestions(string query)
        {
            return this.chatBotProvider.GetSuggestions(query);
        }
    }
}

