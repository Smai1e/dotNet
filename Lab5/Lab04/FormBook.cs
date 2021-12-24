using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Lab04
{
    public partial class FormBook : Form
    {
        public Book Book { get; }
        public FormBook(Book book)
        {
            InitializeComponent();
            Book = book;
            textBoxName.Text = Book.Name;
            comboBoxJenre.Items.Add(JenreEnum.Fantasy);
            comboBoxJenre.Items.Add(JenreEnum.Detective);
            comboBoxJenre.Items.Add(JenreEnum.Folktale);
            comboBoxJenre.Items.Add(JenreEnum.Drama);
            comboBoxJenre.Items.Add(JenreEnum.Poetry);
            comboBoxJenre.SelectedItem = Book.Jenre;
            numericUpDownPledgeCost.Value = Book.PledgeCost;
            numericUpDownRentalCost.Value = Book.RentalCost;
            textBoxFirstName.Text = Book.Author.FirstName;
            textBoxLastName.Text = Book.Author.LastName;
            textBoxMiddleName.Text = Book.Author.MiddleName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Book.Name = textBoxName.Text;
            Book.Jenre = (JenreEnum)comboBoxJenre.SelectedItem;
            Book.PledgeCost = numericUpDownPledgeCost.Value;
            Book.RentalCost = numericUpDownRentalCost.Value;
            Book.Author.LastName = textBoxLastName.Text;
            Book.Author.FirstName = textBoxFirstName.Text;
            Book.Author.MiddleName = textBoxMiddleName.Text;
        }
    }
}
