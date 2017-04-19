namespace Task_1.View
{
    partial class AddDepartment
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentGrid = new System.Windows.Forms.DataGridView();
            this.AddDepartament = new System.Windows.Forms.Button();
            this.DeleteDepartament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(54, 56);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название департамента";
            // 
            // DepartmentGrid
            // 
            this.DepartmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGrid.Location = new System.Drawing.Point(240, 56);
            this.DepartmentGrid.Name = "DepartmentGrid";
            this.DepartmentGrid.Size = new System.Drawing.Size(240, 150);
            this.DepartmentGrid.TabIndex = 2;
            // 
            // AddDepartament
            // 
            this.AddDepartament.Location = new System.Drawing.Point(54, 127);
            this.AddDepartament.Name = "AddDepartament";
            this.AddDepartament.Size = new System.Drawing.Size(75, 23);
            this.AddDepartament.TabIndex = 3;
            this.AddDepartament.Text = "Добавить";
            this.AddDepartament.UseVisualStyleBackColor = true;
            this.AddDepartament.Click += new System.EventHandler(this.AddDepartament_Click);
            // 
            // DeleteDepartament
            // 
            this.DeleteDepartament.Location = new System.Drawing.Point(405, 237);
            this.DeleteDepartament.Name = "DeleteDepartament";
            this.DeleteDepartament.Size = new System.Drawing.Size(75, 23);
            this.DeleteDepartament.TabIndex = 4;
            this.DeleteDepartament.Text = "Удалить";
            this.DeleteDepartament.UseVisualStyleBackColor = true;
            this.DeleteDepartament.Click += new System.EventHandler(this.DeleteDepartament_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 348);
            this.Controls.Add(this.DeleteDepartament);
            this.Controls.Add(this.AddDepartament);
            this.Controls.Add(this.DepartmentGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            //this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DepartmentGrid;
        private System.Windows.Forms.Button AddDepartament;
        private System.Windows.Forms.Button DeleteDepartament;
    }
}