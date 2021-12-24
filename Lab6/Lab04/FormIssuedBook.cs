using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Lab04
{
    public partial class FormIssuedBook : Form
    {
        private IssuedBook _issuedBook;

        public IssuedBook IssuedBook
        {
            get { return _issuedBook; }
            set
            {
                _issuedBook = value;
                comboBoxReader.SelectedItem = _issuedBook.Reader;
                comboBoxBook.SelectedItem = _issuedBook.Book;
                dateTimePickerIssueDate.Value = _issuedBook.IssueDate;
                dateTimePickerReturnDate.Value = _issuedBook.ReturnDate;
            }
        }
        private readonly Library _library = Library.Instance;
        public FormIssuedBook()
        {
            InitializeComponent();

            _library.ReaderAdded += _library_ReaderAdded;
            _library.ReaderRemoved += _library_ReaderRemoved;
            _library.BookAdded += _library_BookAdded;
            _library.BookRemoved += _library_BookRemoved;

            foreach (var reader in _library.Readers)
            {
                comboBoxReader.Items.Add(reader);
            }
            foreach (var book in _library.Books)
            {
                comboBoxBook.Items.Add(book);
            }
        }

        private void _library_BookRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxBook.Items.Count; i++)
            {
                var book = comboBoxBook.Items[i] as Book;
                if (book?.BookId == key)
                {
                    comboBoxBook.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _library_BookAdded(object sender, EventArgs e)
        {
            comboBoxBook.Items.Add(sender);
        }

        private void _library_ReaderRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxReader.Items.Count; i++)
            {
                var reader = comboBoxReader.Items[i] as Reader;
                if (reader?.ReaderId == key)
                {
                    comboBoxReader.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _library_ReaderAdded(object sender, EventArgs e)
        {
            comboBoxReader.Items.Add(sender);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _issuedBook.Reader = comboBoxReader.SelectedItem as Reader;
            _issuedBook.Book = comboBoxBook.SelectedItem as Book;
            _issuedBook.IssueDate = dateTimePickerIssueDate.Value;
            _issuedBook.ReturnDate = dateTimePickerReturnDate.Value;
        }
    }
}
