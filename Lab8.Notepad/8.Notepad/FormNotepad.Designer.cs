
namespace _8.Notepad
{
    partial class FormNotepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemCreate,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemClose});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(59, 24);
            this.ToolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemOpen.Text = "Открыть файл..";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemCreate
            // 
            this.toolStripMenuItemCreate.Name = "toolStripMenuItemCreate";
            this.toolStripMenuItemCreate.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemCreate.Text = "Создать файл..";
            this.toolStripMenuItemCreate.Click += new System.EventHandler(this.toolStripMenuItemCreate_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Enabled = false;
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSave.Text = "Сохранить";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Enabled = false;
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            this.toolStripMenuItemClose.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemClose.Text = "Закрыть";
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemClose_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMain.Enabled = false;
            this.textBoxMain.Location = new System.Drawing.Point(0, 28);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMain.MaxLength = 900000;
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMain.Size = new System.Drawing.Size(1067, 526);
            this.textBoxMain.TabIndex = 1;
            this.textBoxMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editorKeyUp);
            // 
            // FormNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNotepad";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveAfterClose);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editorKeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
    }
}

