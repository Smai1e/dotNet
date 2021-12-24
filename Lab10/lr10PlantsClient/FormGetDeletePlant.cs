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
    public partial class FormGetDeletePlant : Form
    {
        public string Key;

        public FormGetDeletePlant(string title, string btnText)
        {
            InitializeComponent();
            this.Text = title;
            buttonGet.Text = btnText;
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            Key = textBoxKey.Text;
        }
    }
}
