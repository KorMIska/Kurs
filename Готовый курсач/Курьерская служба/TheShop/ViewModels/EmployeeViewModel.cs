using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.ViewModels
{
	public class EmployeeViewModel:Common
	{
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Имя сотрудника")]
		public string Name { get; set; }
		[Browsable(false)]
		public Guid PostId { get; set; }
		[DisplayName("Наименование должности")]
		public string PostName { get; set; }
		[Browsable(false)]
		public Guid DepartmentId { get; set; }
		[DisplayName("Наименование отдела")]
		public string DepartmentName { get; set; }

	}
}
