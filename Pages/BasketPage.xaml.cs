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
            if (GlobalInformation.Sale != null)
            {
                tbPromocode.IsEnabled = false;
                btnPromocode.Content = "X";
                tbPromocode.Text = GlobalInformation.PromocodeName;
            }
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

            if (GlobalInformation.Sale != null)
            {
                totalCost = totalCost - (totalCost *Convert.ToDecimal(GlobalInformation.Sale));
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
                order.TotalCost =Convert.ToDecimal(totalPrice());
                order.IDRestourantTable =Convert.ToInt32( GlobalInformation.IDTable.IDTable);
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
                AppData.updateAppData();
                var currentOrder = AppData.Context.Order.OrderByDescending(i=>i.OrderTime).FirstOrDefault();

                foreach (EF.Product prod in GlobalInformation.ListOfOrder.Distinct())
                {
                    EF.OrderProduct orderProduct = new EF.OrderProduct();
                    orderProduct.IDOrder = currentOrder.IDOrder;
                    orderProduct.IDProduct = prod.IDProduct;
                    orderProduct.Count = prod.OrderProdCount;
                    AppData.Context.OrderProduct.Add(orderProduct);
                    AppData.Context.SaveChanges();

                }

                MessageBox.Show("Заказ сделан, ожидайте");
                GlobalInformation.IDTable = null;
                GlobalInformation.ListOfOrder = new List<EF.Product>();
                GlobalInformation.PromocodeName = null;
                GlobalInformation.Sale = null;
                PageController.MainFrame.Navigate(new StartPage());

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

        private void btnPromocode_Click(object sender, RoutedEventArgs e)
        {
            if (tbPromocode.IsEnabled == true)
            {
                var promo = AppData.Context.Promocode.Where(i => i.Code == tbPromocode.Text).FirstOrDefault();

                if (promo != null)
                {
                    GlobalInformation.Sale = Convert.ToString(promo.Discount);
                    GlobalInformation.PromocodeName = tbPromocode.Text;
                    tbPromocode.IsEnabled = false;
                    btnPromocode.Content = "X";
                    Refresh();
                    MessageBox.Show("Промокод успешно активирован");
                }
                else
                {
                    MessageBox.Show("Такого промокода нет");

                }
            }
            else
            {
                tbPromocode.IsEnabled = true;
                tbPromocode.Text = "";
                btnPromocode.Content = "=>";
                GlobalInformation.Sale = null;
                Refresh();
            }
          
        }
    }
}
