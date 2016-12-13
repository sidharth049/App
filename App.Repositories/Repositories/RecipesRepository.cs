﻿using App.Infrastructure;
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
    }
}
