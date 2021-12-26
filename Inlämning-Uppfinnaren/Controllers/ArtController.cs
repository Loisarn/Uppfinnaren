using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;
using System.Diagnostics;
using Microsoft.Extensions.Logging;




namespace Uppfinnaren.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository _artRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ArtController(IArtRepository artRepository, ICategoryRepository categoryRepository)
        {
            _artRepository = artRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.Art = _artRepository.AllArt;

            artListViewModel.CurrentCategory = "Inventions and Art";
            return View(artListViewModel);
        }

        public IActionResult Details(int id)
        {
            var art = _artRepository.GetArtById(id);
            if (art == null)
                return NotFound();
            return View(art);
        }

        public IActionResult Animals()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.Art = _artRepository.AllArt;

            artListViewModel.CurrentCategory = "Animals";
            return View(artListViewModel);
        }

        public IActionResult Bowls()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.Art = _artRepository.AllArt;

            artListViewModel.CurrentCategory = "Bowls";
            return View(artListViewModel);
        }

        public IActionResult Spoons()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.Art = _artRepository.AllArt;

            artListViewModel.CurrentCategory = "Spoons";
            return View(artListViewModel);
        }

        public IActionResult Toys()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.Art = _artRepository.AllArt;

            artListViewModel.CurrentCategory = "Toys";
            return View(artListViewModel);
        }

    }

}