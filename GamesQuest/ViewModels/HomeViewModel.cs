using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GamesQuest.Models;

namespace GamesQuest.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> Deals { get; set; }
    }
}
