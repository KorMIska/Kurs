using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.Models
{
	public class Provider : Common
	{
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Название отправителя")]
		public string Name { get; set; }
		[DisplayName("Адрес отправителя")]
		public string Addres { get; set; }
		[DisplayName("Номер посылки")]
		public string BankDetails { get; set; }
		[Browsable(false)]
		public ICollection<Product> Products { get; set; }
	}
}
