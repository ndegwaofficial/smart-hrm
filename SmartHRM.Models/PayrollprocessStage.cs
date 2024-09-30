using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class PayrollprocessStage : BaseModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [DefaultValue(false)]
        public bool Final { get; set; }
        public string symbol { get; set; }

    }
}
