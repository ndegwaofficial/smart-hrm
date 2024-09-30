using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public interface ITrack
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; } // int? because at first add, there is no modification
        public DateTime? DateModified { get; set; }
    }
}
