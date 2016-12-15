using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Service;
using App.ViewModel;

namespace App.Web.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipesService recipesService;

        public RecipesController(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }

        // GET: Recipe
        public ActionResult Index(string title = null)
        {
            IEnumerable<RecipeViewModel> recipes =  recipesService.GetRecipes(title);
            return View(recipes);
        }

        public ActionResult Recipe(int id)
        {
            return View(recipesService.GetRecipe(id));
        }
    }
}