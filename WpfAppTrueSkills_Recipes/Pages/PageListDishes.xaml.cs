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
    /// Interaction logic for PageListDishes.xaml
    /// </summary>
    public partial class PageListDishes : Page
    {
        Models.MyRecipesEntities _context = new Models.MyRecipesEntities();
        public PageListDishes()
        {
            InitializeComponent();

            RefreshData();
        }

        private void RefreshData()
        {
            List<Models.Dish> listDishes = _context.Dishes.ToList();

            LViewDishes.ItemsSource = listDishes;
        }
    }
}
