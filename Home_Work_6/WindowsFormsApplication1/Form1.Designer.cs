namespace WindowsFormsApplication1
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
            this.dtpMemo = new System.Windows.Forms.DateTimePicker();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMemo
            // 
            this.dtpMemo.Location = new System.Drawing.Point(21, 32);
            this.dtpMemo.Name = "dtpMemo";
            this.dtpMemo.Size = new System.Drawing.Size(200, 20);
            this.dtpMemo.TabIndex = 2;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(21, 84);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(200, 66);
            this.tbMemo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Text,
            this.Date});
            this.grid.Location = new System.Drawing.Point(302, 84);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(240, 150);
            this.grid.TabIndex = 5;
            // 
            // Text
            // 
            this.Text.HeaderText = "Text";
            this.Text.Name = "Text";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 348);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.dtpMemo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMemo;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

