
namespace lr10PlantsClient
{
    partial class FormGetDeletePlant
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(164, 28);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(191, 22);
            this.textBoxKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название (ключ)";
            // 
            // buttonGet
            // 
            this.buttonGet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGet.Location = new System.Drawing.Point(118, 95);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(117, 33);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Получить";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // FormGetDeletePlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 140);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKey);
            this.Name = "FormGetDeletePlant";
            this.Text = "Получить растение по ключу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGet;
    }
}