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
	public partial class PostsForm : Form
	{
		public PostsForm()
		{
			InitializeComponent();
		}

		ProjectContext context = new ProjectContext();
		CommonMethods commonMethods = new CommonMethods();

		private void RefreshDataTable_Click(object sender, EventArgs e)
		{
			commonMethods.BindDataTable<Post>(context, SearchNameInput.Text, Table);
		}

		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e)
		{
			Post newEntity = new Post() { Id = Guid.NewGuid(), Name = EntityName.Text, };
			commonMethods.AddNewEntity<Post>(context, newEntity, AddEntityPanel);
			commonMethods.BindDataTable<Post>(context, SearchNameInput.Text, Table);
		}

		private void Form_Load(object sender, EventArgs e)
		{
			commonMethods.BindDataTable<Post>(context, SearchNameInput.Text, Table);
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			commonMethods.SetEntityAsRemoved<Post>(e.Row.DataBoundItem, context);
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
