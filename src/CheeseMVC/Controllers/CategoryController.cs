using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Data;
using CheeseMVC.ViewModels;
using CheeseMVC.Models;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {

        //-p1- VIEW ALL CATEGORIES and THE VIEW
        //retrieve list of all categories and pass it into the view
        public IActionResult Index()
        {
            var cheeseCategories = context.Categories.ToList();
            return View(cheeseCategories);
        }

        //-p1- ADDING CATEGORIES
        /*
        from assignment: 
        This code would need to be added to each controller 
        class that you want to have access to the persistent 
        collections defined within CheeseDbContext. 
        (private readonly and public block after this comment)
        */

        //mechanism used to interact with objects in the db
        private readonly CheeseDbContext context;
        //constructor
        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        //-p1- ADD ACTION METHODS
        public IActionResult Add()
        {
            //new instance of AddCategoryViewModel
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            //check if model is valid
            if (ModelState.IsValid)
            {
                // if valid, Create a new CheeseCategory object (newCategory) with Name property having the value of Name from the ViewModel
                CheeseCategory newCategory = new CheeseCategory
                {
                    Name = addCategoryViewModel.Name,
                };

                //Add newCategory to the database context and save the changes to the db
                context.Categories.Add(newCategory);
                context.SaveChanges();

                //Redirect to the Index action for CategoryController
                return Redirect("/Category");
            }
            //if not valid, return the view and pass the viewmodel into the view
            return View(addCategoryViewModel);
        }

    }
}