using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workers;

namespace RGR
{
    public partial class Form1 : Form
    {
        private bool _read;

        private bool reading
        {
            get
            {
                return _read;
            }
            set
            {
                _read = value;
                toolStripButtonDownloadData.Enabled = !_read;
                toolStripButtonTruncateTable.Enabled = !_read;
            }
        }

        public Form1()
        {
            InitializeComponent();

            Dictionary<ErrorProvider, TextBoxBase> helper = new Dictionary<ErrorProvider, TextBoxBase>();

            helper.Add(errorProvider1, textBoxGenus);
            helper.Add(errorProvider2, textBoxVariety);
            helper.Add(errorProvider3, textBoxDecorativeQualities);

            foreach (var item in helper)
            {
                item.Value.Tag = item.Key;
                item.Value.Validating += errorProvider_RightToLeftChanged;
                item.Value.Validated += errorProvider_RightToLeftChanged;
            }

            Loader.OnComplete += Loader_OnComplete;
        }

        private void Loader_OnComplete()
        {
            MessageBox.Show("Данные сайта загружены");
            StatusLabel.Text = string.Empty;
            
            try
            {
                reading = false;
            }
            catch (Exception) { }
        }

        private async void UpdateStatusLabel(string text, int time = 10000)
        {
            StatusLabel.Text = text;
            await Task.Delay(time);
            StatusLabel.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotNetRGRDataSet.plant". При необходимости она может быть перемещена или удалена.
            this.plantTableAdapter.Fill(this.dotNetRGRDataSet.plant);

        }

        private void toolStripButtonDownloadData_Click(object sender, EventArgs e)
        {
            Loader.StartReading();
            StatusLabel.Text = "Данные загружаются из сайта!";
            reading = true;
        }

        private void toolStripButtonPauseDownloading_Click(object sender, EventArgs e)
        {
            Loader.StopReading();
            StatusLabel.Text = string.Empty;
            toolStripButtonUpdateTable_Click(sender, e);
            reading = false;
        }

        private void toolStripButtonUpdateTable_Click(object sender, EventArgs e)
        {
            this.plantTableAdapter.Fill(this.dotNetRGRDataSet.plant);
            UpdateStatusLabel("Обновление успешно!");
            if (!reading)
            {
                reading = false;
            }
        }

        private void plantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.plantBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dotNetRGRDataSet);
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(textBoxGenus.Text))
                    MessageBox.Show("Нельзя довавить пустую строку!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Наименование растения должно быть уникальным", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripButtonUpdateTable_Click(sender, e);
            }
        }

        private void скачатьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstallImage(plant_img_pictureBox);
        }

        private void загрузитьСвоёИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadImage(plant_img_pictureBox);
        }

        private void UploadImage(PictureBox pictureBox)
        {
            DataRowView drw = (DataRowView)plantBindingSource.Current;
            dotNetRGRDataSet.plantRow cr = (dotNetRGRDataSet.plantRow)(drw.Row);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(ofd.FileName);
                UpdateStatusLabel("Фотография загружена");
            }
        }

        private void InstallImage(PictureBox pictureBox)
        {
            DataRowView drw = (DataRowView)plantBindingSource.Current;
            dotNetRGRDataSet.plantRow sr = (dotNetRGRDataSet.plantRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    UpdateStatusLabel("Фотография сохранена");
                }
            }
        }

        private void удалитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plant_img_pictureBox.Image = null;
        }

        private void errorProvider_RightToLeftChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBoxBase;
            var errorProvider = textBox.Tag as ErrorProvider;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Значение поля должно быть не пустым");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void toolStripButtonTruncateTable_Click(object sender, EventArgs e)
        {
            Loader.TruncateTable();
            toolStripButtonUpdateTable_Click(sender, e);
        }

        private void plantDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Возникла ошибка при обращении к базе данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void plantDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
        }
    }
}
