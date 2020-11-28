using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    public class Budget
    {
        public int BudgetID { get; set; }

        [Required(ErrorMessage = " Category is required")]

        public string Category { get; set; }

        [Required(ErrorMessage = " Budget is required")]
        [Range(0, 100000, ErrorMessage = " Possible value from 0 to 1000000")]

        public float? Budgeted { get; set; }

        [Required(ErrorMessage = " Activity is required")]
        [Range(0, 1000000, ErrorMessage = " Possible value from 0 to 1000000")]

        public float? Activity { get; set; }

        [Required(ErrorMessage = " Available is required")]
        [Range(0, 1000000, ErrorMessage = " Possible value from 0 to 1000000")]

        public float Available { get; set; }

        public DateTime Month { get; set; }

        public string IdentityUserID { get; set; }

        public Microsoft.AspNetCore.Identity.IdentityUser IdentityUser
        { get; set; }
    }
}
