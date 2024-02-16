using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheShop.Context;
using TheShop.Interfaces;

namespace TheShop.Methods
{
	public class CommonMethods
	{
		/// <summary>
		/// Удалеие записей по ID
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="ids">список id</param>
		/// <returns></returns>
		public bool RemoveEntity<T>(List<Guid> ids) where T : class,Common
		{
			try
			{
				using(ProjectContext context = new ProjectContext())
				{
					var source = context.Set<T>().Where(o => ids.Contains(o.Id)).ToList();
					context.Set<T>().RemoveRange(source);
					context.SaveChanges();
					return true;
				}
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Достать запись из БД по ИД
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="id"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		public T GetEntityById<T>(Guid id, ProjectContext context) where T : class, Common
		{
			try
			{
				var source = context.Set<T>().Where(o=> o.Id == id).FirstOrDefault();
				return source;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return default(T);
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public List<T> SearchEntities<T>(string search) where T : class, Common
		{
			try
			{
				using (ProjectContext context = new ProjectContext())
				{
					var source = context.Set<T>().ToList();
					if(!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search))
					{
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
					}
					return source;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем и взять определенное количество
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <param name="take">сколько записей взять</param>
		/// <returns></returns>
		public List<T> SearchEntities<T>(string search,int take) where T : class, Common
		{
			try
			{
				using (ProjectContext context = new ProjectContext())
				{
					List<T> result = new List<T>();
					var source = context.Set<T>().Where(o=> true);
					if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search))
					{
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
					}
					result = source.Take(take).ToList();
					return result;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи и вернуть типом IQueryable
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesIQueryable<T>(string search) where T : class, Common
		{
			try
			{
				using (ProjectContext context = new ProjectContext())
				{
					var source = context.Set<T>().Where(o=> true);
					if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search))
					{
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
					}
					return source;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи, но не создавать новый context
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search"></param>
		/// <returns></returns>
		public List<T> SearchEntities<T>(ProjectContext context, string search) where T : class, Common
		{
			try
			{
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o=> !deletedIds.Contains(o.Id)).ToList();
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search))
				{
					source = source.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
				}
				return source;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи, которые не были удалены
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search"></param>
		/// <returns></returns>
		public List<T> SearchEntitiesWithoutContains<T>(ProjectContext context, string search) where T : class, Common
		{
			try
			{
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id)).ToList();
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search))
				{
					source = source.Where(o => o.Name.ToLower() == search.ToLower()).ToList();
				}
				return source;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Записать данные в тиблицу
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search">строка поиска</param>
		/// <param name="table">таблица</param>
		/// <returns></returns>
		public bool BindDataTable<T>(ProjectContext context, string search, DataGridView table) where T : class, Common
		{
			try
			{
				var models = SearchEntities<T>(context,search);
				table.DataSource = new BindingList<T>(models);
				return true;
			}catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Пометить запись как удаленную
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="entity">запись</param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool SetEntityAsRemoved<T>(object entity,ProjectContext context) where T : class, Common
		{
			try
			{
				T item = (T)entity;
				context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				return true;
			}catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Найти запись по id и пометить как удаленную
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="id"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool SetEntityAsRemovedById<T>(Guid id, ProjectContext context) where T : class, Common
		{
			try
			{
				var item = GetEntityById<T>(id,context);
				context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				return true;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillCombobox<T>(string search, ComboBox select) where T : class, Common
		{
			try
			{
				var entities = SearchEntities<T>(search,10);
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				return true;
			}catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <param name="needToAdd">запись, которую необходимо добавить</param>
		/// <returns></returns>
		public bool FillCombobox<T>(string search, ComboBox select,T needToAdd) where T : class, Common
		{
			try
			{
				var entities = SearchEntities<T>(search, 10);
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				entities.Add(needToAdd);
				select.DataSource = entities;
				return true;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись в БД
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <returns></returns>
		public bool AddNewEntity<T>(ProjectContext context,T entity)where T: class, Common
		{
			try
			{
				if(string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name))
				{	
					MessageBox.Show("Необходимо указать наименование!");
				}
				if(SearchEntitiesWithoutContains<T>(context,entity.Name).Count > 0)
				{
					MessageBox.Show("Нельзя создавать записи с одинаковым именем!");
					return false;
				}
				context.Set<T>().Add(entity);
				context.SaveChanges();
				return true;
			}catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись и очистить поля ввода на переданной панеле
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <param name="panel">панель</param>
		/// <returns></returns>
		public bool AddNewEntity<T>(ProjectContext context, T entity,Panel panel) where T : class, Common
		{
			try
			{
				if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name))
				{
					MessageBox.Show("Необходимо указать наименование!");
					return false;
				}
				if (SearchEntitiesWithoutContains<T>(context, entity.Name).Count > 0)
				{
					MessageBox.Show("Нельзя создавать записи с одинаковым именем!");
					return false;
				}
				context.Set<T>().Add(entity);
				context.SaveChanges();
				foreach (Control contr in panel.Controls)
				{
					TextBox tb = contr as TextBox;
					if (tb != null)
					{
						tb.Text = string.Empty;
					}
				}
				return true;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Получить ид записи, которая выбрана в таблице
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="table">таблица</param>
		/// <returns></returns>
		public Guid GetIdFromTable<T>(DataGridView table) where T : class, Common
		{
			try
			{
				var selectedItem = table.SelectedRows[0].DataBoundItem as T;
				return selectedItem.Id;
			}catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
				return Guid.Empty;
			}
		}
		/// <summary>
		/// Очистить поля ввода на панеле
		/// </summary>
		/// <param name="panel">панель</param>
		public void ClearControl(Panel panel)
		{
			foreach (Control contr in panel.Controls)
			{
				TextBox tb = contr as TextBox;
				if (tb != null)
				{
					tb.Text = string.Empty;
				}
			}
		}
		/// <summary>
		/// Поменять текст в кнопке редактирования и добавления
		/// </summary>
		/// <param name="editButton"></param>
		/// <param name="addButton"></param>
		/// <param name="isEditing"></param>
		public void SwitchButtonsStates(Button editButton,Button addButton, bool isEditing)
		{
			if (isEditing)
			{
				editButton.Text = "Отменить редактирование";
				addButton.Text = "Подтвердить";
			}
			else
			{
				editButton.Text = "Редактировать выбранную запись";
				addButton.Text = "Добавить";
			}
		}
		/// <summary>
		/// Поменять текст в кнопке редактирования и добавления и очистить переданную панель
		/// </summary>
		/// <param name="editButton"></param>
		/// <param name="addButton"></param>
		/// <param name="panel"></param>
		/// <param name="isEditing"></param>
		public void SwitchEditButtonStates(Button editButton, Button addButton, Panel panel, ref bool isEditing)
		{
			isEditing = !isEditing;
			SwitchButtonsStates(editButton, addButton, isEditing);
			ClearControl(panel);
		}
		/// <summary>
		/// Заполнить комбобокс записями, но если нет необходимой записи добавить ее (нужно для редактирования, т.к. из в 10 загружаемых записях может не быть связанной с сущностью)
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Table"></param>
		/// <param name="context"></param>
		/// <param name="comboBox"></param>
		/// <param name="searchId"></param>
		/// <param name="searchTextBox"></param>
		/// <returns></returns>
		public bool SetValuesToComboBox<T>(ProjectContext context, ComboBox comboBox, Guid searchId, TextBox searchTextBox) where T : class, Common
		{
			bool wasSelected = false;
			foreach (var item in comboBox.Items)
			{
				var converted = item as T;
				if (converted.Id == searchId)
				{
					comboBox.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected)
			{
				var entity = GetEntityById<T>(searchId, context);
				FillCombobox<T>(searchTextBox.Text, comboBox, entity);
				comboBox.SelectedItem = entity as object;
			}
			return true;
		}
	}
}
