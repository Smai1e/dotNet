using lr11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr11
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;

        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=dotNet;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }

        private void updateInstrumentTypes()
        {
            var types = MusicalInstrumentType.List(_connection);
            listViewMusicalInstrumentType.Items.Clear();
            for (int i = 0; i < types.Count; i++)
            {
                var type = types[i];
                var listListViewItem = listViewMusicalInstrumentType.Items.Add(type.id.ToString());
                listListViewItem.Tag = type;
                listListViewItem.SubItems.Add(type.title);
                listListViewItem.SubItems.Add(type.description);
            }
        }

        private void updateMusicalInstruments()
        {
            var instruments = MusicalInstrument.List(_connection);
            listViewMusicalInstrument.Items.Clear();
            for (int i = 0; i < instruments.Count; i++)
            {
                var instrument = instruments[i];
                var listListViewItem = listViewMusicalInstrument.Items.Add(instrument.id.ToString());
                listListViewItem.Tag = instrument;
                listListViewItem.SubItems.Add(instrument.typeName);///
                listListViewItem.SubItems.Add(instrument.names);
                listListViewItem.SubItems.Add(instrument.brand);
            }
        }

        private void toolStripButtonTypeLoad_Click(object sender, EventArgs e)
        {
            updateInstrumentTypes();
        }

        private void toolStripButtonTypeAdd_Click(object sender, EventArgs e)
        {     ///////////////////////////////////////////////////////////////////////////////////
            FormMusicalInstrumentType form = new FormMusicalInstrumentType
            {
                MusicalInstrumentType = new MusicalInstrumentType { }
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrWhiteSpace(form.MusicalInstrumentType.title))
                {
                    MessageBox.Show("Укажите тип инструмента!", "Ошибка");
                }
                else
                {
                    MusicalInstrumentType.Insert(_connection, form.MusicalInstrumentType);
                }
            }
            updateInstrumentTypes();
            updateMusicalInstruments();
        }

        private void toolStripButtonTypeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormMusicalInstrumentType form = new FormMusicalInstrumentType
                {
                    MusicalInstrumentType = (MusicalInstrumentType)listViewMusicalInstrumentType.SelectedItems[0].Tag
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (String.IsNullOrWhiteSpace(form.MusicalInstrumentType.title))
                    {
                        MessageBox.Show("Укажите тип инструмента!", "Ошибка");
                    }
                    else
                    {
                        MusicalInstrumentType.Update(_connection, form.MusicalInstrumentType);
                    }
                }
                updateInstrumentTypes();
                updateMusicalInstruments();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись!", "Ошибка");
            }
        }

        private void toolStripButtonTypeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MusicalInstrumentType.Delete(_connection, ((MusicalInstrumentType)listViewMusicalInstrumentType.SelectedItems[0].Tag).id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении");
            }
            updateInstrumentTypes();
            updateMusicalInstruments();
        }

        private void toolStripButtonInstrumentLoad_Click(object sender, EventArgs e)
        {
            updateMusicalInstruments();
        }

        private void toolStripButtonInstrumentAdd_Click(object sender, EventArgs e)
        {
            FormMusicalInstrument form = new FormMusicalInstrument(MusicalInstrumentType.List(_connection));
            form.MusicalInstrument = new MusicalInstrument();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrWhiteSpace(form.MusicalInstrument.names) || String.IsNullOrWhiteSpace(form.MusicalInstrument.brand) || form.MusicalInstrument.typeId == -1)
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                }
                else
                {
                    MusicalInstrument.Insert(_connection, form.MusicalInstrument);
                }
            }
            updateMusicalInstruments();
        }

        private void toolStripButtonInstrumentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormMusicalInstrument form = new FormMusicalInstrument(MusicalInstrumentType.List(_connection));
                form.MusicalInstrument = (MusicalInstrument)listViewMusicalInstrument.SelectedItems[0].Tag;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (String.IsNullOrWhiteSpace(form.MusicalInstrument.names) || String.IsNullOrWhiteSpace(form.MusicalInstrument.brand) || form.MusicalInstrument.typeId == -1)
                    {
                        MessageBox.Show("Заполните все поля!", "Ошибка");
                    }
                    else
                    {
                        MusicalInstrument.Update(_connection, form.MusicalInstrument);
                    }
                }
                updateMusicalInstruments();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись!", "Ошибка");
            }
        }

        private void toolStripButtonInstrumentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MusicalInstrument.Delete(_connection, ((MusicalInstrument)listViewMusicalInstrument.SelectedItems[0].Tag).id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении");
            }
            updateMusicalInstruments();
        }
    }
}
