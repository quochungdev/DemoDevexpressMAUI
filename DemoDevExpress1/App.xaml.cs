using DemoDevExpress1.ViewModels;

namespace DemoDevExpress1
{
    public partial class App : Application
    {
        public static CategoryViewModel CategoryViewModel { get; } = new CategoryViewModel();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}