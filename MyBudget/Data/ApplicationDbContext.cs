using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBudget.Models;

namespace MyBudget.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Income> incomes { get; set; }
      
        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);
            myModelBuilder.Entity<Budget>().HasData(
                new Budget
                {
                    BudgetID = 1,
                    Category = "Mortgate",
                    Budgeted = 2000,
                    Activity = 2000,
                    Available = 0,
                    Month = DateTime.Parse("2020-10-03")
                },
                new Budget
                {
                    BudgetID = 2,
                    Category = "Food",
                    Budgeted = 1000,
                    Activity = 800,
                    Available = 200,
                    Month = DateTime.Parse("2020-11-23")
                },
                new Budget
                {
                    BudgetID = 3,
                    Category = "Utilities",
                    Budgeted = 200,
                    Activity = 150,
                    Available = 50,
                    Month = DateTime.Parse("2020-09-27")
                }

                );

            myModelBuilder.Entity<Income>().HasData(
                new Income
                {
                    IncomeID = 5,
                    IncomeSource = "Salary",
                    Amount = 2000,
                    IncomeMonth = DateTime.Parse("2020-11-25")
                },
                new Income
                {
                    IncomeID = 6,
                    IncomeSource = "Rent out house",
                    Amount = 1000,
                    IncomeMonth = DateTime.Parse("2020-10-02")
                },
                new Income
                {
                    IncomeID = 7,
                    IncomeSource = "Stock divided",
                    Amount = 600,
                    IncomeMonth = DateTime.Parse("2020-11-01")
                }

                );
        }

    }

}

    


    

