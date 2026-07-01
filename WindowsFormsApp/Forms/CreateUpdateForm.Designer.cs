namespace WindowsFormsApp.Forms
{
    partial class CreateUpdateForm
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label statusIdLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateForm));
            this.hotelDataSet = new HotelApp.HotelDataSet();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.statusIdComboBox = new System.Windows.Forms.ComboBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            fullNameLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(147, 27);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(41, 16);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "ФИО:";
            // 
            // statusIdLabel
            // 
            statusIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(132, 238);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(56, 16);
            statusIdLabel.TabIndex = 7;
            statusIdLabel.Text = "Статус:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(79, 97);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(109, 16);
            birthdayLabel.TabIndex = 3;
            birthdayLabel.Text = "День рождения:";
            // 
            // genderIdLabel
            // 
            genderIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(152, 167);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(36, 16);
            genderIdLabel.TabIndex = 5;
            genderIdLabel.Text = "Пол:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.hotelDataSet;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.hotelDataSet;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.hotelDataSet;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(fullNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(statusIdLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.genderIdComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.statusIdComboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.birthdayDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fullNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(birthdayLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(genderIdLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 282);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataSource = this.genderBindingSource;
            this.genderIdComboBox.DisplayMember = "GenderName";
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(194, 163);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(185, 24);
            this.genderIdComboBox.TabIndex = 6;
            this.genderIdComboBox.ValueMember = "IdGender";
            // 
            // statusIdComboBox
            // 
            this.statusIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataSource = this.statusBindingSource;
            this.statusIdComboBox.DisplayMember = "StatusName";
            this.statusIdComboBox.FormattingEnabled = true;
            this.statusIdComboBox.Location = new System.Drawing.Point(194, 234);
            this.statusIdComboBox.Name = "statusIdComboBox";
            this.statusIdComboBox.Size = new System.Drawing.Size(185, 24);
            this.statusIdComboBox.TabIndex = 8;
            this.statusIdComboBox.ValueMember = "IdStatus";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guestBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(194, 94);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(185, 22);
            this.birthdayDateTimePicker.TabIndex = 4;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(194, 24);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(185, 22);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.saveButton.Location = new System.Drawing.Point(116, 306);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateUpdateForm";
            this.Text = "Редактор гостя";
            this.Load += new System.EventHandler(this.CreateUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HotelApp.HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox genderIdComboBox;
        private System.Windows.Forms.ComboBox statusIdComboBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}