using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    [Table("RecipeComments")]
    public class RecipeComment : ModelBase
    {
        public int RecipeCommentId { get; set; }

        [Required]
        public string Comment { get; set; }

        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public virtual Recipe Recipe { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual User User { get; set; }
    }
}
