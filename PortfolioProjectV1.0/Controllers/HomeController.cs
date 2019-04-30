using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectV1._0.Infrastructure.Interfaces;
using PortfolioProjectV1._0.Models;
using PortfolioProjectV1._0.TibiaData;
using PortfolioProjectV1._0.TibiaData.TibiaDataAPI;


namespace PortfolioProjectV1._0.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(string nickname)
        {
            CharacterApi characterApi = new CharacterApi(nickname);

            if (characterApi.Characters.Error == "Character does not exist.")
            {
                return View("InvalidNickname");

            }
            else
            {
                return View("CharacterDetails", characterApi.Characters);
            }
        }

        [HttpGet]
        public ViewResult World()
        {
            WorldApi worldApi = new WorldApi("Worlds");

            return View(worldApi);
        }

        [HttpPost]
        public ViewResult World(string name)
        {
            return View();
        }
    }
}