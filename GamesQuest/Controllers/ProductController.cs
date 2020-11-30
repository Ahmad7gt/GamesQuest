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
    public class ProductController : Controller
    {
        private readonly IProductRepository _iProductRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _iProductRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _iProductRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else
            {
                products = _iProductRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            var x = new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            };
            return View(x);
        }
    }
}
