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


namespace TartugaLeksikovIzrancev.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public BasketPage()
        {
            InitializeComponent();
            Refresh();
        }

        //Метод для обновления ListView 
        public void Refresh()
        {
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = GlobalInformation.ListOfOrder;
            tbTable.Text = "Ваш столик: " + GlobalInformation.IDTable.IDTable;
            tbPrice.Text = "Итоговая стоимость: " + totalPrice();
        }

        //Метод Высчитывающий итоговую стоимость заказа
        public string totalPrice()
        {
            decimal totalCost = 0;
            foreach(EF.Product prod in GlobalInformation.ListOfOrder)
            {
                totalCost += prod.Cost;
            }
            return Convert.ToString(totalCost);
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageController.MainFrame.Navigate(new MenuPage(GlobalInformation.IDTable));
        }

        //мутод удаляющий запись ил ListView при нажатии Delete
        private void lvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                if(lvOrder.SelectedItem is EF.Product)
                {
                    var prod = lvOrder.SelectedItem as EF.Product;
                    GlobalInformation.ListOfOrder.Remove(prod);
                    Refresh();
                }
            }
        }

        private void btnGoBasket_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сделаем вид, что заказ оформлен, ок?");
        }
    }
}
