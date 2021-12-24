using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Lab04
{
    public partial class FormReader : Form
    {
        private Reader _reader;

        public Reader Reader
        {
            get { return _reader; }
            set
            {
                _reader = value;
                textBoxFirstName.Text = _reader.FirstName;
                textBoxMiddleName.Text = _reader.MiddleName;
                textBoxLastName.Text = _reader.LastName;
                textBoxAddress.Text = _reader.Address;
                maskedTextBoxPhoneNumber.Text = _reader.PhoneNumber;
            }
        }

        public FormReader()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _reader.FirstName = textBoxFirstName.Text;
            _reader.MiddleName = textBoxMiddleName.Text;
            _reader.LastName = textBoxLastName.Text;
            _reader.Address = textBoxAddress.Text;
            _reader.PhoneNumber = maskedTextBoxPhoneNumber.Text;
        }
    }
}
