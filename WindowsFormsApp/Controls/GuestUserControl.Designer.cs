namespace WindowsFormsApp.Controls
{
    partial class GuestUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fio = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.fio.Location = new System.Drawing.Point(20, 20);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(41, 16);
            this.fio.TabIndex = 0;
            this.fio.Text = "ФИО:";
            this.fio.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.gender.Location = new System.Drawing.Point(20, 53);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(39, 16);
            this.gender.TabIndex = 1;
            this.gender.Text = "Пол: ";
            this.gender.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.birthday.Location = new System.Drawing.Point(20, 119);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(109, 16);
            this.birthday.TabIndex = 2;
            this.birthday.Text = "Дата рождения:";
            this.birthday.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.count.Location = new System.Drawing.Point(20, 86);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(202, 16);
            this.count.TabIndex = 3;
            this.count.Text = "Сколько раз останавливался:";
            this.count.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.status.Location = new System.Drawing.Point(20, 20);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(56, 16);
            this.status.TabIndex = 4;
            this.status.Text = "Статус:";
            this.status.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(778, 150);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.fio);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 150);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.historyButton);
            this.panel2.Controls.Add(this.status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(389, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 150);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.GuestUserControl_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.White;
            this.historyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.historyButton.Location = new System.Drawing.Point(130, 112);
            this.historyButton.Margin = new System.Windows.Forms.Padding(0);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(150, 23);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "История";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // GuestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "GuestUserControl";
            this.Size = new System.Drawing.Size(778, 150);
            this.Click += new System.EventHandler(this.GuestUserControl_Click);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button historyButton;
    }
}
