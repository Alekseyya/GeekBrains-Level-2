﻿namespace WCFWebClient
{
    partial class Information
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
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.DepGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmp = new System.Windows.Forms.Button();
            this.AddDep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpGrid
            // 
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(22, 50);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.Size = new System.Drawing.Size(240, 150);
            this.EmpGrid.TabIndex = 0;
            // 
            // DepGrid
            // 
            this.DepGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepGrid.Location = new System.Drawing.Point(412, 50);
            this.DepGrid.Name = "DepGrid";
            this.DepGrid.Size = new System.Drawing.Size(240, 150);
            this.DepGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departments";
            // 
            // AddEmp
            // 
            this.AddEmp.Location = new System.Drawing.Point(41, 254);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(144, 23);
            this.AddEmp.TabIndex = 4;
            this.AddEmp.Text = "Добавить сотрудника";
            this.AddEmp.UseVisualStyleBackColor = true;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // AddDep
            // 
            this.AddDep.Location = new System.Drawing.Point(430, 247);
            this.AddDep.Name = "AddDep";
            this.AddDep.Size = new System.Drawing.Size(184, 23);
            this.AddDep.TabIndex = 5;
            this.AddDep.Text = "Добавать департамент";
            this.AddDep.UseVisualStyleBackColor = true;
            this.AddDep.Click += new System.EventHandler(this.AddDep_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.AddDep);
            this.Controls.Add(this.AddEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepGrid);
            this.Controls.Add(this.EmpGrid);
            this.Name = "Information";
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.DataGridView DepGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.Button AddDep;
    }
}

