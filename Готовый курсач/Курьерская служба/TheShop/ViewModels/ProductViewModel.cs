using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.ViewModels
{
	public class ProductViewModel : Common
	{

		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование посылки")]
		public string Name { get; set; }
		[DisplayName("Количество")]
		public string Amount { get; set; }
		[DisplayName("Стоимость")]
		public string BuyingPrice { get; set; }
		[DisplayName("Вес ")]
		public string SellingPrice { get; set; }
		[DisplayName("Наименование категории")]
		public string GroupName { get; set; }
		[DisplayName("Наименование вида оплаты")]
		public string UnitName { get; set; }
		[DisplayName("Наименование отправителя")]
		public string ProviderName { get; set; }
		[DisplayName("Наименование получателя")]
		public string ManufacturerName { get; set; }
	}
}
