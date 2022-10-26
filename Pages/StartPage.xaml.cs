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
using TartugaLeksikovIzrancev.Classes;
using TartugaLeksikovIzrancev.EF;

namespace TartugaLeksikovIzrancev.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();

            lvTables.ItemsSource = AppData.Context.RestourantTable.ToList();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Grid obj)
            {
                if (obj.DataContext is RestourantTable table)
                {
                    GlobalInformation.IDTable = table;
                    PageController.MainFrame.Navigate(new MenuPage(table));
                }
            }
        }
    }
}
