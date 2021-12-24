
namespace dotNet_lab_2._1
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
            this.btnStyle = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnOpacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStyle
            // 
            this.btnStyle.Location = new System.Drawing.Point(309, 76);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(129, 43);
            this.btnStyle.TabIndex = 0;
            this.btnStyle.Text = "Border Style";
            this.btnStyle.UseVisualStyleBackColor = true;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(309, 150);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(129, 43);
            this.btnResize.TabIndex = 1;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnOpacity
            // 
            this.btnOpacity.Location = new System.Drawing.Point(309, 221);
            this.btnOpacity.Name = "btnOpacity";
            this.btnOpacity.Size = new System.Drawing.Size(129, 43);
            this.btnOpacity.TabIndex = 2;
            this.btnOpacity.Text = "Opacity";
            this.btnOpacity.UseVisualStyleBackColor = true;
            this.btnOpacity.Click += new System.EventHandler(this.btnOpacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpacity);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnOpacity;
    }
}

