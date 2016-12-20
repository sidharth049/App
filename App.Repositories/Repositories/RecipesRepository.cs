using App.Infrastructure;
using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class RecipesRepository : RepositoryBase<Recipe>, IRecipesRepository
    {
        public RecipesRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Recipe> GetRecipesByTitle(string title)
        {
            return this.DbContext.Recipes.Where(e => e.Title.Contains(title)).ToList();
        }

        public void DeleteRecipe(int id)
        {
            var recipe = this.DbContext.Recipes.SingleOrDefault(e => e.RecipeId.Equals(id));

            this.DbContext.Recipes.Remove(recipe);
        }
    }
}
