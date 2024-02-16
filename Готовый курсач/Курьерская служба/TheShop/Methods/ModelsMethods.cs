using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheShop.Context;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Methods
{
	public class ModelsMethods
	{
		CommonMethods commonMethods = new CommonMethods();
		public Func<Department,DepartmentsViewModel> ConvertDepartmentModel(ProjectContext context)
		{
			return result => new DepartmentsViewModel
			{
				Id= result.Id,
				Name = result.Name,
				GroupName = commonMethods.GetEntityById<Group>(result.GroupId,context).Name
			};
		}
		public Func<Employee, EmployeeViewModel> ConvertEmployeeModel(ProjectContext context)
		{
			return result => new EmployeeViewModel
			{
				Id = result.Id,
				Name = result.Name,
				DepartmentName = commonMethods.GetEntityById<Department>(result.DepartmentId, context).Name,
				PostName = commonMethods.GetEntityById<Post>(result.PostId, context).Name,
				PostId = result.PostId,
				DepartmentId = result.DepartmentId
			};
		}
		public Func<Product, ProductViewModel> ConvertProductModel(ProjectContext context)
		{
			return result => new ProductViewModel
			{
				Id = result.Id,
				Name = result.Name,
				Amount = result.Amount.ToString(),
				BuyingPrice = result.BuyingPrice.ToString(),
				GroupName = commonMethods.GetEntityById<Group>(result.GroupId, context).Name,
				ManufacturerName = commonMethods.GetEntityById<Manufacturer>(result.ManufacturerId, context).Name,
				ProviderName = commonMethods.GetEntityById<Provider>(result.ProviderId, context).Name,
				SellingPrice = result.SellingPrice.ToString(),
				UnitName = commonMethods.GetEntityById<Unit>(result.UnitId, context).Name
			};
		}
		public Func<Product, ProductViewModel> ConvertProductModel()
		{
			return result => new ProductViewModel
			{
				Id = result.Id,
				Name = result.Name,
				/*DepartmentName = commonMethods.GetEntityById<Department>(result.DepartmentId, context).Name,
				PostName = commonMethods.GetEntityById<Post>(result.PostId, context).Name,
				PostId = result.PostId,
				DepartmentId = result.DepartmentId*/
				Amount = result.Amount.ToString(),
				BuyingPrice = result.BuyingPrice.ToString(),
				GroupName = result.Group.Name,
				ManufacturerName = result.Manufacturer.Name,
				ProviderName = result.Provider.Name,
				SellingPrice = result.SellingPrice.ToString(),
				UnitName = result.Unit.Name
			};
		}
		#region Подразделения
		public bool SetDepartmentComboBox(DataGridView Table,ProjectContext context, ComboBox Departments,Employee currentEntity, TextBox SearchDepartmentName)
		{
			bool wasSelected = false;
			foreach (var item in Departments.Items)
			{
				var converted = item as Department;
				if (converted.Id == currentEntity.DepartmentId)
				{
					Departments.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = commonMethods.GetEntityById<Department>(currentEntity.DepartmentId, context);
				commonMethods.FillCombobox<Department>(SearchDepartmentName.Text, Departments, entity);
				Departments.SelectedItem = entity as object;
			}
			return true;
		}
		#endregion
		#region Должности
		public bool SetPostsComboBox(DataGridView Table, ProjectContext context, ComboBox Posts, Employee currentEntity, TextBox SearchPostName)
		{
			bool wasSelected = false;
			foreach (var item in Posts.Items)
			{
				var converted = item as Post;
				if (converted.Id == currentEntity.PostId)
				{
					Posts.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = commonMethods.GetEntityById<Post>(currentEntity.DepartmentId, context);
				commonMethods.FillCombobox<Post>(SearchPostName.Text, Posts, entity);
				Posts.SelectedItem = entity as object;
			}
			return true;
		}
		#endregion

		#region Подразделения
		public bool SetUnitComboBox(DataGridView Table, ProjectContext context, ComboBox Units, Product currentEntity, TextBox searchTextBox)
		{
			bool wasSelected = false;
			foreach (var item in Units.Items)
			{
				var converted = item as Unit;
				if (converted.Id == currentEntity.UnitId)
				{
					Units.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = commonMethods.GetEntityById<Unit>(currentEntity.UnitId, context);
				commonMethods.FillCombobox<Unit>(searchTextBox.Text, Units, entity);
				Units.SelectedItem = entity as object;
			}
			return true;
		}
		#endregion
		#region Подразделения
		public bool SetProviderComboBox(DataGridView Table, ProjectContext context, ComboBox Providers, Product currentEntity, TextBox searchTextBox)
		{
			bool wasSelected = false;
			foreach (var item in Providers.Items)
			{
				var converted = item as Provider;
				if (converted.Id == currentEntity.ProviderId)
				{
					Providers.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = commonMethods.GetEntityById<Provider>(currentEntity.ProviderId, context);
				commonMethods.FillCombobox<Provider>(searchTextBox.Text, Providers, entity);
				Providers.SelectedItem = entity as object;
			}
			return true;
		}
		#endregion
		#region Подразделения
		public bool SetManufacturerComboBox(DataGridView Table, ProjectContext context, ComboBox Manufacturers, Product currentEntity, TextBox searchTextBox)
		{
			bool wasSelected = false;
			foreach (var item in Manufacturers.Items)
			{
				var converted = item as Manufacturer;
				if (converted.Id == currentEntity.ManufacturerId)
				{
					Manufacturers.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = commonMethods.GetEntityById<Manufacturer>(currentEntity.ManufacturerId, context);
				commonMethods.FillCombobox<Manufacturer>(searchTextBox.Text, Manufacturers, entity);
				Manufacturers.SelectedItem = entity as object;
			}
			return true;
		}
		#endregion
		#region Подразделения

		public bool SetGroupComboBox(DataGridView Table, ProjectContext context, ComboBox Groups, Product currentEntity, TextBox searchTextBox)
		{
			bool wasSelected = false;
			foreach (var item in Groups.Items)
			{
				var converted = item as Group;
				if (converted.Id == currentEntity.GroupId)
				{
					Groups.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = commonMethods.GetEntityById<Group>(currentEntity.GroupId, context);
				commonMethods.FillCombobox<Group>(searchTextBox.Text, Groups, entity);
				Groups.SelectedItem = entity as object;
			}
			return true;
		}
		#endregion


	}
}
