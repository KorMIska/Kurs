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
using TheShop.Forms;
using TheShop.Methods;
using TheShop.Models;

namespace TheShop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		CommonMethods commonMethods = new CommonMethods();
		ProjectContext context = new ProjectContext();

		private void button1_Click(object sender, EventArgs e)
		{
			context.Providers.Add(new Provider() { Id = Guid.NewGuid(), Addres = "23", Name = "Test" });
			context.SaveChanges();
			/*var ids = context.Providers.Take(3).Select(o => o.Id).ToList();
			commonMethods.RemoveEntity<Provider>(ids);*/
		}

		private void tabControl1_Click(object sender, EventArgs e)
		{
			var t = 4;
		}


		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void Providers_Click(object sender, EventArgs e)
		{
			UnitsForm UnitsForm = new UnitsForm();
			UnitsForm.Show();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			ProvidersForm providersForm = new ProvidersForm();
			providersForm.Show();
		}

		private void Manufacturers_Click(object sender, EventArgs e)
		{
			ManufacturersForm form = new ManufacturersForm();
			form.Show();
		}

		private void Posts_Click(object sender, EventArgs e)
		{
			PostsForm form = new PostsForm();
			form.Show();
		}

		private void Groups_Click(object sender, EventArgs e)
		{
			GroupsForm form = new GroupsForm();
			form.Show();
		}

		private void Departments_Click(object sender, EventArgs e)
		{
			DepartmentsForm form = new DepartmentsForm();
			form.Show();
		}

		private void Employees_Click(object sender, EventArgs e)
		{
			EmployeesForm form = new EmployeesForm();
			form.Show();
		}

		private void Products_Click(object sender, EventArgs e)
		{
			ProductsForm form = new ProductsForm();
			form.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			var t= context.Units.FirstOrDefault();
		}
	}
}
