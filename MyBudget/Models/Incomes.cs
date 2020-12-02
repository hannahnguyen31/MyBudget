using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    public class Income
    {
        public int IncomeID { get; set; }

        [Required(ErrorMessage = " Income source is required")]
        public string IncomeSource { get; set; }

        [Required(ErrorMessage = " Amount is required")]
        [Range(0,1000000, ErrorMessage ="Posible value from 0 to 1000000")]
        public float? Amount{ get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime IncomeMonth { get; set; }

        public string IdentityUserID { get; set; }

        public Microsoft.AspNetCore.Identity.IdentityUser IdentityUser
        { get; set; }

    }
}
