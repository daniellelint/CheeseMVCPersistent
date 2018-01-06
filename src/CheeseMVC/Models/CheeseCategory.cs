using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        //-p1- SET UP THE NEW MODEL

        //initialize the properties for the db
        public int ID { get; set; }

        /*
        [Required]
        [Display(Name = "Cheese Category:")]
        */
        public string Name { get; set; }

        //-p2- ADD CHEESE TO CHEESECATEGORY
        public IList<Cheese> Cheeses { get; set; }
    }
}
