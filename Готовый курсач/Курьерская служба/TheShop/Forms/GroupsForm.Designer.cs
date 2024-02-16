namespace TheShop.Forms
{
	partial class GroupsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddEntityPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.AddNewEntity = new System.Windows.Forms.Button();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Table = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.RefreshDataTable = new System.Windows.Forms.Button();
            this.AddEntityPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEntityPanel
            // 
            this.AddEntityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEntityPanel.Controls.Add(this.label6);
            this.AddEntityPanel.Controls.Add(this.AddNewEntity);
            this.AddEntityPanel.Controls.Add(this.EntityName);
            this.AddEntityPanel.Controls.Add(this.label2);
            this.AddEntityPanel.Location = new System.Drawing.Point(255, 173);
            this.AddEntityPanel.Name = "AddEntityPanel";
            this.AddEntityPanel.Size = new System.Drawing.Size(271, 188);
            this.AddEntityPanel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Название категории";
            // 
            // AddNewEntity
            // 
            this.AddNewEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEntity.BackColor = System.Drawing.Color.YellowGreen;
            this.AddNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewEntity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewEntity.Location = new System.Drawing.Point(85, 122);
            this.AddNewEntity.Margin = new System.Windows.Forms.Padding(7);
            this.AddNewEntity.Name = "AddNewEntity";
            this.AddNewEntity.Size = new System.Drawing.Size(113, 31);
            this.AddNewEntity.TabIndex = 13;
            this.AddNewEntity.Text = "Добавить";
            this.AddNewEntity.UseVisualStyleBackColor = false;
            this.AddNewEntity.Click += new System.EventHandler(this.AddNewEntity_Click);
            // 
            // EntityName
            // 
            this.EntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntityName.Location = new System.Drawing.Point(17, 85);
            this.EntityName.Margin = new System.Windows.Forms.Padding(4);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(246, 26);
            this.EntityName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавление категорий";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Table);
            this.panel2.Location = new System.Drawing.Point(7, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 346);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Table.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle11;
            this.Table.EnableHeadersVisualStyles = false;
            this.Table.Location = new System.Drawing.Point(7, 7);
            this.Table.Margin = new System.Windows.Forms.Padding(7);
            this.Table.Name = "Table";
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Table.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(230, 332);
            this.Table.TabIndex = 1;
            this.Table.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Table_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.SearchNameInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SaveChanges);
            this.panel1.Controls.Add(this.RefreshDataTable);
            this.panel1.Location = new System.Drawing.Point(259, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 153);
            this.panel1.TabIndex = 13;
            // 
            // SearchNameInput
            // 
            this.SearchNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchNameInput.Location = new System.Drawing.Point(8, 39);
            this.SearchNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.SearchNameInput.Name = "SearchNameInput";
            this.SearchNameInput.Size = new System.Drawing.Size(250, 26);
            this.SearchNameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название категории";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChanges.BackColor = System.Drawing.Color.MistyRose;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveChanges.Location = new System.Drawing.Point(8, 79);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(7);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(246, 31);
            this.SaveChanges.TabIndex = 1;
            this.SaveChanges.Text = "Сохранить ";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // RefreshDataTable
            // 
            this.RefreshDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshDataTable.BackColor = System.Drawing.Color.MistyRose;
            this.RefreshDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDataTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshDataTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RefreshDataTable.Location = new System.Drawing.Point(8, 115);
            this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(7);
            this.RefreshDataTable.Name = "RefreshDataTable";
            this.RefreshDataTable.Size = new System.Drawing.Size(246, 31);
            this.RefreshDataTable.TabIndex = 0;
            this.RefreshDataTable.Text = "Обновить ";
            this.RefreshDataTable.UseVisualStyleBackColor = false;
            this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(539, 372);
            this.Controls.Add(this.AddEntityPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GroupsForm";
            this.ShowIcon = false;
            this.Text = "Категории посылок";
            this.Load += new System.EventHandler(this.Form_Load);
            this.AddEntityPanel.ResumeLayout(false);
            this.AddEntityPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel AddEntityPanel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button AddNewEntity;
		private System.Windows.Forms.TextBox EntityName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox SearchNameInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SaveChanges;
		private System.Windows.Forms.Button RefreshDataTable;
	}
}