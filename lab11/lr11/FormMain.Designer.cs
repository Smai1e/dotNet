
namespace lr11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewMusicalInstrumentType = new System.Windows.Forms.ListView();
            this.columnHeaderTypeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTypeTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTypeDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTypeLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTypeAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTypeUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTypeDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewMusicalInstrument = new System.Windows.Forms.ListView();
            this.columnHeaderInstrumentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstrumentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstrumentNamed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstrumentBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInstrumentLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInstrumentAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInstrumentUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInstrumentDelete = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewMusicalInstrumentType);
            this.tabPage1.Controls.Add(this.toolStripMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вид музыкального инструмента";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewMusicalInstrumentType
            // 
            this.listViewMusicalInstrumentType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTypeId,
            this.columnHeaderTypeTitle,
            this.columnHeaderTypeDescription});
            this.listViewMusicalInstrumentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMusicalInstrumentType.FullRowSelect = true;
            this.listViewMusicalInstrumentType.GridLines = true;
            this.listViewMusicalInstrumentType.HideSelection = false;
            this.listViewMusicalInstrumentType.Location = new System.Drawing.Point(3, 30);
            this.listViewMusicalInstrumentType.Name = "listViewMusicalInstrumentType";
            this.listViewMusicalInstrumentType.Size = new System.Drawing.Size(786, 388);
            this.listViewMusicalInstrumentType.TabIndex = 1;
            this.listViewMusicalInstrumentType.UseCompatibleStateImageBehavior = false;
            this.listViewMusicalInstrumentType.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTypeId
            // 
            this.columnHeaderTypeId.Text = "id";
            this.columnHeaderTypeId.Width = 40;
            // 
            // columnHeaderTypeTitle
            // 
            this.columnHeaderTypeTitle.Text = "Title";
            this.columnHeaderTypeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTypeTitle.Width = 95;
            // 
            // columnHeaderTypeDescription
            // 
            this.columnHeaderTypeDescription.Text = "Description";
            this.columnHeaderTypeDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTypeDescription.Width = 441;
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTypeLoad,
            this.toolStripButtonTypeAdd,
            this.toolStripButtonTypeUpdate,
            this.toolStripButtonTypeDelete});
            this.toolStripMain.Location = new System.Drawing.Point(3, 3);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(786, 27);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonTypeLoad
            // 
            this.toolStripButtonTypeLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTypeLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypeLoad.Image")));
            this.toolStripButtonTypeLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTypeLoad.Name = "toolStripButtonTypeLoad";
            this.toolStripButtonTypeLoad.Size = new System.Drawing.Size(81, 24);
            this.toolStripButtonTypeLoad.Text = "Загрузить";
            this.toolStripButtonTypeLoad.Click += new System.EventHandler(this.toolStripButtonTypeLoad_Click);
            // 
            // toolStripButtonTypeAdd
            // 
            this.toolStripButtonTypeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTypeAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypeAdd.Image")));
            this.toolStripButtonTypeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTypeAdd.Name = "toolStripButtonTypeAdd";
            this.toolStripButtonTypeAdd.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonTypeAdd.Text = "Добавить";
            this.toolStripButtonTypeAdd.Click += new System.EventHandler(this.toolStripButtonTypeAdd_Click);
            // 
            // toolStripButtonTypeUpdate
            // 
            this.toolStripButtonTypeUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTypeUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypeUpdate.Image")));
            this.toolStripButtonTypeUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTypeUpdate.Name = "toolStripButtonTypeUpdate";
            this.toolStripButtonTypeUpdate.Size = new System.Drawing.Size(82, 24);
            this.toolStripButtonTypeUpdate.Text = "Обновить";
            this.toolStripButtonTypeUpdate.Click += new System.EventHandler(this.toolStripButtonTypeUpdate_Click);
            // 
            // toolStripButtonTypeDelete
            // 
            this.toolStripButtonTypeDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTypeDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypeDelete.Image")));
            this.toolStripButtonTypeDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTypeDelete.Name = "toolStripButtonTypeDelete";
            this.toolStripButtonTypeDelete.Size = new System.Drawing.Size(69, 24);
            this.toolStripButtonTypeDelete.Text = "Удалить";
            this.toolStripButtonTypeDelete.Click += new System.EventHandler(this.toolStripButtonTypeDelete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewMusicalInstrument);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Музыкальный инструмент";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewMusicalInstrument
            // 
            this.listViewMusicalInstrument.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInstrumentId,
            this.columnHeaderInstrumentType,
            this.columnHeaderInstrumentNamed,
            this.columnHeaderInstrumentBrand});
            this.listViewMusicalInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMusicalInstrument.FullRowSelect = true;
            this.listViewMusicalInstrument.GridLines = true;
            this.listViewMusicalInstrument.HideSelection = false;
            this.listViewMusicalInstrument.Location = new System.Drawing.Point(3, 30);
            this.listViewMusicalInstrument.Name = "listViewMusicalInstrument";
            this.listViewMusicalInstrument.Size = new System.Drawing.Size(786, 388);
            this.listViewMusicalInstrument.TabIndex = 1;
            this.listViewMusicalInstrument.UseCompatibleStateImageBehavior = false;
            this.listViewMusicalInstrument.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderInstrumentId
            // 
            this.columnHeaderInstrumentId.Text = "id";
            this.columnHeaderInstrumentId.Width = 59;
            // 
            // columnHeaderInstrumentType
            // 
            this.columnHeaderInstrumentType.Text = "Type";
            this.columnHeaderInstrumentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderInstrumentType.Width = 169;
            // 
            // columnHeaderInstrumentNamed
            // 
            this.columnHeaderInstrumentNamed.Text = "Named";
            this.columnHeaderInstrumentNamed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderInstrumentNamed.Width = 182;
            // 
            // columnHeaderInstrumentBrand
            // 
            this.columnHeaderInstrumentBrand.Text = "Brand";
            this.columnHeaderInstrumentBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderInstrumentBrand.Width = 184;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInstrumentLoad,
            this.toolStripButtonInstrumentAdd,
            this.toolStripButtonInstrumentUpdate,
            this.toolStripButtonInstrumentDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInstrumentLoad
            // 
            this.toolStripButtonInstrumentLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInstrumentLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInstrumentLoad.Image")));
            this.toolStripButtonInstrumentLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInstrumentLoad.Name = "toolStripButtonInstrumentLoad";
            this.toolStripButtonInstrumentLoad.Size = new System.Drawing.Size(81, 24);
            this.toolStripButtonInstrumentLoad.Text = "Загрузить";
            this.toolStripButtonInstrumentLoad.Click += new System.EventHandler(this.toolStripButtonInstrumentLoad_Click);
            // 
            // toolStripButtonInstrumentAdd
            // 
            this.toolStripButtonInstrumentAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInstrumentAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInstrumentAdd.Image")));
            this.toolStripButtonInstrumentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInstrumentAdd.Name = "toolStripButtonInstrumentAdd";
            this.toolStripButtonInstrumentAdd.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonInstrumentAdd.Text = "Добавить";
            this.toolStripButtonInstrumentAdd.Click += new System.EventHandler(this.toolStripButtonInstrumentAdd_Click);
            // 
            // toolStripButtonInstrumentUpdate
            // 
            this.toolStripButtonInstrumentUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInstrumentUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInstrumentUpdate.Image")));
            this.toolStripButtonInstrumentUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInstrumentUpdate.Name = "toolStripButtonInstrumentUpdate";
            this.toolStripButtonInstrumentUpdate.Size = new System.Drawing.Size(82, 24);
            this.toolStripButtonInstrumentUpdate.Text = "Обновить";
            this.toolStripButtonInstrumentUpdate.Click += new System.EventHandler(this.toolStripButtonInstrumentUpdate_Click);
            // 
            // toolStripButtonInstrumentDelete
            // 
            this.toolStripButtonInstrumentDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInstrumentDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInstrumentDelete.Image")));
            this.toolStripButtonInstrumentDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInstrumentDelete.Name = "toolStripButtonInstrumentDelete";
            this.toolStripButtonInstrumentDelete.Size = new System.Drawing.Size(69, 24);
            this.toolStripButtonInstrumentDelete.Text = "Удалить";
            this.toolStripButtonInstrumentDelete.Click += new System.EventHandler(this.toolStripButtonInstrumentDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Lr11";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypeLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypeAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypeUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypeDelete;
        private System.Windows.Forms.ListView listViewMusicalInstrumentType;
        private System.Windows.Forms.ColumnHeader columnHeaderTypeId;
        private System.Windows.Forms.ColumnHeader columnHeaderTypeTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderTypeDescription;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInstrumentLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonInstrumentAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonInstrumentUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonInstrumentDelete;
        private System.Windows.Forms.ListView listViewMusicalInstrument;
        private System.Windows.Forms.ColumnHeader columnHeaderInstrumentId;
        private System.Windows.Forms.ColumnHeader columnHeaderInstrumentType;
        private System.Windows.Forms.ColumnHeader columnHeaderInstrumentNamed;
        private System.Windows.Forms.ColumnHeader columnHeaderInstrumentBrand;
    }
}

