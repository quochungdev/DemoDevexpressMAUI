using DemoDevExpress1.ViewModels;
using Java.Util;

namespace DemoDevExpress1
{
    public partial class MainPage : ContentPage
    {
        //private CategoryViewModel viewModel = new CategoryViewModel();
        private CategoryViewModel viewModel = App.CategoryViewModel;


        public MainPage()
        {
            InitializeComponent();
            CategoryDataGrid.ItemsSource = viewModel.Categories;
        }

        private void OnAddCategoryClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            double price = Double.Parse(PriceEntry.Text);
            string imageUrl = ImageEntry.Text;
            if (!string.IsNullOrEmpty(name))
            {
                viewModel.AddCategory(name, price, imageUrl);
                NameEntry.Text = string.Empty;
                PriceEntry.Text = string.Empty;
                ImageEntry.Text = string.Empty;
                CategoryDataGrid.RefreshData();

                Console.WriteLine(viewModel.Categories.Count);
            }

            // Gọi PullToRefreshCommand để cập nhật Categories
            //viewModel.PullToRefreshCommand.Execute(null);
        }
    }
}