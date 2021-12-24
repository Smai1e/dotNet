namespace WindowsFormsControlLibrary_
{
    partial class UserControlIssuedBook
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.textBoxReader = new System.Windows.Forms.TextBox();
            this.labelReader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(586, 42);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(36, 26);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(83, 44);
            this.textBoxPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.ReadOnly = true;
            this.textBoxPeriod.Size = new System.Drawing.Size(495, 22);
            this.textBoxPeriod.TabIndex = 19;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(9, 48);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(62, 17);
            this.labelPeriod.TabIndex = 18;
            this.labelPeriod.Text = "Период:";
            // 
            // textBoxBook
            // 
            this.textBoxBook.Location = new System.Drawing.Point(509, 12);
            this.textBoxBook.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.ReadOnly = true;
            this.textBoxBook.Size = new System.Drawing.Size(113, 22);
            this.textBoxBook.TabIndex = 17;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(451, 16);
            this.labelBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(50, 17);
            this.labelBook.TabIndex = 16;
            this.labelBook.Text = "Книга:";
            // 
            // textBoxReader
            // 
            this.textBoxReader.Location = new System.Drawing.Point(83, 13);
            this.textBoxReader.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReader.Name = "textBoxReader";
            this.textBoxReader.ReadOnly = true;
            this.textBoxReader.Size = new System.Drawing.Size(349, 22);
            this.textBoxReader.TabIndex = 15;
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.Location = new System.Drawing.Point(9, 16);
            this.labelReader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(75, 17);
            this.labelReader.TabIndex = 14;
            this.labelReader.Text = "Читатель:";
            // 
            // UserControlIssuedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.textBoxBook);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.textBoxReader);
            this.Controls.Add(this.labelReader);
            this.Name = "UserControlIssuedBook";
            this.Size = new System.Drawing.Size(641, 85);
            this.Click += new System.EventHandler(this.UserControlIssuedBook_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlIssuedBook_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.TextBox textBoxReader;
        private System.Windows.Forms.Label labelReader;
    }
}
