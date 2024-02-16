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
	public partial class ProvidersForm : Form
	{
		ProjectContext context = new ProjectContext();
		CommonMethods commonMethods = new CommonMethods();
		public ProvidersForm()
		{
			InitializeComponent();
		}



		private void SearchProviders_Click_1(object sender, EventArgs e)
		{
			commonMethods.BindDataTable<Provider>(context, ProviderName.Text, ProvidersTable);
		}

		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void ProvidersForm_Load(object sender, EventArgs e)
		{
			commonMethods.BindDataTable<Provider>(context, ProviderName.Text, ProvidersTable);
		}

		private void AddNewEntity_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(Adress.Text) || string.IsNullOrEmpty(BankDetails.Text))
			{
				MessageBox.Show("Необходимо заполнить все поля");
				return;
			}
			Provider newProvider = new Provider() { Id = Guid.NewGuid(), Addres = Adress.Text, Name = EntityName.Text, BankDetails = BankDetails.Text };
			commonMethods.AddNewEntity<Provider>(context, newProvider,AddEntityPanel);
			commonMethods.BindDataTable<Provider>(context, ProviderName.Text, ProvidersTable);
		}

		private void ProvidersTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			commonMethods.SetEntityAsRemoved<Provider>(e.Row.DataBoundItem, context);
		}
	}
}
