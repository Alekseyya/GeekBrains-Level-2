namespace Task_1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesGrid = new System.Windows.Forms.DataGridView();
            this.DepartmentGrid = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.AddDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGrid.Location = new System.Drawing.Point(36, 51);
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.Size = new System.Drawing.Size(297, 150);
            this.EmployeesGrid.TabIndex = 0;
            // 
            // DepartmentGrid
            // 
            this.DepartmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGrid.Location = new System.Drawing.Point(433, 51);
            this.DepartmentGrid.Name = "DepartmentGrid";
            this.DepartmentGrid.Size = new System.Drawing.Size(282, 150);
            this.DepartmentGrid.TabIndex = 1;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(36, 273);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(131, 23);
            this.AddEmployee.TabIndex = 2;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // AddDepartment
            // 
            this.AddDepartment.Location = new System.Drawing.Point(449, 273);
            this.AddDepartment.Name = "AddDepartment";
            this.AddDepartment.Size = new System.Drawing.Size(148, 23);
            this.AddDepartment.TabIndex = 3;
            this.AddDepartment.Text = "Добавить департ.";
            this.AddDepartment.UseVisualStyleBackColor = true;
            this.AddDepartment.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 399);
            this.Controls.Add(this.AddDepartment);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.DepartmentGrid);
            this.Controls.Add(this.EmployeesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesGrid;
        private System.Windows.Forms.DataGridView DepartmentGrid;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button AddDepartment;
    }
}

