namespace TheShop.Forms
{
	partial class UnitsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.AddEntityPanel.Location = new System.Drawing.Point(259, 173);
            this.AddEntityPanel.Name = "AddEntityPanel";
            this.AddEntityPanel.Size = new System.Drawing.Size(394, 257);
            this.AddEntityPanel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Вид оплаты";
            // 
            // AddNewEntity
            // 
            this.AddNewEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEntity.BackColor = System.Drawing.Color.YellowGreen;
            this.AddNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewEntity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewEntity.Location = new System.Drawing.Point(273, 80);
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
            this.EntityName.Location = new System.Drawing.Point(4, 85);
            this.EntityName.Margin = new System.Windows.Forms.Padding(4);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(246, 26);
            this.EntityName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавление вида оплаты";
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
            this.panel2.Size = new System.Drawing.Size(246, 507);
            this.panel2.TabIndex = 8;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Table.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle3;
            this.Table.EnableHeadersVisualStyles = false;
            this.Table.Location = new System.Drawing.Point(7, 7);
            this.Table.Margin = new System.Windows.Forms.Padding(7);
            this.Table.Name = "Table";
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Table.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(227, 481);
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
            this.panel1.Location = new System.Drawing.Point(263, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 120);
            this.panel1.TabIndex = 7;
            // 
            // SearchNameInput
            // 
            this.SearchNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchNameInput.Location = new System.Drawing.Point(4, 30);
            this.SearchNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.SearchNameInput.Name = "SearchNameInput";
            this.SearchNameInput.Size = new System.Drawing.Size(378, 26);
            this.SearchNameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вид оплаты";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChanges.BackColor = System.Drawing.Color.MistyRose;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveChanges.Location = new System.Drawing.Point(4, 75);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(7);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(174, 31);
            this.SaveChanges.TabIndex = 1;
            this.SaveChanges.Text = "Сохранить изменения";
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
            this.RefreshDataTable.Location = new System.Drawing.Point(219, 75);
            this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(7);
            this.RefreshDataTable.Name = "RefreshDataTable";
            this.RefreshDataTable.Size = new System.Drawing.Size(163, 31);
            this.RefreshDataTable.TabIndex = 0;
            this.RefreshDataTable.Text = "Обновить таблицу";
            this.RefreshDataTable.UseVisualStyleBackColor = false;
            this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(665, 533);
            this.Controls.Add(this.AddEntityPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnitsForm";
            this.ShowIcon = false;
            this.Text = "Вид оплаты";
            this.Load += new System.EventHandler(this.UnitsForm_Load);
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
		private System.Windows.Forms.Label label6;
	}
}