using System;
using System.Collections.Generic;
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

namespace prct1labEF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DS3Entities context = new DS3Entities();
        public MainWindow()
        {
            InitializeComponent();
            WeaponGRD.ItemsSource = context.Weapons.ToList();
        }
        private void WeaponDRG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = WeaponGRD.SelectedItem as Weapons;
        }
        private void WeaponDRG_Selection(object sender, SelectionChangedEventArgs e)
        {
            var selected = WeaponGRD.SelectedItem as Weapons;
            MessageBox.Show(selected.Weapon_ID.ToString()); 
            MessageBox.Show(selected.WeaponClass);
        }
    }
}
