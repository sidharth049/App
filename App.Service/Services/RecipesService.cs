using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Infrastructure;
using App.Repositories;
using App.Model;
using App.ViewModel;
using AutoMapper;

namespace App.Service
{
    public class RecipesService : ServiceBase, IRecipesService
    {
        private readonly IRecipesRepository recipesRepository;
        private readonly IUnitOfWork unitOfWork;

        public RecipesService(IRecipesRepository recipesRepository, IUnitOfWork unitOfWork)
        {
            this.recipesRepository = recipesRepository;
            this.unitOfWork = unitOfWork;
        }

        public RecipeViewModel GetRecipe(int id)
        {
            return Mapper.Map<Recipe, RecipeViewModel>(recipesRepository.GetById(id));
        }

        public IEnumerable<RecipeViewModel> GetRecipes(string title = null)
        {
            IEnumerable<RecipeViewModel> recipeViewModel;

            if (string.IsNullOrEmpty(title))
            {
                recipeViewModel = Mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeViewModel>>(recipesRepository.GetAll());
            }
            else
            {
                recipeViewModel = Mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeViewModel>>(recipesRepository.GetRecipesByTitle(title));
            }

            return recipeViewModel;
        }

        public void AddRecipe(RecipeViewModel recipe)
        {
            recipesRepository.Add(Mapper.Map<RecipeViewModel, Recipe>(recipe));
        }

        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
