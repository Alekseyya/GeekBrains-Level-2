namespace Task_2
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddUrl = new System.Windows.Forms.Button();
            this.buttonClearGrid = new System.Windows.Forms.Button();
            this.buttonExecuteResponce = new System.Windows.Forms.Button();
            this.buttonRefrash = new System.Windows.Forms.Button();
            this.buttonTestData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(12, 71);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url parse";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url,
            this.Error,
            this.Response});
            this.dataGridView1.Location = new System.Drawing.Point(148, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            // 
            // Error
            // 
            this.Error.HeaderText = "ErrorOrLength";
            this.Error.Name = "Error";
            // 
            // Response
            // 
            this.Response.HeaderText = "TimeResponse";
            this.Response.Name = "Response";
            // 
            // buttonAddUrl
            // 
            this.buttonAddUrl.Location = new System.Drawing.Point(12, 135);
            this.buttonAddUrl.Name = "buttonAddUrl";
            this.buttonAddUrl.Size = new System.Drawing.Size(100, 23);
            this.buttonAddUrl.TabIndex = 3;
            this.buttonAddUrl.Text = "Добавить адрес";
            this.buttonAddUrl.UseVisualStyleBackColor = true;
            this.buttonAddUrl.Click += new System.EventHandler(this.buttonAddUrl_Click);
            // 
            // buttonClearGrid
            // 
            this.buttonClearGrid.Location = new System.Drawing.Point(525, 207);
            this.buttonClearGrid.Name = "buttonClearGrid";
            this.buttonClearGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonClearGrid.TabIndex = 4;
            this.buttonClearGrid.Text = "Очистить список";
            this.buttonClearGrid.UseVisualStyleBackColor = true;
            this.buttonClearGrid.Click += new System.EventHandler(this.buttonClearGrid_Click);
            // 
            // buttonExecuteResponce
            // 
            this.buttonExecuteResponce.Location = new System.Drawing.Point(148, 216);
            this.buttonExecuteResponce.Name = "buttonExecuteResponce";
            this.buttonExecuteResponce.Size = new System.Drawing.Size(122, 23);
            this.buttonExecuteResponce.TabIndex = 5;
            this.buttonExecuteResponce.Text = "Выполнить запросы";
            this.buttonExecuteResponce.UseVisualStyleBackColor = true;
            this.buttonExecuteResponce.Click += new System.EventHandler(this.buttonExecuteResponce_Click);
            // 
            // buttonRefrash
            // 
            this.buttonRefrash.Location = new System.Drawing.Point(325, 215);
            this.buttonRefrash.Name = "buttonRefrash";
            this.buttonRefrash.Size = new System.Drawing.Size(75, 23);
            this.buttonRefrash.TabIndex = 6;
            this.buttonRefrash.Text = "Обновить";
            this.buttonRefrash.UseVisualStyleBackColor = true;
            this.buttonRefrash.Click += new System.EventHandler(this.buttonRefrash_Click);
            // 
            // buttonTestData
            // 
            this.buttonTestData.Location = new System.Drawing.Point(12, 207);
            this.buttonTestData.Name = "buttonTestData";
            this.buttonTestData.Size = new System.Drawing.Size(100, 42);
            this.buttonTestData.TabIndex = 7;
            this.buttonTestData.Text = "Тестовые данные";
            this.buttonTestData.UseVisualStyleBackColor = true;
            this.buttonTestData.Click += new System.EventHandler(this.buttonTestData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 261);
            this.Controls.Add(this.buttonTestData);
            this.Controls.Add(this.buttonRefrash);
            this.Controls.Add(this.buttonExecuteResponce);
            this.Controls.Add(this.buttonClearGrid);
            this.Controls.Add(this.buttonAddUrl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddUrl;
        private System.Windows.Forms.Button buttonClearGrid;
        public System.Windows.Forms.Button buttonExecuteResponce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
        private System.Windows.Forms.Button buttonRefrash;
        private System.Windows.Forms.Button buttonTestData;
    }
}

