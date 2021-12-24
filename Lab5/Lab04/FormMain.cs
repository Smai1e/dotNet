using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Lab04
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void addReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = new Reader();
            FormReader formClient = new FormReader(reader);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                Library.Readers.Add(reader.ReaderId, reader);
                UpdateReadersList();
            }
        }

        private void editReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = listViewReaders.SelectedItems[0].Tag as Reader;
            FormReader formClient = new FormReader(reader);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateReadersList();
            }
        }

        private void UpdateReadersList()
        {
            listViewReaders.Items.Clear();
            foreach (var item in Library.Readers)
            {
                var reader = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = reader,
                    Text = reader.ToString()
                };
                listViewReaders.Items.Add(listViewItem);
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var book = new Book();
            FormBook formRoom = new FormBook(book);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                Library.Books.Add(book.BookId, book);
                UpdateBooksList();
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var book = listViewBooks.SelectedItems[0].Tag as Book;
            FormBook formRoom = new FormBook(book);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                UpdateBooksList();
            }
        }

        private void UpdateBooksList()
        {
            listViewBooks.Items.Clear();
            foreach (var item in Library.Books)
            {
                var book = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = book,
                    Text = book.ToString()
                };
                listViewBooks.Items.Add(listViewItem);
            }
        }

        private void addIssuedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var issuedBook = new IssuedBook();
            FormIssuedBook formIssuedBook = new FormIssuedBook(issuedBook);
            if (formIssuedBook.ShowDialog() == DialogResult.OK)
            {
                Library.IssuedBooks.Add(issuedBook);
                UpdateIssuedBookList();
            }
        }

        private void editIssuedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var issuedBook = listViewIssuedBooks.SelectedItems[0].Tag as IssuedBook;
            FormIssuedBook formIssuedBook = new FormIssuedBook(issuedBook);
            if (formIssuedBook.ShowDialog() == DialogResult.OK)
            {
                UpdateIssuedBookList();
            }  
        }

        private void UpdateIssuedBookList()
        {
            listViewIssuedBooks.Items.Clear();
            foreach (var issuedBook in Library.IssuedBooks)
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
    }
}
