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

namespace WpfAppTrueSkills_Recipes.Pages
{
    /// <summary>
    /// Interaction logic for PageListIngredients.xaml
    /// </summary>
    public partial class PageListIngredients : Page
    {
        Models.MyRecipesEntities _context = new Models.MyRecipesEntities();

        public PageListIngredients()
        {
            InitializeComponent();

            RefreshData();
        }

        private void RefreshData()
        {
            List<Models.Ingredient> listIngredients = _context.Ingredients.ToList();
            DGridIngredients.ItemsSource = listIngredients;

            LblTotalQuantity.Content = listIngredients.Count + " наименований";
            double sum = listIngredients.Sum(x => x.Price * x.AvailableCount);
            LblTotalSum.Content = $"Запасов в холодильнике на сумму: {sum:N2} руб.";
        }

        private void BtnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void BtnPreviousPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLastPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BorderPlus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void LinkEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LinkDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
