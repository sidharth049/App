using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model;
using System.Collections;

namespace App.Repositories
{
    public interface IRecipesRepository : IRepository<Recipe>
    {
        IEnumerable<Recipe> GetRecipesByTitle(string title);
    }
}
