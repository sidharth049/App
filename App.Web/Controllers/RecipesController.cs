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
            if (ModelState.IsValid)
            {
                recipe.CreatedBy = CurrentUser;
                recipe.CreatedDate = DateTime.UtcNow;
                recipe.UpdatedDate = DateTime.UtcNow;

                recipesService.AddRecipe(recipe);
                recipesService.Save();

                return RedirectToAction("Index");
            }

            return View(recipe);
        }


        public ActionResult Edit(int id)
        {
            return View(recipesService.GetRecipe(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "RecipeId,Title,Preparation,CreatedBy")]RecipeViewModel recipe)
        {
            if (ModelState.IsValid)
            {
                recipe.UpdatedBy = CurrentUser;
                recipe.UpdatedDate = DateTime.UtcNow;

                recipesService.UpdateRecipe(recipe);
                recipesService.Save();

                return View("Recipe", recipesService.GetRecipe(recipe.RecipeId));
            }

            return View("Edit", recipesService.GetRecipe(recipe.RecipeId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            recipesService.DeleteRecipe(id);
            recipesService.Save();

            return RedirectToAction("Index");
        }
    }
}