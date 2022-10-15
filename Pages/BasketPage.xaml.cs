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
            tbPrice.Text = "Итоговая стоимость: " + totalPrice();
            tbTable.Text = "Ваш столик: " + GlobalInformation.IDTable.IDTable;
            lvOrder.ItemsSource = GlobalInformation.ListOfOrder.Distinct().OrderBy(i=>i.IDProduct);
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

        //мeтод удаляющий запись ил ListView при нажатии Delete
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
            try
            {
                EF.Order order = new EF.Order();
                order.TotalCost =Convert.ToDecimal(tbPrice.Text);
                order.IDRestourantTable =Convert.ToInt32(tbTable.Text);
                order.OrderTime = DateTime.Now;
                order.IDEmployee = 1;
                order.IDPromocode = null;
                if (rbCard.IsChecked == true)
                {
                    order.IsCashless = true;
                }
                else
                {
                    order.IsCashless = false;
                }
                order.IDStatus = 1;

                AppData.Context.Order.Add(order);
                AppData.Context.SaveChanges();
                var currentOrder = AppData.Context.Order.Where(i => i.OrderTime == order.OrderTime ).FirstOrDefault();

                foreach(EF.Product prod in GlobalInformation.ListOfOrder.Distinct())
                {
                    EF.OrderProduct orderProduct = new EF.OrderProduct();
                    orderProduct.IDOrder = currentOrder.IDOrder;
                    orderProduct.IDProduct = prod.IDProduct;
                    orderProduct.Count = prod.OrderProdCount;
                    AppData.Context.OrderProduct.Add(orderProduct);
                    AppData.Context.SaveChanges();

                }

                MessageBox.Show("Сделаем вид, что заказ оформлен, ок?");

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message).ToString();
            }
        }



        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            EF.Product btn = (sender as Button).DataContext as EF.Product;
            GlobalInformation.ListOfOrder.Add(btn);
            Refresh();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            lvOrder.SelectedItem = (sender as Button).DataContext;

            var prod = lvOrder.SelectedItem as EF.Product;
            GlobalInformation.ListOfOrder.Remove(prod);
            Refresh();
        }
    }
}
