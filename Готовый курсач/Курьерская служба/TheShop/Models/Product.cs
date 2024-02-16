using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Interfaces;

namespace TheShop.Models
{
	public class Product : Common
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Amount { get; set; }
		/// <summary>
		/// Закупочная цена
		/// </summary>
		public float BuyingPrice { get; set; }
		/// <summary>
		/// Отпускная цена
		/// </summary>
		public float SellingPrice { get; set; }
		public Guid GroupId { get; set; }
		public Group Group { get; set; }
		public Guid UnitId { get; set; }
		public Unit Unit { get; set; }
		public Guid ProviderId { get; set; }
		public Provider Provider { get; set; }
		public Guid ManufacturerId { get; set; }
		public Manufacturer Manufacturer { get; set; } 
	}
}
