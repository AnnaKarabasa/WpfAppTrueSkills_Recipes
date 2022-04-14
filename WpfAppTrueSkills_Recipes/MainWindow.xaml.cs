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

namespace WpfAppTrueSkills_Recipes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new Pages.PageListDishes());



            Models.MyRecipesEntities context = new Models.MyRecipesEntities();
            var categories = context.Categories.Where(x => x.Name.Length <= 5).OrderByDescending(x => x.Name).Select(x => x.Id + ": " + x.Name).ToList();

            var avgCost = context.Ingredients.Max(x => x.Cost);

            var secondPageIngredients = context.Ingredients.ToList().Skip(10).Take(10).Select(x=> x.Id + ": " + x.Name).ToList();

            var firstCategory = context.Categories.FirstOrDefault();


            //Models.Category category = new Models.Category
            //{
            //    Id=6,
            //    Name="Напитки"
            //};
            //context.Categories.Add(category);
            //context.SaveChanges();
            var category = context.Categories.FirstOrDefault(x => x.Id == 6);
            //category.Name = "Напиток";
            //context.SaveChanges();

            context.Categories.Remove(category);
            context.SaveChanges();
        }

        private void BtnDishes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageListDishes());
        }

        private void BtnIngredients_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageListIngredients());
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
