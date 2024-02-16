namespace TheShop.Forms
{
	partial class ProvidersForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProvidersTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProviderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.RefreshDataTable = new System.Windows.Forms.Button();
            this.AddEntityPanel = new System.Windows.Forms.Panel();
            this.BankDetails = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddNewEntity = new System.Windows.Forms.Button();
            this.Adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.AddEntityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ProvidersTable);
            this.panel2.Location = new System.Drawing.Point(4, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 515);
            this.panel2.TabIndex = 5;
            // 
            // ProvidersTable
            // 
            this.ProvidersTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.ProvidersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProvidersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProvidersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ProvidersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ProvidersTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ProvidersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProvidersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProvidersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProvidersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProvidersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProvidersTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProvidersTable.EnableHeadersVisualStyles = false;
            this.ProvidersTable.Location = new System.Drawing.Point(7, 3);
            this.ProvidersTable.Margin = new System.Windows.Forms.Padding(7);
            this.ProvidersTable.Name = "ProvidersTable";
            this.ProvidersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProvidersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProvidersTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ProvidersTable.RowTemplate.Height = 25;
            this.ProvidersTable.Size = new System.Drawing.Size(480, 493);
            this.ProvidersTable.TabIndex = 1;
            this.ProvidersTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ProvidersTable_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.ProviderName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SaveChanges);
            this.panel1.Controls.Add(this.RefreshDataTable);
            this.panel1.Location = new System.Drawing.Point(498, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 124);
            this.panel1.TabIndex = 4;
            // 
            // ProviderName
            // 
            this.ProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProviderName.Location = new System.Drawing.Point(4, 39);
            this.ProviderName.Margin = new System.Windows.Forms.Padding(4);
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.Size = new System.Drawing.Size(386, 25);
            this.ProviderName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование отправителя";
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
            this.RefreshDataTable.Location = new System.Drawing.Point(229, 74);
            this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(7);
            this.RefreshDataTable.Name = "RefreshDataTable";
            this.RefreshDataTable.Size = new System.Drawing.Size(161, 32);
            this.RefreshDataTable.TabIndex = 0;
            this.RefreshDataTable.Text = "Обновить таблицу";
            this.RefreshDataTable.UseVisualStyleBackColor = false;
            this.RefreshDataTable.Click += new System.EventHandler(this.SearchProviders_Click_1);
            // 
            // AddEntityPanel
            // 
            this.AddEntityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEntityPanel.Controls.Add(this.BankDetails);
            this.AddEntityPanel.Controls.Add(this.label5);
            this.AddEntityPanel.Controls.Add(this.AddNewEntity);
            this.AddEntityPanel.Controls.Add(this.Adress);
            this.AddEntityPanel.Controls.Add(this.label4);
            this.AddEntityPanel.Controls.Add(this.EntityName);
            this.AddEntityPanel.Controls.Add(this.label3);
            this.AddEntityPanel.Controls.Add(this.label2);
            this.AddEntityPanel.Location = new System.Drawing.Point(502, 144);
            this.AddEntityPanel.Name = "AddEntityPanel";
            this.AddEntityPanel.Size = new System.Drawing.Size(394, 257);
            this.AddEntityPanel.TabIndex = 6;
            // 
            // BankDetails
            // 
            this.BankDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BankDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BankDetails.Location = new System.Drawing.Point(4, 183);
            this.BankDetails.Margin = new System.Windows.Forms.Padding(4);
            this.BankDetails.Name = "BankDetails";
            this.BankDetails.Size = new System.Drawing.Size(246, 25);
            this.BankDetails.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Номер посылки";
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
            // Adress
            // 
            this.Adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adress.Location = new System.Drawing.Point(3, 134);
            this.Adress.Margin = new System.Windows.Forms.Padding(4);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(247, 25);
            this.Adress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Адрес ";
            // 
            // EntityName
            // 
            this.EntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntityName.Location = new System.Drawing.Point(4, 85);
            this.EntityName.Margin = new System.Windows.Forms.Padding(4);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(246, 25);
            this.EntityName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Наименование отправителя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавление отправителя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.AddEntityPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProvidersForm";
            this.ShowIcon = false;
            this.Text = "Отправители";
            this.Load += new System.EventHandler(this.ProvidersForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddEntityPanel.ResumeLayout(false);
            this.AddEntityPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox ProviderName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SaveChanges;
		private System.Windows.Forms.Button RefreshDataTable;
		private System.Windows.Forms.Panel AddEntityPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView ProvidersTable;
		private System.Windows.Forms.Button AddNewEntity;
		private System.Windows.Forms.TextBox Adress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox EntityName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox BankDetails;
		private System.Windows.Forms.Label label5;
	}
}