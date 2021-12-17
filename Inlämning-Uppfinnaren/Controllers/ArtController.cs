using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inlämning_Uppfinnaren.Models;
using Inlämning_Uppfinnaren.ViewModels;
using System.Diagnostics;
using Microsoft.Extensions.Logging;



namespace Inlämning_Uppfinnaren.Controllers
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
    }

}