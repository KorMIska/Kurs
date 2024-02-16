using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.Models
{
	/// <summary>
	/// Производитель
	/// </summary>
	public class Manufacturer : Common
	{
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("ФИО получателя")]
		public string Name { get; set; }
		[DisplayName("Адрес получателя")]
		public string Addres { get; set; }
		[Browsable(false)]
		public ICollection<Product> Products { get; set; }


	}
}
