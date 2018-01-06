using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        //-p1- set up
        public string Name { get; set; }
        public string Description { get; set; }
        //public CheeseType Type { get; set; }
        public int ID { get; set; }
        //-p2- REPLACE CHEESETYPE WITH CHEESECATEGORY
        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }
        //-p3-The Menu and CheeseMenu Classes
        public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
