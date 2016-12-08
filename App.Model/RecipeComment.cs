using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class RecipeComment : ModelBase
    {
        public string RecipeCommentId { get; set; }
        public string Comment { get; set; }
    }
}
