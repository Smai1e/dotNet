using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Lab04
{
    public partial class FormReader : Form
    {
        public Reader Reader { get; }

        public FormReader(Reader reader)
        {
            InitializeComponent();
            Reader = reader;
            textBoxFirstName.Text = Reader.FirstName;
            textBoxMiddleName.Text = Reader.MiddleName;
            textBoxLastName.Text = Reader.LastName;
            textBoxAddress.Text = Reader.Address;
            maskedTextBoxPhoneNumber.Text = Reader.PhoneNumber;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Reader.FirstName = textBoxFirstName.Text;
            Reader.MiddleName = textBoxMiddleName.Text;
            Reader.LastName = textBoxLastName.Text;
            Reader.Address = textBoxAddress.Text;
            Reader.PhoneNumber = maskedTextBoxPhoneNumber.Text;
        }
    }
}
