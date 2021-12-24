using lr11.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lr11
{
    public partial class FormMusicalInstrument : Form
    {
        private List<MusicalInstrumentType> _musicalInstrumentType;
        private MusicalInstrument _musicalInstrument;

        public MusicalInstrument MusicalInstrument
        {
            get { return _musicalInstrument; }
            set
            {
                _musicalInstrument = value;
                textBoxNames.Text = _musicalInstrument.names;
                textBoxBrand.Text = _musicalInstrument.brand;

                foreach (var item in _musicalInstrumentType)
                {
                    comboBoxType.Items.Add(item.title);

                    if (!(MusicalInstrument is null))
                    {
                        if (item.id == _musicalInstrument.typeId)
                        {
                            comboBoxType.SelectedItem = item.title;
                        }
                    }
                }
            }
        }

        public FormMusicalInstrument(List<MusicalInstrumentType> musicalInstrumentTypes)
        {
            InitializeComponent();

            _musicalInstrumentType = musicalInstrumentTypes;

            foreach (var item in musicalInstrumentTypes)
            {
                if (!(MusicalInstrument is null))
                {
                    if (item.id == MusicalInstrument.typeId)
                    {
                        comboBoxType.SelectedItem = item.title;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MusicalInstrument.names = textBoxNames.Text;
            MusicalInstrument.brand = textBoxBrand.Text;

            if (comboBoxType.SelectedItem is null)
            {
                MusicalInstrument.typeId = -1;
            }
            else
            {
                MusicalInstrument.typeId = -1;
                foreach (var item in _musicalInstrumentType)
                {
                    if (item.title == (string)comboBoxType.SelectedItem)
                    {
                        MusicalInstrument.typeId = item.id;
                    }
                }
            }
        }
    }
}
