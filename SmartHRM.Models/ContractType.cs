using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class ContractType : BaseModel
    {
		public int Id { get; set; }
		[Required]
		[Display(Name ="Contract Type")]
		public string TypeName { get; set; }
        //public DateTime DateCreated { get; set; }

        //public DateTime DateModified { get; set; }
    }
}
