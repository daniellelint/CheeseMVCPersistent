using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    //this class represents the Many-to-Mant relationship btwn Menu and Cheese classes
    public class CheeseMenu
    {
        //-p3- set up
        public int MenuID { get; set; }
        public Menu Menu { get; set; }

        public int CheeseID { get; set; }
        public Cheese Cheese { get; set; }
    }
}
