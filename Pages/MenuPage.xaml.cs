﻿using System;
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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {

        public MenuPage(EF.RestourantTable table)
        {
            InitializeComponent();
            txtTable.Text = $"Ваш столик: {table.IDTable}";
            lvCategory.SelectedIndex = 0;

            Filter();
        }

        //Метод Фильрации Продуктов
        public void Filter()
        {
            List<EF.Product> products = new List<EF.Product>();
            List<EF.Category> categories = new List<EF.Category>();
            categories = AppData.Context.Category.ToList();
            lvCategory.ItemsSource = categories;

            //выборка по категориям
            switch (lvCategory.SelectedIndex)
            {
                case 0:
                    {
                        products = AppData.Context.Product.Where(i => i.IDCategory == 1).ToList();
                        break;
                    }
                case 1:
                    {
                        products = AppData.Context.Product.Where(i => i.IDCategory == 2).ToList();
                        break;
                    }
                case 2:
                    {
                        products = AppData.Context.Product.Where(i => i.IDCategory == 3).ToList();
                        break;
                    }
                case 3:
                    {
                        products = AppData.Context.Product.Where(i => i.IDCategory == 4).ToList();
                        break;
                    }
                case 4:
                    {
                        products = AppData.Context.Product.Where(i => i.IDCategory == 5).ToList();
                        break;
                    }
                default:
                    {
                        products = AppData.Context.Product.ToList();
                        break;
                    }
            }

            lvMenu.ItemsSource = products;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageController.MainFrame.Navigate(new StartPage());
        }

        private void btnGoBasket_Click(object sender, RoutedEventArgs e)
        {
            PageController.MainFrame.Navigate(new BasketPage());
            
        }

        private void lvMenu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(lvMenu.SelectedItem is EF.Product)
            {
                var prod = lvMenu.SelectedItem as EF.Product;
                PageController.MainFrame.Navigate(new MoreDetailsPage(prod));

            }
        }

        private void lvCategory_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Filter();
        }

        //Метод добавления продукта в корзину 
        private void lvMenu_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(lvMenu.SelectedItem is EF.Product)
            {
                var prod = lvMenu.SelectedItem as EF.Product;
                GlobalInformation.ListOfOrder.Add(prod);
                MessageBox.Show(prod.ProductName + " Добавлено в корзину");
            }
        }
    }
}
