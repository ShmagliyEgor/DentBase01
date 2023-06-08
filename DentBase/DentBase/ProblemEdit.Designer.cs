namespace DentBase
{
    partial class ProblemEdit
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
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemEdit));
            this.dateTimePickerRegister = new System.Windows.Forms.DateTimePicker();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.LabelTalon = new System.Windows.Forms.Label();
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            articleNumberLabel.Location = new System.Drawing.Point(12, 87);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(142, 23);
            articleNumberLabel.TabIndex = 63;
            articleNumberLabel.Text = "Время записи:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            descriptionLabel.Location = new System.Drawing.Point(12, 132);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 23);
            descriptionLabel.TabIndex = 66;
            descriptionLabel.Text = "Пометка:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            minCostForAgentLabel.Location = new System.Drawing.Point(12, 176);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(182, 23);
            minCostForAgentLabel.TabIndex = 68;
            minCostForAgentLabel.Text = "Стоимость услуг:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(12, 9);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(123, 18);
            productionWorkshopNumberLabel.TabIndex = 71;
            productionWorkshopNumberLabel.Text = "Номер талона:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            titleLabel.Location = new System.Drawing.Point(12, 46);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(105, 23);
            titleLabel.TabIndex = 73;
            titleLabel.Text = "Пациент:";
            // 
            // dateTimePickerRegister
            // 
            this.dateTimePickerRegister.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.dateTimePickerRegister.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTimePickerRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerRegister.Location = new System.Drawing.Point(209, 81);
            this.dateTimePickerRegister.Name = "dateTimePickerRegister";
            this.dateTimePickerRegister.Size = new System.Drawing.Size(291, 30);
            this.dateTimePickerRegister.TabIndex = 76;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Location = new System.Drawing.Point(395, 214);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 30);
            this.DeleteBtn.TabIndex = 75;
            this.DeleteBtn.Text = "Удалить ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.descriptionTextBox.Location = new System.Drawing.Point(209, 115);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(291, 51);
            this.descriptionTextBox.TabIndex = 67;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CostTextBox.Location = new System.Drawing.Point(209, 173);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(291, 30);
            this.CostTextBox.TabIndex = 69;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(212, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 30);
            this.button2.TabIndex = 65;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightCoral;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(26, 214);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(132, 30);
            this.SaveBtn.TabIndex = 64;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(209, 43);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(291, 31);
            this.ClientComboBox.TabIndex = 78;
            this.ClientComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientComboBox_SelectedIndexChanged);
            // 
            // LabelTalon
            // 
            this.LabelTalon.AutoSize = true;
            this.LabelTalon.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelTalon.Location = new System.Drawing.Point(141, 12);
            this.LabelTalon.Name = "LabelTalon";
            this.LabelTalon.Size = new System.Drawing.Size(0, 18);
            this.LabelTalon.TabIndex = 79;
            // 
            // ProblemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(520, 256);
            this.Controls.Add(this.LabelTalon);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.dateTimePickerRegister);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProblemEdit";
            this.Text = "Запись";
            this.Load += new System.EventHandler(this.ProblemEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerRegister;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.Label LabelTalon;
    }
}