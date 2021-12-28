
namespace RGR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.plantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNetRGRDataSet = new RGR.dotNetRGRDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plant_img_pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скачатьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСвоёИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDecorativeQualities = new System.Windows.Forms.TextBox();
            this.textBoxVariety = new System.Windows.Forms.TextBox();
            this.textBoxGenus = new System.Windows.Forms.TextBox();
            this.plantTableAdapter = new RGR.dotNetRGRDataSetTableAdapters.plantTableAdapter();
            this.tableAdapterManager = new RGR.dotNetRGRDataSetTableAdapters.TableAdapterManager();
            this.plantBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.plantBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDownloadData = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPauseDownloading = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTruncateTable = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetRGRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_img_pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingNavigator)).BeginInit();
            this.plantBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip);
            this.splitContainer1.Panel1.Controls.Add(this.plantDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.plant_img_pictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDecorativeQualities);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxVariety);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxGenus);
            this.splitContainer1.Size = new System.Drawing.Size(1277, 584);
            this.splitContainer1.SplitterDistance = 872;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 562);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(872, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // plantDataGridView
            // 
            this.plantDataGridView.AllowUserToAddRows = false;
            this.plantDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plantDataGridView.AutoGenerateColumns = false;
            this.plantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plantDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plantDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.plantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4});
            this.plantDataGridView.DataSource = this.plantBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plantDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.plantDataGridView.Location = new System.Drawing.Point(3, 32);
            this.plantDataGridView.Name = "plantDataGridView";
            this.plantDataGridView.ReadOnly = true;
            this.plantDataGridView.RowHeadersWidth = 51;
            this.plantDataGridView.RowTemplate.Height = 24;
            this.plantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plantDataGridView.Size = new System.Drawing.Size(866, 549);
            this.plantDataGridView.TabIndex = 0;
            this.plantDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.plantDataGridView_DataError);
            this.plantDataGridView.SelectionChanged += new System.EventHandler(this.plantDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "plant_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "plant_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "genus";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "variety";
            this.dataGridViewTextBoxColumn3.HeaderText = "Роды(сорта)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.DataPropertyName = "img";
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "decorative_qualities";
            this.dataGridViewTextBoxColumn4.HeaderText = "Декоративные качества";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "plant";
            this.plantBindingSource.DataSource = this.dotNetRGRDataSet;
            // 
            // dotNetRGRDataSet
            // 
            this.dotNetRGRDataSet.DataSetName = "dotNetRGRDataSet";
            this.dotNetRGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Декоративные качества:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фото:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Роды(сорта):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вид:";
            // 
            // plant_img_pictureBox
            // 
            this.plant_img_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plant_img_pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plant_img_pictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.plant_img_pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.plantBindingSource, "img", true));
            this.plant_img_pictureBox.Location = new System.Drawing.Point(189, 160);
            this.plant_img_pictureBox.Name = "plant_img_pictureBox";
            this.plant_img_pictureBox.Size = new System.Drawing.Size(188, 176);
            this.plant_img_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plant_img_pictureBox.TabIndex = 3;
            this.plant_img_pictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скачатьИзображениеToolStripMenuItem,
            this.загрузитьСвоёИзображениеToolStripMenuItem,
            this.удалитьИзображениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(283, 76);
            // 
            // скачатьИзображениеToolStripMenuItem
            // 
            this.скачатьИзображениеToolStripMenuItem.Name = "скачатьИзображениеToolStripMenuItem";
            this.скачатьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.скачатьИзображениеToolStripMenuItem.Text = "Скачать изображение";
            this.скачатьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.скачатьИзображениеToolStripMenuItem_Click);
            // 
            // загрузитьСвоёИзображениеToolStripMenuItem
            // 
            this.загрузитьСвоёИзображениеToolStripMenuItem.Name = "загрузитьСвоёИзображениеToolStripMenuItem";
            this.загрузитьСвоёИзображениеToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.загрузитьСвоёИзображениеToolStripMenuItem.Text = "Загрузить своё изображение";
            this.загрузитьСвоёИзображениеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСвоёИзображениеToolStripMenuItem_Click);
            // 
            // удалитьИзображениеToolStripMenuItem
            // 
            this.удалитьИзображениеToolStripMenuItem.Name = "удалитьИзображениеToolStripMenuItem";
            this.удалитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.удалитьИзображениеToolStripMenuItem.Text = "Удалить изображение";
            this.удалитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзображениеToolStripMenuItem_Click);
            // 
            // textBoxDecorativeQualities
            // 
            this.textBoxDecorativeQualities.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantBindingSource, "decorative_qualities", true));
            this.textBoxDecorativeQualities.Location = new System.Drawing.Point(39, 394);
            this.textBoxDecorativeQualities.Multiline = true;
            this.textBoxDecorativeQualities.Name = "textBoxDecorativeQualities";
            this.textBoxDecorativeQualities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecorativeQualities.Size = new System.Drawing.Size(338, 178);
            this.textBoxDecorativeQualities.TabIndex = 2;
            // 
            // textBoxVariety
            // 
            this.textBoxVariety.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantBindingSource, "variety", true));
            this.textBoxVariety.Location = new System.Drawing.Point(169, 109);
            this.textBoxVariety.Multiline = true;
            this.textBoxVariety.Name = "textBoxVariety";
            this.textBoxVariety.Size = new System.Drawing.Size(208, 22);
            this.textBoxVariety.TabIndex = 1;
            // 
            // textBoxGenus
            // 
            this.textBoxGenus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantBindingSource, "genus", true));
            this.textBoxGenus.Location = new System.Drawing.Point(169, 70);
            this.textBoxGenus.Name = "textBoxGenus";
            this.textBoxGenus.Size = new System.Drawing.Size(208, 22);
            this.textBoxGenus.TabIndex = 0;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.plantTableAdapter = this.plantTableAdapter;
            this.tableAdapterManager.UpdateOrder = RGR.dotNetRGRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // plantBindingNavigator
            // 
            this.plantBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plantBindingNavigator.BindingSource = this.plantBindingSource;
            this.plantBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plantBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plantBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.plantBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.plantBindingNavigatorSaveItem,
            this.toolStripButtonDownloadData,
            this.toolStripButtonPauseDownloading,
            this.toolStripButtonUpdateTable,
            this.toolStripButtonTruncateTable});
            this.plantBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plantBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plantBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plantBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plantBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plantBindingNavigator.Name = "plantBindingNavigator";
            this.plantBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plantBindingNavigator.Size = new System.Drawing.Size(1277, 27);
            this.plantBindingNavigator.TabIndex = 1;
            this.plantBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // plantBindingNavigatorSaveItem
            // 
            this.plantBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plantBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plantBindingNavigatorSaveItem.Image")));
            this.plantBindingNavigatorSaveItem.Name = "plantBindingNavigatorSaveItem";
            this.plantBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.plantBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.plantBindingNavigatorSaveItem.Click += new System.EventHandler(this.plantBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonDownloadData
            // 
            this.toolStripButtonDownloadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDownloadData.Image = global::RGR.Properties.Resources.Download;
            this.toolStripButtonDownloadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownloadData.Name = "toolStripButtonDownloadData";
            this.toolStripButtonDownloadData.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDownloadData.Text = "Начать скачивание данных сайта";
            this.toolStripButtonDownloadData.Click += new System.EventHandler(this.toolStripButtonDownloadData_Click);
            // 
            // toolStripButtonPauseDownloading
            // 
            this.toolStripButtonPauseDownloading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPauseDownloading.Image = global::RGR.Properties.Resources.Pause;
            this.toolStripButtonPauseDownloading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPauseDownloading.Name = "toolStripButtonPauseDownloading";
            this.toolStripButtonPauseDownloading.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonPauseDownloading.Text = "Остановить скачивание данных";
            this.toolStripButtonPauseDownloading.Click += new System.EventHandler(this.toolStripButtonPauseDownloading_Click);
            // 
            // toolStripButtonUpdateTable
            // 
            this.toolStripButtonUpdateTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateTable.Image = global::RGR.Properties.Resources.Reload;
            this.toolStripButtonUpdateTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateTable.Name = "toolStripButtonUpdateTable";
            this.toolStripButtonUpdateTable.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonUpdateTable.Text = "Обновить данные таблицы";
            this.toolStripButtonUpdateTable.Click += new System.EventHandler(this.toolStripButtonUpdateTable_Click);
            // 
            // toolStripButtonTruncateTable
            // 
            this.toolStripButtonTruncateTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTruncateTable.Image = global::RGR.Properties.Resources.Truncate;
            this.toolStripButtonTruncateTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTruncateTable.Name = "toolStripButtonTruncateTable";
            this.toolStripButtonTruncateTable.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonTruncateTable.Text = "Удалить все данные базы данных";
            this.toolStripButtonTruncateTable.Click += new System.EventHandler(this.toolStripButtonTruncateTable_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 584);
            this.Controls.Add(this.plantBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Справочник растений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetRGRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_img_pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingNavigator)).EndInit();
            this.plantBindingNavigator.ResumeLayout(false);
            this.plantBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private dotNetRGRDataSet dotNetRGRDataSet;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private dotNetRGRDataSetTableAdapters.plantTableAdapter plantTableAdapter;
        private dotNetRGRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plantBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton plantBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView plantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox plant_img_pictureBox;
        private System.Windows.Forms.TextBox textBoxDecorativeQualities;
        private System.Windows.Forms.TextBox textBoxVariety;
        private System.Windows.Forms.TextBox textBoxGenus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem скачатьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСвоёИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDownloadData;
        private System.Windows.Forms.ToolStripButton toolStripButtonPauseDownloading;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateTable;
        private System.Windows.Forms.ToolStripButton toolStripButtonTruncateTable;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

