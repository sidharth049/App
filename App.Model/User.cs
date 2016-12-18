using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Model
{
    [Table("Users")]
    public class User 
    {
        public int UserId { get; set; }

        [MaxLength(200)]
        [Required]
        public string Email { get; set; }

        [MaxLength(200)]
        [Required]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<RecipeComment> RecipeComments { get; set; }
    }
}
