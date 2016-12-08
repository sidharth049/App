using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Model
{
    [Table("UserDetails")]
    public class UserDetail 
    {
        public int UserDetailId { get; set; }

        [MaxLength(100)]
        [Required]
        public string DisplayName { get; set; }


        public int Age { get; set; }

        [MaxLength(1)]
        [Required]
        public string Gender { get; set; }

        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
