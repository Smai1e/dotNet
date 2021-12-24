namespace Lab04
{
    partial class FormBook
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelJenre = new System.Windows.Forms.Label();
            this.comboBoxJenre = new System.Windows.Forms.ComboBox();
            this.numericUpDownPledgeCost = new System.Windows.Forms.NumericUpDown();
            this.labelPledgeCost = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.numericUpDownRentalCost = new System.Windows.Forms.NumericUpDown();
            this.labelRentalCost = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPledgeCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalCost)).BeginInit();
            this.groupBoxAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(613, 200);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 34);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelJenre
            // 
            this.labelJenre.AutoSize = true;
            this.labelJenre.Location = new System.Drawing.Point(26, 79);
            this.labelJenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJenre.Name = "labelJenre";
            this.labelJenre.Size = new System.Drawing.Size(49, 17);
            this.labelJenre.TabIndex = 3;
            this.labelJenre.Text = "Жанр:";
            // 
            // comboBoxJenre
            // 
            this.comboBoxJenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJenre.FormattingEnabled = true;
            this.comboBoxJenre.Location = new System.Drawing.Point(178, 75);
            this.comboBoxJenre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxJenre.Name = "comboBoxJenre";
            this.comboBoxJenre.Size = new System.Drawing.Size(140, 24);
            this.comboBoxJenre.TabIndex = 4;
            // 
            // numericUpDownPledgeCost
            // 
            this.numericUpDownPledgeCost.DecimalPlaces = 2;
            this.numericUpDownPledgeCost.Location = new System.Drawing.Point(178, 108);
            this.numericUpDownPledgeCost.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPledgeCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPledgeCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPledgeCost.Name = "numericUpDownPledgeCost";
            this.numericUpDownPledgeCost.Size = new System.Drawing.Size(141, 22);
            this.numericUpDownPledgeCost.TabIndex = 6;
            this.numericUpDownPledgeCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPledgeCost.ThousandsSeparator = true;
            this.numericUpDownPledgeCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPledgeCost
            // 
            this.labelPledgeCost.AutoSize = true;
            this.labelPledgeCost.Location = new System.Drawing.Point(26, 111);
            this.labelPledgeCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPledgeCost.Name = "labelPledgeCost";
            this.labelPledgeCost.Size = new System.Drawing.Size(157, 17);
            this.labelPledgeCost.TabIndex = 5;
            this.labelPledgeCost.Text = "Залоговая стоймость: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(178, 45);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 45);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 17);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Название:";
            // 
            // numericUpDownRentalCost
            // 
            this.numericUpDownRentalCost.DecimalPlaces = 2;
            this.numericUpDownRentalCost.Location = new System.Drawing.Point(178, 141);
            this.numericUpDownRentalCost.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRentalCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRentalCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRentalCost.Name = "numericUpDownRentalCost";
            this.numericUpDownRentalCost.Size = new System.Drawing.Size(141, 22);
            this.numericUpDownRentalCost.TabIndex = 12;
            this.numericUpDownRentalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownRentalCost.ThousandsSeparator = true;
            this.numericUpDownRentalCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRentalCost
            // 
            this.labelRentalCost.AutoSize = true;
            this.labelRentalCost.Location = new System.Drawing.Point(26, 144);
            this.labelRentalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRentalCost.Name = "labelRentalCost";
            this.labelRentalCost.Size = new System.Drawing.Size(144, 17);
            this.labelRentalCost.TabIndex = 11;
            this.labelRentalCost.Text = "Стоймость проката: ";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(148, 86);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(175, 22);
            this.textBoxMiddleName.TabIndex = 25;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(14, 89);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(75, 17);
            this.labelMiddleName.TabIndex = 24;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(148, 54);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(175, 22);
            this.textBoxFirstName.TabIndex = 23;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(14, 57);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 17);
            this.labelFirstName.TabIndex = 22;
            this.labelFirstName.Text = "Имя:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(148, 22);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(175, 22);
            this.textBoxLastName.TabIndex = 21;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(14, 25);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(74, 17);
            this.labelLastName.TabIndex = 20;
            this.labelLastName.Text = "Фамилия:";
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.textBoxMiddleName);
            this.groupBoxAuthor.Controls.Add(this.labelMiddleName);
            this.groupBoxAuthor.Controls.Add(this.textBoxFirstName);
            this.groupBoxAuthor.Controls.Add(this.labelFirstName);
            this.groupBoxAuthor.Controls.Add(this.textBoxLastName);
            this.groupBoxAuthor.Controls.Add(this.labelLastName);
            this.groupBoxAuthor.Location = new System.Drawing.Point(370, 23);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(352, 136);
            this.groupBoxAuthor.TabIndex = 30;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Автор";
            // 
            // FormBook
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 249);
            this.Controls.Add(this.groupBoxAuthor);
            this.Controls.Add(this.numericUpDownRentalCost);
            this.Controls.Add(this.labelRentalCost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.numericUpDownPledgeCost);
            this.Controls.Add(this.labelPledgeCost);
            this.Controls.Add(this.comboBoxJenre);
            this.Controls.Add(this.labelJenre);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Книга";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPledgeCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalCost)).EndInit();
            this.groupBoxAuthor.ResumeLayout(false);
            this.groupBoxAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelJenre;
        private System.Windows.Forms.ComboBox comboBoxJenre;
        private System.Windows.Forms.NumericUpDown numericUpDownPledgeCost;
        private System.Windows.Forms.Label labelPledgeCost;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown numericUpDownRentalCost;
        private System.Windows.Forms.Label labelRentalCost;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox groupBoxAuthor;
    }
}