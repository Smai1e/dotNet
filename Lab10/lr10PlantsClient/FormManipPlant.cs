using lr10Plants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr10PlantsClient
{
    public partial class FormManipPlant : Form
    {
        public Plant Plant;

        public FormManipPlant(string title, string btnText)
        {   
            InitializeComponent();

            Plant = new Plant();
            this.Text = title;
            buttonAdd.Text = btnText;

            comboBoxDepartament.Items.Add(PlantDepartament.Водоросли);
            comboBoxDepartament.Items.Add(PlantDepartament.Мхи);
            comboBoxDepartament.Items.Add(PlantDepartament.Попортники);
            comboBoxDepartament.Items.Add(PlantDepartament.Хвойные);
            comboBoxDepartament.Items.Add(PlantDepartament.Цветковые);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxKey.Text))
                Plant.Title = textBoxKey.Text;

            if (!String.IsNullOrWhiteSpace(textBoxFamily.Text))
                Plant.Family = textBoxFamily.Text;

            if (!String.IsNullOrWhiteSpace(textBoxDescription.Text))
                Plant.Description = textBoxDescription.Text;

            Plant.Departament = (PlantDepartament)comboBoxDepartament.SelectedItem;
        }
    }
}
