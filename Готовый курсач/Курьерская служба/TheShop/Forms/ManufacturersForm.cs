using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheShop.Context;
using TheShop.Methods;
using TheShop.Models;

namespace TheShop.Forms
{
	public partial class ManufacturersForm : Form
	{
		public ManufacturersForm()
		{
			InitializeComponent();
		}

		ProjectContext context = new ProjectContext();
		CommonMethods commonMethods = new CommonMethods();
		private void RefreshDataTable_Click(object sender, EventArgs e)
		{
			commonMethods.BindDataTable<Manufacturer>(context, SearchNameInput.Text, Table);
		}

		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(Adress.Text) || string.IsNullOrWhiteSpace(Adress.Text))
			{
				MessageBox.Show("Необходимо заполнить все поля");
				return;
			}
			Manufacturer newEntity = new Manufacturer() { Id = Guid.NewGuid(), Name = EntityName.Text, Addres = Adress.Text };
			commonMethods.AddNewEntity<Manufacturer>(context, newEntity, AddEntityPanel);
			commonMethods.BindDataTable<Manufacturer>(context, SearchNameInput.Text, Table);
		}

		private void Form_Load(object sender, EventArgs e)
		{
			commonMethods.BindDataTable<Manufacturer>(context, SearchNameInput.Text, Table);
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			commonMethods.SetEntityAsRemoved<Manufacturer>(e.Row.DataBoundItem, context);
		}
	}
}
