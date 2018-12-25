using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string CustomName { get; set; }

        [Required]
        [MaxLength(255)]
        public string CustomAddress { get; set; }

        [Required]
        [MaxLength(255)]
        public string CustomEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomMobile { get; set; }

        [Required]
        [MaxLength(255)]
        public string CustomMessage { get; set; }

        [Required]
        [MaxLength(255)]
        public string PaymentMethod { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}