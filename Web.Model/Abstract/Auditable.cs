using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }

        [MaxLength(255)]
        public string MetaKeyword { get; set; }

        [MaxLength(255)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
