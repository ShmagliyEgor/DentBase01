
namespace DentBase
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.DownCheck = new System.Windows.Forms.CheckBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.idProblemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProblemsDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.agePacientDataGridViewTextBoxColumn,
            this.Description,
            this.timeRegisterDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.ClientBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClient.GridColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewClient.Location = new System.Drawing.Point(18, 109);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 62;
            this.dataGridViewClient.Size = new System.Drawing.Size(1176, 471);
            this.dataGridViewClient.TabIndex = 18;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.LightCoral;
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProduct.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.deleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteProduct.Location = new System.Drawing.Point(238, 618);
            this.deleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(308, 49);
            this.deleteProduct.TabIndex = 15;
            this.deleteProduct.Text = "Удалить запись";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.EditProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProductBtn.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EditProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditProductBtn.Location = new System.Drawing.Point(592, 618);
            this.EditProductBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(260, 49);
            this.EditProductBtn.TabIndex = 16;
            this.EditProductBtn.Text = "Редактировать клиента";
            this.EditProductBtn.UseVisualStyleBackColor = false;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProblemBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductBtn.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProductBtn.Location = new System.Drawing.Point(18, 618);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(174, 49);
            this.AddProductBtn.TabIndex = 17;
            this.AddProductBtn.Text = "Добавить клиента";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProblemBtn_Click);
            // 
            // DownCheck
            // 
            this.DownCheck.AutoSize = true;
            this.DownCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.DownCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownCheck.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DownCheck.Location = new System.Drawing.Point(242, 45);
            this.DownCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownCheck.Name = "DownCheck";
            this.DownCheck.Size = new System.Drawing.Size(171, 39);
            this.DownCheck.TabIndex = 13;
            this.DownCheck.Text = "убывание";
            this.DownCheck.UseVisualStyleBackColor = true;
            this.DownCheck.CheckedChanged += new System.EventHandler(this.DownCheck_CheckedChanged);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SearchTxt.Location = new System.Drawing.Point(906, 45);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(288, 42);
            this.SearchTxt.TabIndex = 12;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(1093, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск";
            // 
            // SortBox
            // 
            this.SortBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Items.AddRange(new object[] {
            "Нет",
            "Цена",
            "Возраст",
            "Дата рагистрации"});
            this.SortBox.Location = new System.Drawing.Point(18, 42);
            this.SortBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(212, 43);
            this.SortBox.TabIndex = 19;
            this.SortBox.Text = "Сортировка";
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(1062, 618);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 49);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // idProblemsDataGridViewTextBoxColumn
            // 
            this.idProblemsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idProblemsDataGridViewTextBoxColumn.DataPropertyName = "idProblems";
            this.idProblemsDataGridViewTextBoxColumn.HeaderText = "№ Талона";
            this.idProblemsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idProblemsDataGridViewTextBoxColumn.Name = "idProblemsDataGridViewTextBoxColumn";
            this.idProblemsDataGridViewTextBoxColumn.Width = 161;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // agePacientDataGridViewTextBoxColumn
            // 
            this.agePacientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.agePacientDataGridViewTextBoxColumn.DataPropertyName = "AgePacient";
            this.agePacientDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.agePacientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.agePacientDataGridViewTextBoxColumn.Name = "agePacientDataGridViewTextBoxColumn";
            this.agePacientDataGridViewTextBoxColumn.Width = 148;
            // 
            // timeRegisterDataGridViewTextBoxColumn
            // 
            this.timeRegisterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeRegisterDataGridViewTextBoxColumn.DataPropertyName = "TimeRegister";
            this.timeRegisterDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.timeRegisterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeRegisterDataGridViewTextBoxColumn.Name = "timeRegisterDataGridViewTextBoxColumn";
            this.timeRegisterDataGridViewTextBoxColumn.Width = 253;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 113;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataSource = typeof(DentBase.GridRowModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1207, 675);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.DownCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Записи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTalonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.CheckBox DownCheck;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProblemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}