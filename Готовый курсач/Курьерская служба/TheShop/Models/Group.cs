using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.Models
{
	public class Group : Common
	{
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование посылки")]
		public string Name { get; set; }
		[Browsable(false)]
		public ICollection<Department> Departments{ get; set; }
		[Browsable(false)]
		public ICollection<Product> Products { get; set; }

	}
}
