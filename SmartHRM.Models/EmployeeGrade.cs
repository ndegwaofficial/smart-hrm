using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class EmployeeGrade : BaseModel
    {
		public int Id { get; set; }
		[Required]
		[DisplayName("Name")]
		public string GradeName { get; set; }
		[DefaultValue(0)]
		[DisplayName("Lower Amount")]
		public double LowerAmount { get; set; }
		[DefaultValue(0)]
		[DisplayName("Upper Amount")]
		public double UpperAmount { get; set;}
		[DefaultValue(0)]
		[DisplayName("Daily Rate")]
		public double DailyRate { get; set; }
		[DefaultValue(0)]
		[DisplayName("Hoourly Rate")]
		public double HourlyRate { get; set; }
		[DefaultValue(0)]
		[DisplayName("Night Out Rate")]
		public double NightOutRate { get; set; }
		[DefaultValue(0)]
		[DisplayName("Perdiem Rate")]
		public double PerDiemRate { get; set; }
		[DefaultValue(0)]
		[DisplayName("Tonnage Rate")]
		public double TonnageRate { get; set; }
		[Required]
		[DefaultValue(false)]
		[DisplayName("Hourly?")]
		public bool opthourly { get; set; }
		[Required]
		[DefaultValue(false)]
		[DisplayName("Daily?")]
		public bool optdaily { get; set; }

		[Required]
		[DefaultValue(false)]
		[DisplayName("Tonnage")]
		public bool opttonnage { get; set; }
		[Required]
		[DefaultValue(false)]
		[DisplayName("Multiple Process")]
		public bool multipleprocess { get; set; }
		[Required]
		[DefaultValue(false)]
		[DisplayName("For Permanent Employees?")]
		public bool permanentemp { get; set; }
		[Required]
		[DefaultValue(0)]
		[DisplayName("Maximum Tonnage")]
		public double maxtonne { get; set; }
		[Required]
		[DefaultValue(0)]
		[DisplayName("Bonus Rate")]
		public double bonusrate { get; set; }
		[Required]
		[DefaultValue(0)]
		[DisplayName("Above Tonnage")]
		public double abovetonne { get; set; }
		[Required]
		[DefaultValue(0)]
		[DisplayName("Tonnage Pay")]
		public double payfortonnes { get; set; }

        
    }
}
