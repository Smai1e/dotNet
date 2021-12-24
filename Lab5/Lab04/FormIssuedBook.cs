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
        public IssuedBook IssuedBook { get; }
        public FormIssuedBook(IssuedBook issuedBook)
        {
            InitializeComponent();
            IssuedBook = issuedBook;
            foreach (var item in Library.Readers)
            {
                var reader = item.Value;
                comboBoxReader.Items.Add(reader);
            }
            foreach (var item in Library.Books)
            {
                var book = item.Value;
                comboBoxBook.Items.Add(book);
            }
            comboBoxReader.SelectedItem = issuedBook.Reader;
            comboBoxBook.SelectedItem = issuedBook.Book;
            dateTimePickerIssueDate.Value = issuedBook.IssueDate;
            dateTimePickerReturnDate.Value = issuedBook.ReturnDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            IssuedBook.Reader = comboBoxReader.SelectedItem as Reader;
            IssuedBook.Book = comboBoxBook.SelectedItem as Book;
            IssuedBook.IssueDate = dateTimePickerIssueDate.Value;
            IssuedBook.ReturnDate = dateTimePickerReturnDate.Value;
        }
    }
}
