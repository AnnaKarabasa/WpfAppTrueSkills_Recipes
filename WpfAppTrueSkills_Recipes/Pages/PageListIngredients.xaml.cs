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
        int _currentPage = 1, _countInPage = 5, _maxPages;

        public PageListIngredients()
        {
            InitializeComponent();

            RefreshData();
        }

        private void RefreshData()
        {
            List<Models.Ingredient> listIngredients = _context.Ingredients.ToList();

            _maxPages =(int)Math.Ceiling(listIngredients.Count*1.0 / _countInPage);
            listIngredients = listIngredients.Skip((_currentPage - 1) * _countInPage).Take(_countInPage).ToList();

            DGridIngredients.ItemsSource = listIngredients;

            LblTotalQuantity.Content = listIngredients.Count + " наименований";
            double sum = listIngredients.Sum(x => x.Price * x.AvailableCount);
            LblTotalSum.Content = $"Запасов в холодильнике на сумму: {sum:N2} руб.";
        }

        private void BtnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = 1;
            RefreshData();
        }

        private void BtnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            _currentPage--;
            RefreshData();
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {
            _currentPage++;
            RefreshData();
        }

        private void BtnLastPage_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPages;
            RefreshData();
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
