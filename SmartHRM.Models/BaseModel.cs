using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public  class BaseModel
    {
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "varchar(450)")]
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "varchar(450)")]
        public string? ModifiedBy { get; set; }

    }
}
