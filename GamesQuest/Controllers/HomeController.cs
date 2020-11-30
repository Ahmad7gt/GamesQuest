using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using GamesQuest.Models;
using GamesQuest.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GamesQuest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Deals = _productRepository.IsDeals
            };

            return View(homeViewModel);
        }
    }
}
