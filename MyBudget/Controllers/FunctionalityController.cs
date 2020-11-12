using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBudget.Data;
using MyBudget.Models;

namespace MyBudget.Controllers
{
    public class FunctionalityController : Controller
    {
        private ApplicationDbContext MyContext { get; set; }

        public FunctionalityController(ApplicationDbContext context)
        {
            MyContext = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.action = "Add";
            return View("Edit", new Budget());
        }

        [HttpGet]
        public IActionResult AddIncome()
        {
            ViewBag.action = "Add Income";
            return View("EditIncome", new Income());
        }
           

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.action = "Edit";
            var budget = MyContext.Budgets.Find(id);
            return View(budget);
        }

        [HttpGet]
        public IActionResult EditIncome(int id)
        {
            ViewBag.action = "Edit Income";
            var income = MyContext.incomes.Find(id);
            return View(income);
        }
        

        [HttpPost]
        public IActionResult Edit(Budget budget)
        {
            if (ModelState.IsValid)
            {
                if (budget.BudgetID == 0)
                {
                    MyContext.Budgets.Add(budget);
                }
                else

                    MyContext.Budgets.Update(budget);
                MyContext.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.action = (budget.BudgetID == 0) ? "Add" : "Edit";
                return View(budget);

            }

        }

        [HttpPost]
        public IActionResult EditIncome(Income income)
        {
            if (ModelState.IsValid)
            {
                if (income.IncomeID == 0)
                {
                    MyContext.incomes.Add(income);
                }
                else

                    MyContext.incomes.Update(income);
                MyContext.SaveChanges();
                return RedirectToAction("Income", "Home");

            }
            else
            {
                ViewBag.action = (income.IncomeID == 0) ? "AddIncome" : "EditIncome";
                return View(income);

            }

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.action = "Delete";
            var budget = MyContext.Budgets.Find(id);
            return View(budget);
        }

        [HttpGet]
        public IActionResult DeleteIncome(int id)
        {
            ViewBag.action = "DeleteIncome";
            var income = MyContext.incomes.Find(id);
            return View(income);
        }
          


        [HttpPost]
        public IActionResult Delete(Budget budget)
        {
            MyContext.Budgets.Remove(budget);
            MyContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult DeleteIncome(Income income)
        {
            MyContext.incomes.Remove(income);
            MyContext.SaveChanges();
            return RedirectToAction( "Income", "Home");
        }

    }
}

    

