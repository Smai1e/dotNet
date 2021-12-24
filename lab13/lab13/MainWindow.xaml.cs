using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace lab13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private dotNetDataSet _dotNetDataSet;
        private dotNetDataSetTableAdapters.Musical_Instrument_TypeTableAdapter _dotNetDataSetMusicalInstrumentTypeTableAdapter;
        private dotNetDataSetTableAdapters.Musical_InstrumentTableAdapter _dotNetDataSetMusicalInstrumentTableAdapter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _dotNetDataSet = (dotNetDataSet)FindResource("dotNetDataSet");
            // Загрузить данные в таблицу Company. Можно изменить этот код как требуется.
            _dotNetDataSetMusicalInstrumentTypeTableAdapter = new dotNetDataSetTableAdapters.Musical_Instrument_TypeTableAdapter();
            _dotNetDataSetMusicalInstrumentTypeTableAdapter.Fill(_dotNetDataSet.Musical_Instrument_Type);
            var usersViewSource = (CollectionViewSource)FindResource("musical_Instrument_TypeViewSource");
            usersViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу PhoneModel. Можно изменить этот код как требуется.
            _dotNetDataSetMusicalInstrumentTableAdapter = new dotNetDataSetTableAdapters.Musical_InstrumentTableAdapter();
            _dotNetDataSetMusicalInstrumentTableAdapter.Fill(_dotNetDataSet.Musical_Instrument);
            var usersCommentsViewSource = (CollectionViewSource)FindResource("musical_InstrumentViewSource");
            usersCommentsViewSource.View.MoveCurrentToFirst();
        }

        private void load_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (musical_InstrumentDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = musical_InstrumentDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as dotNetDataSet.Musical_InstrumentRow;
                        if (dataRow != null)
                        {
                            dataRow.photo = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }

        private void SaveMusicalInstrumentType_Click(object sender, RoutedEventArgs e)
        {
            _dotNetDataSetMusicalInstrumentTypeTableAdapter.Update(_dotNetDataSet.Musical_Instrument_Type);
        }

        private void DeleteMusicalInstrumentType_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < musical_Instrument_TypeDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = musical_Instrument_TypeDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            _dotNetDataSetMusicalInstrumentTypeTableAdapter.Update(_dotNetDataSet.Musical_Instrument_Type);
            _dotNetDataSetMusicalInstrumentTableAdapter.Update(_dotNetDataSet.Musical_Instrument);
        }

        private void SaveMusicalInstrument_Click(object sender, RoutedEventArgs e)
        {
            _dotNetDataSetMusicalInstrumentTableAdapter.Update(_dotNetDataSet.Musical_Instrument);
        }

        private void DeleteMusicalInstrument_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < musical_InstrumentDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = musical_InstrumentDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            _dotNetDataSetMusicalInstrumentTableAdapter.Update(_dotNetDataSet.Musical_Instrument);
        }
    }




    /*
     public partial class MainWindow : Window
    {
        private dotNetDataSet DealerDataSet;
        private dotNetDataSetTableAdapters.Musical_InstrumentTableAdapter MusicalInstrumentTableAdapter;
        private dotNetDataSetTableAdapters.Musical_Instrument_TypeTableAdapter MusicalInstrumentTypeTableAdapter;

        System.Windows.Data.CollectionViewSource musicalInstrumentsViewSource;
        System.Windows.Data.CollectionViewSource musicalInstrumentTypesViewSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DealerDataSet = ((dotNetDataSet)(this.FindResource("dotNetDataSet")));
            // Загрузить данные в таблицу MusicalInstrument. Можно изменить этот код как требуется.
            MusicalInstrumentTableAdapter = new lab13.dotNetDataSetTableAdapters.Musical_InstrumentTableAdapter();
            MusicalInstrumentTableAdapter.Fill(DealerDataSet.Musical_Instrument);

            musicalInstrumentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("musicalInstrumentsViewSource")));
            musicalInstrumentsViewSource.View.MoveCurrentToFirst();

            // Загрузить данные в таблицу MusicalInstrumentType. Можно изменить этот код как требуется.
            MusicalInstrumentTypeTableAdapter = new lab13.dotNetDataSetTableAdapters.Musical_Instrument_TypeTableAdapter();
            MusicalInstrumentTypeTableAdapter.Fill(DealerDataSet.Musical_Instrument_Type);

            musicalInstrumentTypesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("musicalInstrumentTypesViewSource")));
            musicalInstrumentTypesViewSource.View.MoveCurrentToFirst();
        }

        private void load_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (musical_InstrumentDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = musical_InstrumentDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as dotNetDataSet.Musical_InstrumentRow;
                        if (dataRow != null)
                        {
                            dataRow.photo = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }

        private void SaveMusicalInstrumentType_Click(object sender, RoutedEventArgs e)
        {
            MusicalInstrumentTypeTableAdapter.Update(DealerDataSet.Musical_Instrument_Type);
        }

        private void SaveMusicalInstrumentButton_Click(object sender, RoutedEventArgs e)
        {
            MusicalInstrumentTableAdapter.Update(DealerDataSet.Musical_Instrument);
        }
    }
     */
}