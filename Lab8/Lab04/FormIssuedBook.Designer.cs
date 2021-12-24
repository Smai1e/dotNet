
namespace Lab04
{
    partial class FormIssuedBook
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
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelReader = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(98, 55);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(327, 24);
            this.comboBoxBook.TabIndex = 0;
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(98, 12);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(327, 24);
            this.comboBoxReader.TabIndex = 1;
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(133, 103);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerIssueDate.TabIndex = 3;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(133, 134);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerReturnDate.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(314, 167);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 34);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.Location = new System.Drawing.Point(17, 15);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(75, 17);
            this.labelReader.TabIndex = 6;
            this.labelReader.Text = "Читатель:";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(17, 58);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(50, 17);
            this.labelBook.TabIndex = 7;
            this.labelBook.Text = "Книга:";
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Location = new System.Drawing.Point(17, 108);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(99, 17);
            this.labelIssueDate.TabIndex = 8;
            this.labelIssueDate.Text = "Дата выдачи:";
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(17, 139);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(110, 17);
            this.labelReturnDate.TabIndex = 9;
            this.labelReturnDate.Text = "Дата возврата:";
            // 
            // FormIssuedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 214);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.labelIssueDate);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.labelReader);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.dateTimePickerIssueDate);
            this.Controls.Add(this.comboBoxReader);
            this.Controls.Add(this.comboBoxBook);
            this.Name = "FormIssuedBook";
            this.Text = "FormIssuedBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelReader;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label labelReturnDate;
    }
}