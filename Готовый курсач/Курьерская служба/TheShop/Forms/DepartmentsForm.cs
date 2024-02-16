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
	public partial class DepartmentsForm : Form
	{
		public DepartmentsForm()
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
			var deletedIds = context.ChangeTracker.Entries<Department>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
			var updatedIds = context.ChangeTracker.Entries<Department>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity.Id).ToList();
			List<DepartmentsViewModel> list = new List<DepartmentsViewModel>();
			if(updatedIds.Count > 0)
			{
				var updatedEntities = context.ChangeTracker.Entries<Department>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o=> o.Entity).Select(modelsMethods.ConvertDepartmentModel(context)).ToList();
				list = context.Departments.Where(o => !deletedIds.Contains(o.Id) && !updatedIds.Contains(o.Id)).Include(o => o.Group).Select(o => new DepartmentsViewModel { Id = o.Id, Name = o.Name, GroupName = o.Group.Name }).ToList();
				list.AddRange(updatedEntities);
			}
			else
			{
				list = context.Departments.Where(o => !deletedIds.Contains(o.Id)).Include(o => o.Group).Select(o => new DepartmentsViewModel { Id = o.Id, Name = o.Name, GroupName = o.Group.Name }).ToList();
			}
			if (!string.IsNullOrEmpty(SearchNameInput.Text) || !string.IsNullOrWhiteSpace(SearchNameInput.Text))
			{
				list = list.Where(o => o.Name.ToLower().Contains(SearchNameInput.Text.ToLower())).ToList();
			}
			Table.DataSource = new BindingList<DepartmentsViewModel>(list);
		}
		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e)
		{
			Group selectedGroup = Groups.SelectedItem as Group;
			if(selectedGroup == null)
			{
				MessageBox.Show("Некорректная категория");
				return;
			}
			if (isEditing)
			{
				Guid currentId = commonMethods.GetIdFromTable<DepartmentsViewModel>(Table);
				var currentEntity = commonMethods.GetEntityById<Department>(currentId, context);
				currentEntity.Name = EntityName.Text;
				currentEntity.GroupId = selectedGroup.Id;
				context.Entry<Department>(currentEntity).State = EntityState.Modified;
				commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			}
			else
			{
				Department newEntity = new Department() { Id = Guid.NewGuid(), Name = EntityName.Text, GroupId = selectedGroup.Id };
				commonMethods.AddNewEntity<Department>(context, newEntity, AddEntityPanel);
			}
			LoadTable();
		}

		private void Form_Load(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Group>(string.Empty, Groups);
			LoadTable();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			var currentEntity = e.Row.DataBoundItem as DepartmentsViewModel;
			commonMethods.SetEntityAsRemovedById<Department>(currentEntity.Id, context);
		}

		private void Groups_TextUpdate(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Group>(Groups.Text, Groups);

		}

		private void GroupName_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Group>(GroupName.Text, Groups);
		}


		private void editEntity_Click(object sender, EventArgs e)
		{
			bool wasSelected = false;
			if (Table.SelectedRows.Count == 0)
			{
				MessageBox.Show("Ничего не выбрано!");
				return;
			}
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			if (isEditing)
			{
				Guid currentId = commonMethods.GetIdFromTable<DepartmentsViewModel>(Table);
				var currentEntity = context.Departments.Where(o => o.Id == currentId).Include(o => o.Group).FirstOrDefault();
				EntityName.Text = currentEntity.Name;
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
					var group = context.Groups.Where(o => o.Id == currentEntity.GroupId).FirstOrDefault();
					commonMethods.FillCombobox<Group>(GroupName.Text, Groups, group);
					Groups.SelectedItem = group as object;
				}
			}
		}

		private void Table_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			if (e.StateChanged == DataGridViewElementStates.Displayed) return;
			if (!isEditing) return;
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
