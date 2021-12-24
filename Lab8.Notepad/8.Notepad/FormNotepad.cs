using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Notepad
{
    public partial class FormNotepad : Form
    {
        private string FilePath = null;
        private FileSystemWatcher FileSystemWatcher = null;

        public FormNotepad()
        {
            InitializeComponent();
        }

        private void saveAfterClose(object sender, KeyEventArgs e)
        {

        }

        private void setEnabledElem(bool state)
        {
            toolStripMenuItemSave.Enabled = state;
            toolStripMenuItemClose.Enabled = state;
            textBoxMain.Enabled = state;
        }

        

        public void FileCreatedChangedDeleted(object o, FileSystemEventArgs e)
        {
            if (FileSystemWatcher != null)
            {
                FileSystemWatcher.Changed -= FileCreatedChangedDeleted;
                DialogResult result = MessageBox.Show("Файл был изменен другим процессом. Перезагрузить измененный файл?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (StreamReader reader = new StreamReader(File.OpenRead(FilePath)))
                    {
                        textBoxMain.Text = reader.ReadToEnd();
                    }
                }
                FileSystemWatcher.Changed += FileCreatedChangedDeleted;
            }
        }

        

        private void editorKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                toolStripMenuItemOpen_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                toolStripMenuItemCreate_Click(sender, e);
            }
            else if ((e.Control && e.KeyCode == Keys.S) && toolStripMenuItemSave.Enabled)
            {
                toolStripMenuItemSave_Click(sender, e);
            }
            else if ((e.Control && e.KeyCode == Keys.P) && toolStripMenuItemSave.Enabled)
            {
                toolStripMenuItemClose_Click(sender, e);
            }
        }

        private void saveAfterClose(object sender, FormClosingEventArgs e)
        {
            if (FilePath != null)
            {
                FileSystemWatcher.Changed -= FileCreatedChangedDeleted;
                FileSystemWatcher = null;
                DialogResult result = MessageBox.Show("Сохранить файл перед закрытием приложения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < textBoxMain.Lines.Length; i++)
                        {
                            sw.WriteLine(textBoxMain.Lines[i]);
                        }
                    }
                }
                textBoxMain.Text = "";
                FilePath = null;
                setEnabledElem(false);
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, System.EventArgs e)
        {
            if (FilePath != null)
            {
                FileSystemWatcher.Changed -= FileCreatedChangedDeleted;
                FileSystemWatcher = null;

                DialogResult result = MessageBox.Show("Сохранить файл перед открытием нового?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < textBoxMain.Lines.Length; i++)
                        {
                            sw.WriteLine(textBoxMain.Lines[i]);
                        }
                    }
                }
                textBoxMain.Text = "";
                FilePath = null;
                setEnabledElem(false);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;

                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    textBoxMain.Text = reader.ReadToEnd();
                }

                setEnabledElem(true);

                FileSystemWatcher = new FileSystemWatcher(Path.GetDirectoryName(FilePath), Path.GetFileName(FilePath));

                FileSystemWatcher.Changed += FileCreatedChangedDeleted;

                FileSystemWatcher.SynchronizingObject = this;
                FileSystemWatcher.EnableRaisingEvents = true;
            }
        }

        private void toolStripMenuItemCreate_Click(object sender, System.EventArgs e)
        {
            if (FilePath != null)
            {
                FileSystemWatcher.Changed -= FileCreatedChangedDeleted;
                FileSystemWatcher = null;
                DialogResult result = MessageBox.Show("Сохранить файл перед созданием нового?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < textBoxMain.Lines.Length; i++)
                        {
                            sw.WriteLine(textBoxMain.Lines[i]);
                        }
                    }
                }
                textBoxMain.Text = "";
                FilePath = null;
                setEnabledElem(false);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog.FileName;

                var fileStream = saveFileDialog.OpenFile();
                fileStream.Close();

                setEnabledElem(true);

                FileSystemWatcher = new FileSystemWatcher(Path.GetDirectoryName(FilePath), Path.GetFileName(FilePath));

                FileSystemWatcher.Changed += FileCreatedChangedDeleted;

                FileSystemWatcher.SynchronizingObject = this;
                FileSystemWatcher.EnableRaisingEvents = true;
            }
        }

        private void toolStripMenuItemClose_Click(object sender, System.EventArgs e)
        {
            if (FilePath == null)
                return;

            FileSystemWatcher = null;
            textBoxMain.Text = "";
            FilePath = null;
            setEnabledElem(false);
        }

        private void toolStripMenuItemSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                FileSystemWatcher.Changed -= FileCreatedChangedDeleted;

                using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < textBoxMain.Lines.Length; i++)
                    {
                        sw.WriteLine(textBoxMain.Lines[i]);
                    }
                }

                MessageBox.Show("Файл успешно сохранен!");
                FileSystemWatcher.Changed += FileCreatedChangedDeleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }
    }
}
