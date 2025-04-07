using PekaraApp.Pages;

namespace PekaraApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

    }
}
