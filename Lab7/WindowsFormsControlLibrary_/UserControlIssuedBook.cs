using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsControlLibrary_
{
    public partial class UserControlIssuedBook: UserControl
    {
        private readonly Library _library = Library.Instance;
        public IssuedBook IssuedBook { get; }

        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControlIssuedBook)) continue;
                            var userControlIssuedBook = control as UserControlIssuedBook;
                            if (userControlIssuedBook != this)
                            {
                                userControlIssuedBook.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }

        public UserControlIssuedBook(IssuedBook issuedBook)
        {
            InitializeComponent();
            IssuedBook = issuedBook;
        }

        private void UserControlIssuedBook_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _library.RemoveIssuedBook(IssuedBook);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о выданной книге");
            }
        }

        private void UserControlIssuedBook_Paint(object sender, PaintEventArgs e)
        {
            textBoxReader.Text = $@"{IssuedBook.Reader.LastName} {IssuedBook.Reader.FirstName[0]}.{IssuedBook.Reader.MiddleName[0]}.";
            textBoxBook.Text = IssuedBook.Book.BookId.ToString("0");
            textBoxPeriod.Text = $@"С {IssuedBook.IssueDate:dd MMMM yyyy} по {IssuedBook.ReturnDate:dd MMMM yyyy}";
            if (IssuedBook.ReturnDate < DateTime.Today)
            {
                textBoxPeriod.BackColor = Color.Green;
            }
            else
            {
                textBoxPeriod.BackColor = IssuedBook.IssueDate < DateTime.Today ? Color.Yellow : Color.Red;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;

        }
    }
}
