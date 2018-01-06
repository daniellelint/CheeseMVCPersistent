using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel //uses the CheeseCategory as a base : CheeseCategory
    {
        //-p1- ADD CATEGORY VIEW MODEL and ADD VIEW
        [Required]
        [Display(Name = "Cheese Category:")]
        public string Name { get; set; }

    }
}
