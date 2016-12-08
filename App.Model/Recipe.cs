using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Recipe : ModelBase
    {
        public string RecipeId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
