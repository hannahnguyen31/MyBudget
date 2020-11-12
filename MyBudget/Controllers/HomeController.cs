using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBudget.Data;
using MyBudget.Models;

namespace MyBudget.Controllers
{
    public class HomeController : Controller
    {
       
        private ApplicationDbContext MyContext { get; set; }

        
        public HomeController(ApplicationDbContext context)
        {
            MyContext = context;
        }

        public IActionResult Index()
        {
            var budgets = MyContext.Budgets.OrderBy(m => m.Category).ToList();
            return View(budgets);
        }


        public IActionResult Income()
        {
            var incomes = MyContext.incomes.OrderBy(m => m.IncomeSource).ToList();
            return View(incomes);
        }

        
        public IActionResult Report()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
