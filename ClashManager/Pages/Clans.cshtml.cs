using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClashManager.Domain.Db.Abstractions;
using ClashManager.Domain.Services.ClashApiGateway;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ClashManager.Pages
{
    public class ClansModel : PageModel
    {
        public List<Clan> Clans;
        private IClashApiGatewayService ClashApiGatewayService;
        private IAccountDb AccountDb;

        public ClansModel(IAccountDb accountDb, IClashApiGatewayService clashApiGatewayService)
        {
            Clans = new List<Clan>();

            ClashApiGatewayService = clashApiGatewayService;
            AccountDb = accountDb;
        }

        public void OnGet()
        {
            Claim objId = User.Claims.First();
            var result = AccountDb.GetClans(objId.Value);
            foreach (var clan in result.Clans)
            {
                var clanrequest = ClashApiGatewayService.GetClanAsync(clan.ClanTag).Result;
                Clans.Add(new Clan(clanrequest.Name, clanrequest.Tag, clanrequest.BadgeUrls.Medium));
            }
        }
    }

    public class Clan
    {
        public string Name { get; set; }
        public string ClanTag { get; set; }
        public string BadgeUrl { get; set; }

        public Clan(string name, string tag, string badgeUrl)
        {
            Name = name;
            ClanTag = tag;
            BadgeUrl = badgeUrl;
        }
    }
}
