using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheShop.Context;
using TheShop.Methods;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Forms
{
	public partial class ProductsForm : Form
	{
		public ProductsForm()
		{
			InitializeComponent();
		}


		ProjectContext context = new ProjectContext();
		CommonMethods commonMethods = new CommonMethods();
		ModelsMethods modelsMethods = new ModelsMethods();
		public bool isEditing = false;
		private void RefreshDataTable_Click(object sender, EventArgs e)
		{
			LoadTable();
		}
		private void LoadTable()
		{
			var deletedIds = context.ChangeTracker.Entries<Product>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
			var updatedIds = context.ChangeTracker.Entries<Product>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity.Id).ToList();
			List<ProductViewModel> list = new List<ProductViewModel>();
			if (updatedIds.Count > 0)
			{
				var updatedEntities = context.ChangeTracker.Entries<Product>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity).Select(modelsMethods.ConvertProductModel(context)).ToList();
				list = context.Products.Where(o => !deletedIds.Contains(o.Id) && !updatedIds.Contains(o.Id)).Include(o => o.Provider).Include(o => o.Unit).Include(o => o.Manufacturer).Include(o => o.Group)
					.Select(modelsMethods.ConvertProductModel()).ToList();
				list.AddRange(updatedEntities);
			}
			else
			{
				list = context.Products.Where(o => !deletedIds.Contains(o.Id)).Include(o => o.Provider).Include(o => o.Unit).Include(o => o.Manufacturer).Include(o => o.Group)
					.Select(modelsMethods.ConvertProductModel()).ToList();
			}
			if (!string.IsNullOrEmpty(SearchNameInput.Text) || !string.IsNullOrWhiteSpace(SearchNameInput.Text))
			{
				list = list.Where(o => o.Name.ToLower().Contains(SearchNameInput.Text.ToLower())).ToList();
			}
			Table.DataSource = new BindingList<ProductViewModel>(list);
		}
		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e)
		{
			var unit = Units.SelectedItem as Unit;
			if (unit == null)
			{
				MessageBox.Show("Некорректная единица измерения!");
				return;
			}
			var provider = Providers.SelectedItem as Provider;
			if (provider == null)
			{
				MessageBox.Show("Некорректный производитель!");
				return;
			}
			var manufacturer = Manufacturers.SelectedItem as Manufacturer;
			if (manufacturer == null)
			{
				MessageBox.Show("Некорректный получатель!");
				return;
			}
			var Group = Groups.SelectedItem as Group;
			if (Group == null)
			{
				MessageBox.Show("Некорректная категория!");
				return;
			}
			if (!isFieldsValid())
			{
				return;
			}
			var amount = int.Parse(Amount.Text);
			var buyingPrice = float.Parse(BuyingPrice.Text);
			var sellingPrice = float.Parse(SellingPrice.Text);
			if (isEditing)
			{
				Guid currentId = commonMethods.GetIdFromTable<ProductViewModel>(Table);
				var currentEntity = commonMethods.GetEntityById<Product>(currentId, context);
				currentEntity.Name = EntityName.Text;
				currentEntity.Amount = int.Parse(Amount.Text);
				currentEntity.SellingPrice = float.Parse(SellingPrice.Text);
				currentEntity.BuyingPrice = float.Parse(BuyingPrice.Text);
				currentEntity.UnitId = unit.Id;
				currentEntity.ProviderId = provider.Id;
				currentEntity.ManufacturerId = manufacturer.Id;
				currentEntity.GroupId = Group.Id;
				context.Entry<Product>(currentEntity).State = EntityState.Modified;
				commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			}
			else
			{
				Product newEntity = new Product() { Id = Guid.NewGuid(), Name = EntityName.Text, UnitId = unit.Id, ProviderId = provider.Id, GroupId = Group.Id,ManufacturerId = manufacturer.Id,
				Amount = amount, BuyingPrice = buyingPrice, SellingPrice = sellingPrice};
				commonMethods.AddNewEntity<Product>(context, newEntity, AddEntityPanel);
			}
			commonMethods.ClearControl(AddEntityPanel);
			LoadTable();
		}

		public bool isFieldsValid()
		{
			try
			{
				bool res = true;
				int result;
				float fl;
				var amount = int.TryParse(Amount.Text,out result);
				if (!amount)
				{
					res = false;
					throw new Exception("Неверно введено количество!");
				}
				var buyingPrice = float.TryParse(BuyingPrice.Text,out fl);
				if (!buyingPrice)
				{
					res = false;
					throw new Exception("Неверно введена стоимость!");
				}
				var sellingPrice = float.TryParse(SellingPrice.Text,out fl);
				if (!sellingPrice)
				{
					res = false;
					throw new Exception("Неверно введен вес!");
				}
				return res;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
				return false;
			}
		}
		private void Form_Load(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Unit>(string.Empty, Units);
			commonMethods.FillCombobox<Group>(string.Empty, Groups);
			commonMethods.FillCombobox<Manufacturer>(string.Empty, Manufacturers);
			commonMethods.FillCombobox<Provider>(string.Empty, Providers);
			LoadTable();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			var currentEntity = e.Row.DataBoundItem as ProductViewModel;
			commonMethods.SetEntityAsRemovedById<Product>(currentEntity.Id, context);
		}

		private void Groups_TextUpdate(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Group>(Groups.Text, Groups);

		}



		private void editEntity_Click(object sender, EventArgs e)
		{
			if (Table.SelectedRows.Count == 0)
			{
				MessageBox.Show("Ничего не выбрано!");
				return;
			}
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			if (isEditing)
			{
				Guid currentId = commonMethods.GetIdFromTable<ProductViewModel>(Table);
				var currentEntity = context.Products.Where(o => o.Id == currentId).Include(o => o.Provider).Include(o => o.Unit).Include(o => o.Manufacturer).Include(o => o.Group).FirstOrDefault();
				EntityName.Text = currentEntity.Name;
				Amount.Text = currentEntity.Amount.ToString();
				BuyingPrice.Text = currentEntity.BuyingPrice.ToString();
				SellingPrice.Text = currentEntity.SellingPrice.ToString();
				modelsMethods.SetUnitComboBox(Table, context, Units, currentEntity, UnitName);
				modelsMethods.SetGroupComboBox(Table, context, Groups, currentEntity, GroupName);
				modelsMethods.SetProviderComboBox(Table, context, Providers, currentEntity, ProviderName);
				modelsMethods.SetManufacturerComboBox(Table, context, Manufacturers, currentEntity, ManufacturerName);
			}
		}

		private void Table_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			if (e.StateChanged == DataGridViewElementStates.Displayed) return;
			if (!isEditing) return;
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
		}


		private void GroupName_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Group>(GroupName.Text, Groups);
		}

		private void ProviderName_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Provider>(ProviderName.Text, Providers);
		}

		private void UnitName_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Unit>(UnitName.Text, Units);
		}

		private void ManufacturerName_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Manufacturer>(ManufacturerName.Text, Manufacturers);
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
