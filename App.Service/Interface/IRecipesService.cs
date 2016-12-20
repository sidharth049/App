using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ViewModel;

namespace App.Service
{
    public interface IRecipesService
    {
        RecipeViewModel GetRecipe(int id);

        IEnumerable<RecipeViewModel> GetRecipes(string title = null);

        void AddRecipe(RecipeViewModel recipe);

        void UpdateRecipe(RecipeViewModel recipe);

        void DeleteRecipe(int id);

        void Save();
    }
}
