using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.ViewModels
{
	public class DepartmentsViewModel : Common
	{
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование отдела")]
		public string Name { get; set; }
		[DisplayName("Наименование категории")]
		public string GroupName { get; set; }
	}
}
