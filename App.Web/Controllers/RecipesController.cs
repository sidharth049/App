using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Service;
using App.ViewModel;
using System.Threading.Tasks;
using App.Infrastructure;

namespace App.Web.Controllers
{
    public class RecipesController : BaseController
    {
        private readonly IRecipesService recipesService;
        private readonly IUnitOfWork unitOfWork;

        public RecipesController(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }

        // GET: Recipe
        public ActionResult Index(string title = null)
        {
            IEnumerable<RecipeViewModel> recipes = recipesService.GetRecipes(title);
            return View(recipes);
        }

        public ActionResult Recipe(int id)
        {
            return View(recipesService.GetRecipe(id));
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(RecipeViewModel recipe)
        {
            recipe.CreatedBy = CurrentUser;

            recipesService.AddRecipe(recipe);
            recipesService.Save();

            return RedirectToAction("Index");
        }
    }
}