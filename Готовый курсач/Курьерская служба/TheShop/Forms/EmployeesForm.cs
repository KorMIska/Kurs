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
	public partial class EmployeesForm : Form
	{
		public EmployeesForm()
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
			var deletedIds = context.ChangeTracker.Entries<Employee>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
			var updatedIds = context.ChangeTracker.Entries<Employee>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity.Id).ToList();
			List<EmployeeViewModel> list = new List<EmployeeViewModel>();
			if (updatedIds.Count > 0)
			{
				var updatedEntities = context.ChangeTracker.Entries<Employee>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity).Select(modelsMethods.ConvertEmployeeModel(context)).ToList();
				list = context.Employees.Where(o => !deletedIds.Contains(o.Id) && !updatedIds.Contains(o.Id)).Include(o => o.Department).Include(o=> o.Post)
					.Select(o => new EmployeeViewModel { Id = o.Id, Name = o.Name, PostName = o.Post.Name, DepartmentName = o.Department.Name}).ToList();
				list.AddRange(updatedEntities);
			}
			else
			{
				list = context.Employees.Where(o => !deletedIds.Contains(o.Id)).Include(o => o.Department).Include(o => o.Post)
					.Select(o => new EmployeeViewModel { Id = o.Id, Name = o.Name, PostName = o.Post.Name, DepartmentName = o.Department.Name }).ToList();
			}
			if(!string.IsNullOrEmpty(SearchNameInput.Text) || !string.IsNullOrWhiteSpace(SearchNameInput.Text))
			{
				list = list.Where(o => o.Name.ToLower().Contains(SearchNameInput.Text.ToLower())).ToList();
			}
			Table.DataSource = new BindingList<EmployeeViewModel>(list);
		}
		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e)
		{
			Post post = Posts.SelectedItem as Post;
			if (post == null)
			{
				MessageBox.Show("Некорректная должность!");
				return;
			}
			Department department = Departments.SelectedItem as Department;
			if (department == null)
			{
				MessageBox.Show("Некорректная категория!");
				return;
			}
			if (isEditing)
			{
				Guid currentId = commonMethods.GetIdFromTable<EmployeeViewModel>(Table);
				var currentEntity = commonMethods.GetEntityById<Employee>(currentId, context);
				currentEntity.Name = EntityName.Text;
				currentEntity.PostId = post.Id;
				currentEntity.DepartmentId = department.Id;
				context.Entry<Employee>(currentEntity).State = EntityState.Modified;
				commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			}
			else
			{
				Employee newEntity = new Employee() { Id = Guid.NewGuid(), Name = EntityName.Text, PostId = post.Id, DepartmentId = department.Id };
				commonMethods.AddNewEntity<Employee>(context, newEntity, AddEntityPanel);
			}
			commonMethods.ClearControl(AddEntityPanel);
			LoadTable();
		}

		private void Form_Load(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Department>(string.Empty, Departments);
			commonMethods.FillCombobox<Post>(string.Empty, Posts);
			LoadTable();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			var currentEntity = e.Row.DataBoundItem as EmployeeViewModel;
			commonMethods.SetEntityAsRemovedById<Employee>(currentEntity.Id, context);
		}

		private void Groups_TextUpdate(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Group>(Departments.Text, Departments);

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
				Guid currentId = commonMethods.GetIdFromTable<EmployeeViewModel>(Table);
				var currentEntity = context.Employees.Where(o => o.Id == currentId).Include(o => o.Post).FirstOrDefault();
				EntityName.Text = currentEntity.Name;
				modelsMethods.SetDepartmentComboBox(Table, context, Departments, currentEntity, DepartmentName);
				modelsMethods.SetPostsComboBox(Table, context, Posts, currentEntity, DepartmentName);
			}
		}

		private void Table_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			if (e.StateChanged == DataGridViewElementStates.Displayed) return;
			if (!isEditing) return;
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
		}

		private void DepartmentName_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Department>(DepartmentName.Text, Departments);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			commonMethods.FillCombobox<Post>(PostName.Text, Posts);
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
