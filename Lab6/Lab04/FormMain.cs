using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Lab04
{
    public partial class FormMain : Form
    {
        private readonly Library _library = Library.Instance;
        readonly FormBook _formBook = new FormBook();
        readonly FormReader _formReader = new FormReader();
        readonly FormIssuedBook _formIssuedBook = new FormIssuedBook();
        private object listViewClients;

        public FormMain()
        {
            InitializeComponent();
            _library.ReaderAdded += _library_ReaderAdded;
            _library.BookAdded += _library_BookAdded;
            _library.IssuedBookAdded += _library_IssuedBookAdded;
            _library.ReaderRemoved += _library_ReaderRemoved;
            _library.BookRemoved += _library_BookRemoved;
            _library.IssuedBookRemoved += _library_IssuedBookRemoved;
        }

        private void _library_IssuedBookRemoved(object sender, EventArgs e)
        {
            var issuedBook = sender as IssuedBook;
            for (int i = 0; i < listViewIssuedBooks.Items.Count; i++)
            {
                if ((IssuedBook)listViewIssuedBooks.Items[i].Tag == issuedBook)
                {
                    listViewIssuedBooks.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _library_BookRemoved(object sender, EventArgs e)
        {
            var bookNumber = (int)sender;
            for (int i = 0; i < listViewBooks.Items.Count; i++)
            {
                if (((Book)listViewBooks.Items[i].Tag).BookId == bookNumber)
                {
                    listViewBooks.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _library_ReaderRemoved(object sender, EventArgs e)
        {
            var readerId = (int)sender;
            for (int i = 0; i < listViewReaders.Items.Count; i++)
            {
                if (((Reader)listViewReaders.Items[i].Tag).ReaderId == readerId)
                {
                    listViewReaders.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _library_IssuedBookAdded(object sender, EventArgs e)
        {
            var issuedBook = sender as IssuedBook;
            if (issuedBook != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = issuedBook,
                    Text = issuedBook.Reader.ToString()
                };
                listViewItem.SubItems.Add(issuedBook.Book.ToString());
                listViewItem.SubItems.Add(issuedBook.IssueDate.ToShortDateString());
                listViewItem.SubItems.Add(issuedBook.ReturnDate.ToShortDateString());
                listViewIssuedBooks.Items.Add(listViewItem);
            }
        }

        private void _library_BookAdded(object sender, EventArgs e)
        {
            var book = sender as Book;
            if (book != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = book,
                    Text = book.ToString()
                };
                listViewBooks.Items.Add(listViewItem);
            }
        }

        private void _library_ReaderAdded(object sender, EventArgs e)
        {
            var reader = sender as Reader;
            if (reader != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = reader,
                    Text = reader.ToString()
                };
                listViewReaders.Items.Add(listViewItem);
            }
        }

        private void addReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = new Reader();
            _formReader.Reader = reader;
            if (_formReader.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _library.AddReader(reader);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = listViewReaders.SelectedItems[0].Tag as Reader;
                _formReader.Reader = reader;
                if (_formReader.ShowDialog() == DialogResult.OK)
                {
                    listViewReaders.SelectedItems[0].Text = _formReader.Reader.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с читателем");
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var book = new Book();
            _formBook.Book = book;
            if (_formBook.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _library.AddBook(book);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var book = listViewBooks.SelectedItems[0].Tag as Book;
                _formBook.Book = book;
                if (_formBook.ShowDialog() == DialogResult.OK)
                {
                    listViewBooks.SelectedItems[0].Text = _formBook.Book.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с книгой");
            }
        }

        private void addIssuedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var issuedBook = new IssuedBook();
            _formIssuedBook.IssuedBook = issuedBook;
            if (_formIssuedBook.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _library.AddIssuedBook(issuedBook);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editIssuedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var issuedBook = listViewIssuedBooks.SelectedItems[0].Tag as IssuedBook;
                _formIssuedBook.IssuedBook = issuedBook;
                if (_formIssuedBook.ShowDialog() == DialogResult.OK)
                {
                    issuedBook = _formIssuedBook.IssuedBook;
                    var listViewItem = listViewIssuedBooks.SelectedItems[0];
                    listViewItem.Text = issuedBook.Reader.ToString();
                    listViewItem.SubItems[1].Text = issuedBook.Book.ToString();
                    listViewItem.SubItems[2].Text = issuedBook.IssueDate.ToShortDateString();
                    listViewItem.SubItems[3].Text = issuedBook.ReturnDate.ToShortDateString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с выданной книгой");
            }
        }

        private void listViewReaders_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var reader = listViewReaders.SelectedItems[0].Tag as Reader;
                    if (reader != null)
                    {
                        _library.RemoveReader(reader.ReaderId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с читателем");
                }
            }
        }

        private void listViewBooks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var book = listViewBooks.SelectedItems[0].Tag as Book;
                    if (book != null)
                    {
                        _library.RemoveBook(book.BookId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с книгой");
                }
            }
        }

        private void listViewIssuedBooks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var issuedBook = listViewIssuedBooks.SelectedItems[0].Tag as IssuedBook;
                    if (issuedBook != null)
                    {
                        _library.RemoveIssuedBook(issuedBook);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с выданной книгой");
                }
            }
        }
    }
}
