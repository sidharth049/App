using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Model
{
    [Table("Recipes")]
    public class Recipe : ModelBase
    {
        public int RecipeId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Preparation { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual User User { get; set; }

        public virtual ICollection<RecipeComment> RecipeComments { get; set; }
    }
}
