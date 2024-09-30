
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Currency:BaseModel
    {
		public int Id { get; set; }
		public string CurrencyName { get; set; }
        [DefaultValue(false)]
        public bool Default { get; set; }
       
    }
}
