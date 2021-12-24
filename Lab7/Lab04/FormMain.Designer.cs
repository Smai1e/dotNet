namespace Lab04
{
    partial class FormMain
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
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIssuedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editIssuedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.listViewReaders = new System.Windows.Forms.ListView();
            this.columnHeaderReaderFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.columnHeaderBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageIssuedBooks = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.issuedBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReaderToolStripMenuItem,
            this.editReaderToolStripMenuItem});
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            this.readersToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.readersToolStripMenuItem.Text = "Читатели";
            // 
            // addReaderToolStripMenuItem
            // 
            this.addReaderToolStripMenuItem.Name = "addReaderToolStripMenuItem";
            this.addReaderToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addReaderToolStripMenuItem.Text = "Добавить";
            this.addReaderToolStripMenuItem.Click += new System.EventHandler(this.addReaderToolStripMenuItem_Click);
            // 
            // editReaderToolStripMenuItem
            // 
            this.editReaderToolStripMenuItem.Name = "editReaderToolStripMenuItem";
            this.editReaderToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editReaderToolStripMenuItem.Text = "Редактировать";
            this.editReaderToolStripMenuItem.Click += new System.EventHandler(this.editReaderToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.editBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.booksToolStripMenuItem.Text = "Книги";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addBookToolStripMenuItem.Text = "Добавить";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editBookToolStripMenuItem.Text = "Редактировать";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // issuedBookToolStripMenuItem
            // 
            this.issuedBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIssuedBookToolStripMenuItem,
            this.editIssuedBookToolStripMenuItem});
            this.issuedBookToolStripMenuItem.Name = "issuedBookToolStripMenuItem";
            this.issuedBookToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.issuedBookToolStripMenuItem.Text = "Выданные книги";
            // 
            // addIssuedBookToolStripMenuItem
            // 
            this.addIssuedBookToolStripMenuItem.Name = "addIssuedBookToolStripMenuItem";
            this.addIssuedBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addIssuedBookToolStripMenuItem.Text = "Добавить";
            this.addIssuedBookToolStripMenuItem.Click += new System.EventHandler(this.addIssuedBookToolStripMenuItem_Click);
            // 
            // editIssuedBookToolStripMenuItem
            // 
            this.editIssuedBookToolStripMenuItem.Name = "editIssuedBookToolStripMenuItem";
            this.editIssuedBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editIssuedBookToolStripMenuItem.Text = "Редактировать";
            this.editIssuedBookToolStripMenuItem.Click += new System.EventHandler(this.editIssuedBookToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPageBooks);
            this.tabControlMain.Controls.Add(this.tabPageIssuedBooks);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 28);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(723, 301);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.listViewReaders);
            this.tabPageClients.Location = new System.Drawing.Point(4, 25);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(715, 272);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Читатели";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // listViewReaders
            // 
            this.listViewReaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderReaderFIO});
            this.listViewReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewReaders.HideSelection = false;
            this.listViewReaders.Location = new System.Drawing.Point(3, 3);
            this.listViewReaders.Name = "listViewReaders";
            this.listViewReaders.Size = new System.Drawing.Size(709, 266);
            this.listViewReaders.TabIndex = 0;
            this.listViewReaders.UseCompatibleStateImageBehavior = false;
            this.listViewReaders.View = System.Windows.Forms.View.Details;
            this.listViewReaders.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewReaders_KeyUp);
            // 
            // columnHeaderReaderFIO
            // 
            this.columnHeaderReaderFIO.Text = "ФИО читателя";
            this.columnHeaderReaderFIO.Width = 609;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.listViewBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(715, 272);
            this.tabPageBooks.TabIndex = 1;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // listViewBooks
            // 
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBook});
            this.listViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(3, 3);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(709, 266);
            this.listViewBooks.TabIndex = 1;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            this.listViewBooks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewBooks_KeyUp);
            // 
            // columnHeaderBook
            // 
            this.columnHeaderBook.Text = "Название";
            this.columnHeaderBook.Width = 630;
            // 
            // tabPageIssuedBooks
            // 
            this.tabPageIssuedBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageIssuedBooks.Name = "tabPageIssuedBooks";
            this.tabPageIssuedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIssuedBooks.Size = new System.Drawing.Size(715, 272);
            this.tabPageIssuedBooks.TabIndex = 2;
            this.tabPageIssuedBooks.Text = "Выданные книги";
            this.tabPageIssuedBooks.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 329);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIssuedBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIssuedBookToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.TabPage tabPageIssuedBooks;
        private System.Windows.Forms.ListView listViewReaders;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ColumnHeader columnHeaderReaderFIO;
        private System.Windows.Forms.ColumnHeader columnHeaderBook;
    }
}

