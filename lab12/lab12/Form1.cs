using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void musical_InstrumentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musical_InstrumentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dotNetDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotNetDataSet.Musical_Instrument_Type". При необходимости она может быть перемещена или удалена.
            this.musical_Instrument_TypeTableAdapter.Fill(this.dotNetDataSet.Musical_Instrument_Type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotNetDataSet.Musical_Instrument". При необходимости она может быть перемещена или удалена.
            this.musical_InstrumentTableAdapter.Fill(this.dotNetDataSet.Musical_Instrument);

        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid1.Visible = !propertyGrid1.Visible;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)musical_InstrumentBindingSource.Current;
            dotNetDataSet.Musical_InstrumentRow cr = (dotNetDataSet.Musical_InstrumentRow)(drw.Row);
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(ofd.FileName);
                toolStripStatusLabel1.Text = "Фотография загружена";
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)musical_InstrumentBindingSource.Current;
            dotNetDataSet.Musical_InstrumentRow sr = (dotNetDataSet.Musical_InstrumentRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (photoPictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    photoPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabel1.Text = "Фотография успешно сохранена";
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            photoPictureBox.Image = null;
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.document_PrintPage);
            ppd.Document = document;
            ppd.ShowDialog();
            document.PrintPage -= new PrintPageEventHandler(this.document_PrintPage);
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = topMargin;
            float photoWidth = e.PageSettings.PaperSize.Width - 2 * e.MarginBounds.Left;
            float photoHeight = photoWidth  * photoPictureBox.Image.Height / photoPictureBox.Image.Width;
            Font font = new Font("Times New Roman", 14);
            Font font2 = new Font("Times New Roman", 14, FontStyle.Bold);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Тип инструмента", 1);
            dict.Add("Название", 3);
            dict.Add("Бренд", 5);

            int i = 1;
            foreach (var item in dict)
            {
                e.Graphics.DrawString(item.Key + ":", font2, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos = topMargin + (item.Value * font.GetHeight(e.Graphics));
                e.Graphics.DrawString(musical_InstrumentDataGridView.CurrentRow.Cells[i++].Value.ToString(), font, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos = topMargin + ((item.Value + 1) * font.GetHeight(e.Graphics));
            }

            if (musical_InstrumentDataGridView.CurrentRow.Cells[4].Value != System.DBNull.Value)
            {
                yPos = topMargin + (12 * font.GetHeight(e.Graphics));
                e.Graphics.DrawString("Изображение:", font2, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos = topMargin + (13 * font.GetHeight(e.Graphics));
                MemoryStream ms = new MemoryStream((byte[])musical_InstrumentDataGridView.CurrentRow.Cells[4].Value);
                
                
                e.Graphics.DrawImage(Image.FromStream(ms), leftMargin, yPos, photoWidth, photoHeight);
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void musical_Instrument_TypeDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string cell = musical_Instrument_TypeDataGridView.CurrentCell.Value.ToString();
            musical_Instrument_TypeDataGridView.CurrentCell.ErrorText = "";
            if (string.IsNullOrWhiteSpace(cell))
            {
                musical_Instrument_TypeDataGridView.CurrentCell.ErrorText = "Поле должно быть не пустым!!";
            }
        }

        private void musical_Instrument_TypeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string cell = musical_Instrument_TypeDataGridView.CurrentCell.Value.ToString();
            musical_Instrument_TypeDataGridView.CurrentCell.ErrorText = "";
            if (string.IsNullOrWhiteSpace(cell))
            {
                musical_Instrument_TypeDataGridView.CurrentCell.ErrorText = "Поле должно быть не пустым!!";
            }
        }

        private void toolStripButtonSaveType_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musicalInstrumentTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dotNetDataSet);
        }
    }
}
