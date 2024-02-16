using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.Models
{
	public class Employee:Common
	{
		[Browsable(false)]
		public Guid Id { get; set; }
		public string Name { get; set; }
		[Browsable(false)]
		public Guid PostId { get; set; }
		[Browsable(false)]
		public Post Post { get; set; }
		[Browsable(false)]
		public Guid DepartmentId { get; set; }
		[Browsable(false)]
		public Department Department { get; set; }
	}
}
