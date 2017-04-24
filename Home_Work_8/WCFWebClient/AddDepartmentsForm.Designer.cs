namespace WCFWebClient
{
    partial class AddDepartmentsForm
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
            this.DepGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBoxDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DepGrid
            // 
            this.DepGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepGrid.Location = new System.Drawing.Point(252, 46);
            this.DepGrid.Name = "DepGrid";
            this.DepGrid.Size = new System.Drawing.Size(240, 150);
            this.DepGrid.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 75);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(133, 74);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBoxDep
            // 
            this.textBoxDep.Location = new System.Drawing.Point(46, 35);
            this.textBoxDep.Name = "textBoxDep";
            this.textBoxDep.Size = new System.Drawing.Size(149, 20);
            this.textBoxDep.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название департамента";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(427, 225);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddDepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 424);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDep);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DepGrid);
            this.Name = "AddDepartmentsForm";
            this.Text = "AddDepartmentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DepGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DepGrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBoxDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
    }
}