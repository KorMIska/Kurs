namespace TheShop.Forms
{
	partial class ProductsForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.ManufacturerName = new System.Windows.Forms.TextBox();
            this.Manufacturers = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UnitName = new System.Windows.Forms.TextBox();
            this.Units = new System.Windows.Forms.ComboBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SellingPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BuyingPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProviderName = new System.Windows.Forms.TextBox();
            this.Providers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.Groups = new System.Windows.Forms.ComboBox();
            this.AddNewEntity = new System.Windows.Forms.Button();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editEntity = new System.Windows.Forms.Button();
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
            this.AddEntityPanel.Controls.Add(this.label11);
            this.AddEntityPanel.Controls.Add(this.ManufacturerName);
            this.AddEntityPanel.Controls.Add(this.Manufacturers);
            this.AddEntityPanel.Controls.Add(this.label13);
            this.AddEntityPanel.Controls.Add(this.UnitName);
            this.AddEntityPanel.Controls.Add(this.Units);
            this.AddEntityPanel.Controls.Add(this.Amount);
            this.AddEntityPanel.Controls.Add(this.label10);
            this.AddEntityPanel.Controls.Add(this.SellingPrice);
            this.AddEntityPanel.Controls.Add(this.label9);
            this.AddEntityPanel.Controls.Add(this.BuyingPrice);
            this.AddEntityPanel.Controls.Add(this.label8);
            this.AddEntityPanel.Controls.Add(this.label6);
            this.AddEntityPanel.Controls.Add(this.ProviderName);
            this.AddEntityPanel.Controls.Add(this.Providers);
            this.AddEntityPanel.Controls.Add(this.label5);
            this.AddEntityPanel.Controls.Add(this.GroupName);
            this.AddEntityPanel.Controls.Add(this.Groups);
            this.AddEntityPanel.Controls.Add(this.AddNewEntity);
            this.AddEntityPanel.Controls.Add(this.EntityName);
            this.AddEntityPanel.Controls.Add(this.label3);
            this.AddEntityPanel.Controls.Add(this.label2);
            this.AddEntityPanel.Location = new System.Drawing.Point(378, 3);
            this.AddEntityPanel.Name = "AddEntityPanel";
            this.AddEntityPanel.Size = new System.Drawing.Size(1039, 185);
            this.AddEntityPanel.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(737, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Выбор получателя";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerName.Location = new System.Drawing.Point(755, 121);
            this.ManufacturerName.Margin = new System.Windows.Forms.Padding(4);
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.Size = new System.Drawing.Size(127, 26);
            this.ManufacturerName.TabIndex = 32;
            this.ManufacturerName.TextChanged += new System.EventHandler(this.ManufacturerName_TextChanged);
            // 
            // Manufacturers
            // 
            this.Manufacturers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Manufacturers.BackColor = System.Drawing.SystemColors.Window;
            this.Manufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manufacturers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Manufacturers.FormattingEnabled = true;
            this.Manufacturers.Location = new System.Drawing.Point(756, 154);
            this.Manufacturers.Name = "Manufacturers";
            this.Manufacturers.Size = new System.Drawing.Size(127, 27);
            this.Manufacturers.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.AliceBlue;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(694, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "Выбор вида оплаты";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitName
            // 
            this.UnitName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitName.Location = new System.Drawing.Point(757, 28);
            this.UnitName.Margin = new System.Windows.Forms.Padding(4);
            this.UnitName.Name = "UnitName";
            this.UnitName.Size = new System.Drawing.Size(127, 26);
            this.UnitName.TabIndex = 28;
            this.UnitName.TextChanged += new System.EventHandler(this.UnitName_TextChanged);
            // 
            // Units
            // 
            this.Units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Units.BackColor = System.Drawing.SystemColors.Window;
            this.Units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Units.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Units.FormattingEnabled = true;
            this.Units.Location = new System.Drawing.Point(758, 61);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(127, 27);
            this.Units.TabIndex = 30;
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Location = new System.Drawing.Point(135, 149);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(246, 26);
            this.Amount.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Количество";
            // 
            // SellingPrice
            // 
            this.SellingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SellingPrice.Location = new System.Drawing.Point(135, 115);
            this.SellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(246, 26);
            this.SellingPrice.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Вес";
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuyingPrice.Location = new System.Drawing.Point(135, 81);
            this.BuyingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.Size = new System.Drawing.Size(246, 26);
            this.BuyingPrice.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(483, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Выбор отправителя";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProviderName
            // 
            this.ProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProviderName.Location = new System.Drawing.Point(509, 121);
            this.ProviderName.Margin = new System.Windows.Forms.Padding(4);
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.Size = new System.Drawing.Size(127, 26);
            this.ProviderName.TabIndex = 18;
            this.ProviderName.TextChanged += new System.EventHandler(this.ProviderName_TextChanged);
            // 
            // Providers
            // 
            this.Providers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Providers.BackColor = System.Drawing.SystemColors.Window;
            this.Providers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Providers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Providers.FormattingEnabled = true;
            this.Providers.Location = new System.Drawing.Point(509, 154);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(127, 27);
            this.Providers.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(487, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Выбор категории";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupName
            // 
            this.GroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupName.Location = new System.Drawing.Point(509, 28);
            this.GroupName.Margin = new System.Windows.Forms.Padding(4);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(127, 26);
            this.GroupName.TabIndex = 4;
            this.GroupName.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
            // 
            // Groups
            // 
            this.Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Groups.BackColor = System.Drawing.SystemColors.Window;
            this.Groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Groups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Groups.FormattingEnabled = true;
            this.Groups.Location = new System.Drawing.Point(509, 61);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(127, 27);
            this.Groups.TabIndex = 16;
            // 
            // AddNewEntity
            // 
            this.AddNewEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEntity.BackColor = System.Drawing.Color.YellowGreen;
            this.AddNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewEntity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewEntity.Location = new System.Drawing.Point(388, 46);
            this.AddNewEntity.Margin = new System.Windows.Forms.Padding(7);
            this.AddNewEntity.Name = "AddNewEntity";
            this.AddNewEntity.Size = new System.Drawing.Size(90, 129);
            this.AddNewEntity.TabIndex = 13;
            this.AddNewEntity.Text = "Добавить";
            this.AddNewEntity.UseVisualStyleBackColor = false;
            this.AddNewEntity.Click += new System.EventHandler(this.AddNewEntity_Click);
            // 
            // EntityName
            // 
            this.EntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntityName.Location = new System.Drawing.Point(135, 49);
            this.EntityName.Margin = new System.Windows.Forms.Padding(4);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(246, 26);
            this.EntityName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Редактированиепосылок";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // editEntity
            // 
            this.editEntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editEntity.BackColor = System.Drawing.Color.MistyRose;
            this.editEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEntity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editEntity.Location = new System.Drawing.Point(150, 76);
            this.editEntity.Margin = new System.Windows.Forms.Padding(7);
            this.editEntity.Name = "editEntity";
            this.editEntity.Size = new System.Drawing.Size(209, 31);
            this.editEntity.TabIndex = 4;
            this.editEntity.Text = "Редактировать выбранную запись";
            this.editEntity.UseVisualStyleBackColor = false;
            this.editEntity.Click += new System.EventHandler(this.editEntity_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Table);
            this.panel2.Location = new System.Drawing.Point(5, 195);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 333);
            this.panel2.TabIndex = 17;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Table.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Snow;
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
            this.Table.Location = new System.Drawing.Point(7, 3);
            this.Table.Margin = new System.Windows.Forms.Padding(7);
            this.Table.MultiSelect = false;
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
            this.Table.Size = new System.Drawing.Size(1398, 311);
            this.Table.TabIndex = 1;
            this.Table.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.Table_RowStateChanged);
            this.Table.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Table_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.SearchNameInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SaveChanges);
            this.panel1.Controls.Add(this.RefreshDataTable);
            this.panel1.Controls.Add(this.editEntity);
            this.panel1.Location = new System.Drawing.Point(5, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 174);
            this.panel1.TabIndex = 16;
            // 
            // SearchNameInput
            // 
            this.SearchNameInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchNameInput.Location = new System.Drawing.Point(4, 37);
            this.SearchNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.SearchNameInput.Name = "SearchNameInput";
            this.SearchNameInput.Size = new System.Drawing.Size(198, 26);
            this.SearchNameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название посылки";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveChanges.BackColor = System.Drawing.Color.MistyRose;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveChanges.Location = new System.Drawing.Point(220, 32);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(7);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(139, 31);
            this.SaveChanges.TabIndex = 1;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // RefreshDataTable
            // 
            this.RefreshDataTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RefreshDataTable.BackColor = System.Drawing.Color.MistyRose;
            this.RefreshDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDataTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshDataTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RefreshDataTable.Location = new System.Drawing.Point(4, 75);
            this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(7);
            this.RefreshDataTable.Name = "RefreshDataTable";
            this.RefreshDataTable.Size = new System.Drawing.Size(142, 32);
            this.RefreshDataTable.TabIndex = 0;
            this.RefreshDataTable.Text = "Обновить таблицу";
            this.RefreshDataTable.UseVisualStyleBackColor = false;
            this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1429, 544);
            this.Controls.Add(this.AddEntityPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsForm";
            this.ShowIcon = false;
            this.Text = "Посылка";
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
		private System.Windows.Forms.TextBox Amount;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox SellingPrice;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox BuyingPrice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox ProviderName;
		private System.Windows.Forms.ComboBox Providers;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox GroupName;
		private System.Windows.Forms.ComboBox Groups;
		private System.Windows.Forms.Button AddNewEntity;
		private System.Windows.Forms.TextBox EntityName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button editEntity;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox SearchNameInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SaveChanges;
		private System.Windows.Forms.Button RefreshDataTable;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ManufacturerName;
		private System.Windows.Forms.ComboBox Manufacturers;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox UnitName;
		private System.Windows.Forms.ComboBox Units;
	}
}