using ClashManager.Domain.Services.ClashApiGateway;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClashManager.Pages
{
    public class IndexModel : PageModel
    {
        private IClashApiGatewayService ClashApiGatewayService { get; set; }
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string ClanTag { get; set; }
        [BindProperty]
        public string PlayerTag { get; set; }

        private string DefaultValue { get; } = "#";

        public IndexModel(IClashApiGatewayService clashApiGatewayService, ILogger<IndexModel> logger)
        {
            ClashApiGatewayService = clashApiGatewayService;
            _logger = logger;
        }

        public void OnGet()
        {
            ClanTag = DefaultValue;
            PlayerTag = DefaultValue;
        }

        public async void OnPost()
        {
            if (HasUserInput(ClanTag))
            {
                Console.WriteLine("Adding clan");
                var clan = await ClashApiGatewayService.GetClanAsync(ClanTag);
                ClanTag = DefaultValue;
            }

            if (HasUserInput(PlayerTag))
            {
                Console.WriteLine("Adding player");
                var player = await ClashApiGatewayService.GetPlayerAsync(PlayerTag);
                PlayerTag = DefaultValue;
            }
        }

        private bool HasUserInput(string field)
        {
            // _ = false
            // # = false
            // #XXXXXXX = true
            return !string.IsNullOrWhiteSpace(field) && field.Length > 1;
        }

    }
}
