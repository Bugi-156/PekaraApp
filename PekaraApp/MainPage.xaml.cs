using PekaraApp.Pages;

namespace PekaraApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnViewProductsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductListPage());
        }

        private async void OnViewCartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartPage()); 
        }
    }
}
