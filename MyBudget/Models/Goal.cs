using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    public class Goal
    {
        public int GoalID { get; set; }

        [Required(ErrorMessage = "Income Goal is required")]
        [Range(0, 1000000, ErrorMessage = "Posible value from 0 to 1000000")]
        public float? IncomeGoal { get; set; }

        [Required(ErrorMessage = "Budget Goal is required")]
        [Range(0, 1000000, ErrorMessage = "Posible value from 0 to 1000000")]
        public float? BudgetGoal { get; set; }

        [Required(ErrorMessage = "Saving Goal is required")]
        [Range(0, 1000000, ErrorMessage = "Posible value from 0 to 1000000")]
        public float? SavingGoal { get; set; }

        public DateTime GoalMonth { get; set; }

        public string IdentityUserID { get; set; }

        public Microsoft.AspNetCore.Identity.IdentityUser IdentityUser
        { get; set; }

    }
}
