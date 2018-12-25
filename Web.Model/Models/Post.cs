using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model.Abstract;

namespace Web.Model.Models
{
    [Table("Posts")]
   public class Post:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string  Name { get; set; }
        [Required]
        [MaxLength(255)]
        [Column(TypeName ="varchar")]
        public string Alias { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [MaxLength(255)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }
    }
}
