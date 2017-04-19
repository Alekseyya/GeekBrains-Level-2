namespace Task_1.View
{
    partial class AddEmployee
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
            this.DepId = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeesGrid = new System.Windows.Forms.DataGridView();
            this.AddEployees = new System.Windows.Forms.Button();
            this.DeleteSelectEmployee = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.Salary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DepId
            // 
            this.DepId.FormattingEnabled = true;
            this.DepId.Location = new System.Drawing.Point(21, 98);
            this.DepId.Name = "DepId";
            this.DepId.Size = new System.Drawing.Size(121, 21);
            this.DepId.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(21, 157);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 2;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(21, 220);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dep Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGrid.Location = new System.Drawing.Point(224, 98);
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.Size = new System.Drawing.Size(287, 204);
            this.EmployeesGrid.TabIndex = 8;
            // 
            // AddEployees
            // 
            this.AddEployees.Location = new System.Drawing.Point(224, 338);
            this.AddEployees.Name = "AddEployees";
            this.AddEployees.Size = new System.Drawing.Size(75, 23);
            this.AddEployees.TabIndex = 9;
            this.AddEployees.Text = "Добавить";
            this.AddEployees.UseVisualStyleBackColor = true;
            this.AddEployees.Click += new System.EventHandler(this.AddEployees_Click);
            // 
            // DeleteSelectEmployee
            // 
            this.DeleteSelectEmployee.Location = new System.Drawing.Point(436, 338);
            this.DeleteSelectEmployee.Name = "DeleteSelectEmployee";
            this.DeleteSelectEmployee.Size = new System.Drawing.Size(75, 23);
            this.DeleteSelectEmployee.TabIndex = 10;
            this.DeleteSelectEmployee.Text = "Удалить";
            this.DeleteSelectEmployee.UseVisualStyleBackColor = true;
            this.DeleteSelectEmployee.Click += new System.EventHandler(this.DeleteSelectEmployee_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.Location = new System.Drawing.Point(21, 328);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(75, 23);
            this.ClearFields.TabIndex = 11;
            this.ClearFields.Text = "Очистить поля";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(21, 282);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(100, 20);
            this.Salary.TabIndex = 12;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.DeleteSelectEmployee);
            this.Controls.Add(this.AddEployees);
            this.Controls.Add(this.EmployeesGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.DepId);
            //this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DepId;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView EmployeesGrid;
        private System.Windows.Forms.Button AddEployees;
        private System.Windows.Forms.Button DeleteSelectEmployee;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.TextBox Salary;
    }
}