using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.Models
{
	public class Department : Common
	{

		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование отдела")]
		public string Name { get; set; }
		[Browsable(false)]
		public Guid GroupId { get; set; }
		[Browsable(false)]
		public Group Group { get; set; }
		[Browsable(false)]
		public ICollection<Employee> Employees { get; set; }
	}
}
