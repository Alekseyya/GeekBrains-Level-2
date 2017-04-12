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
            this.LableDepatament = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.CBDepartament = new System.Windows.Forms.ComboBox();
            this.CBEmployee = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddDepbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LableDepatament
            // 
            this.LableDepatament.AutoSize = true;
            this.LableDepatament.Location = new System.Drawing.Point(52, 29);
            this.LableDepatament.Name = "LableDepatament";
            this.LableDepatament.Size = new System.Drawing.Size(76, 13);
            this.LableDepatament.TabIndex = 0;
            this.LableDepatament.Text = "Департамент";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Location = new System.Drawing.Point(252, 29);
            this.LabelEmployee.Name = "LabelEmployee";
            this.LabelEmployee.Size = new System.Drawing.Size(66, 13);
            this.LabelEmployee.TabIndex = 1;
            this.LabelEmployee.Text = "Сотрудники";
            // 
            // CBDepartament
            // 
            this.CBDepartament.FormattingEnabled = true;
            this.CBDepartament.Location = new System.Drawing.Point(26, 55);
            this.CBDepartament.Name = "CBDepartament";
            this.CBDepartament.Size = new System.Drawing.Size(170, 21);
            this.CBDepartament.TabIndex = 2;
            // 
            // CBEmployee
            // 
            this.CBEmployee.FormattingEnabled = true;
            this.CBEmployee.Location = new System.Drawing.Point(255, 55);
            this.CBEmployee.Name = "CBEmployee";
            this.CBEmployee.Size = new System.Drawing.Size(141, 21);
            this.CBEmployee.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(26, 174);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(133, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить сотрудника";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddDepbutton
            // 
            this.AddDepbutton.Location = new System.Drawing.Point(255, 174);
            this.AddDepbutton.Name = "AddDepbutton";
            this.AddDepbutton.Size = new System.Drawing.Size(141, 23);
            this.AddDepbutton.TabIndex = 5;
            this.AddDepbutton.Text = "Добавить департамент";
            this.AddDepbutton.UseVisualStyleBackColor = true;
            this.AddDepbutton.Click += new System.EventHandler(this.AddDepbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 358);
            this.Controls.Add(this.AddDepbutton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CBEmployee);
            this.Controls.Add(this.CBDepartament);
            this.Controls.Add(this.LabelEmployee);
            this.Controls.Add(this.LableDepatament);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LableDepatament;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.ComboBox CBDepartament;
        private System.Windows.Forms.ComboBox CBEmployee;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddDepbutton;
    }
}

