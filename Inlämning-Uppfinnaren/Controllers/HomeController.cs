using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Uppfinnaren.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtRepository _artRepository;

        public HomeController(IArtRepository artRepository)
        {
            _artRepository = artRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ArtofTheWeek = _artRepository.ArtofTheWeek
            };

            return View(homeViewModel);
        }
    }

}