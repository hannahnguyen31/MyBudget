using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            
            //var budgets = MyContext.Budgets.OrderBy(m => m.Category).ToList();
            //var budgets = MyContext.Budgets.FromSqlRaw("select * from Budgets where Month = '1/1/0002 12:00:00 AM'").ToList();
            var budgets = MyContext.Budgets.FromSqlRaw("select * from Budgets where MONTH(Month) = '12'").ToList();
            //var budgets = MyContext.Budgets.FromSqlRaw("select SUM(Budgeted) from Budgets where MONTH(Month) = '1'").ToList();
            //var budgets = MyContext.Budgets.FromSqlRaw("select * from Budgets where Budgeted>100").ToList();
            //var budgets = MyContext.Budgets.FromSqlRaw("select * from Budgets where identityUserId = '79331e8f - c617 - 4825 - 9f49 - e866660e09c1'").ToList();

            return View(budgets);
        }


        public IActionResult Income()
        {
           //var incomes = MyContext.incomes.OrderBy(m => m.IncomeSource).ToList();
            var incomes = MyContext.incomes.FromSqlRaw("select * from incomes where MONTH(IncomeMonth) = '12'").ToList();


            return View(incomes);
        }

        public IActionResult Goal()
        {
            var goals = MyContext.Goals.OrderBy(m => m.GoalMonth).ToList();
            return View(goals);

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
