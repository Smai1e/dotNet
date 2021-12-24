using lr11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr11
{
    public partial class FormMusicalInstrumentType : Form
    {
        private MusicalInstrumentType _musicalInstrumentType;

        public MusicalInstrumentType MusicalInstrumentType
        {
            get { return _musicalInstrumentType; }
            set
            {
                _musicalInstrumentType = value;
                textBoxTitle.Text = _musicalInstrumentType.title;
                textBoxDescription.Text = _musicalInstrumentType.description;
            }
        }

        public FormMusicalInstrumentType()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MusicalInstrumentType.title = textBoxTitle.Text;
            MusicalInstrumentType.description = textBoxDescription.Text;
        }
    }
}
