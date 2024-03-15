using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using prct1lab.DS3DataSetTableAdapters;

namespace prct1lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeaponsTableAdapter weapons = new WeaponsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            WeaponsComboBox.ItemsSource = weapons.GetData();
            WeaponsComboBox.DisplayMemberPath = "WeaponName";
        }
        private void WeaponComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cellID = (WeaponsComboBox.SelectedItem as DataRowView).Row[0];
            object WeaponName = (WeaponsComboBox.SelectedItem as DataRowView).Row[1];

            MessageBox.Show($"ID: {cellID}, Weapon Name: {WeaponName}");
        }
    }
}
