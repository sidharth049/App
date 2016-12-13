using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Infrastructure;
using App.Repositories;
using App.Model;

namespace App.Service
{
    public class RecipesService : IRecipesService
    {
        private readonly IRecipesRepository recipesRepository;
        private readonly IUnitOfWork unitOfWork;

        public RecipesService(IRecipesRepository recipesRepository, IUnitOfWork unitOfWork)
        {
            this.recipesRepository = recipesRepository;
            this.unitOfWork = unitOfWork;
        }

        public Recipe GetRecipe(int id)
        {
            return recipesRepository.GetById(id);
        }

        public IEnumerable<Recipe> GetRecipes(string title = null)
        {
            if (string.IsNullOrEmpty(title))
            {
                return recipesRepository.GetAll();
            }
            else
            {
                return recipesRepository.GetRecipesByTitle(title);
            }
        }
    }
}
