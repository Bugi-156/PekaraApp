using PekaraApp.Models;
using System.Text.Json;
using Microsoft.Maui.Storage;
using Microsoft.Maui.Controls;

namespace PekaraApp.Pages
{
    public partial class ProductListPage : ContentPage
    {
        private List<Product> products;

        public ProductListPage()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            products = new List<Product>
            {
                new Product {
                    Name = "Kruh",
                    Price = 1.5,
                    ImageUrl = "bijeli_kruh.jpg",
                    Description = "Kruh je osnovni proizvod izrađen od brašna, vode, kvasca i soli. Pečen je do savršene hrskavosti na vanjskoj strani, dok iznutra ostaje mekan i sočan. Idealno je za doručak, obrok ili kao prilog uz juhu ili salatu."
                },
                new Product {
                    Name = "Pecivo",
                    Price = 1.0,
                    ImageUrl = "pecivo.jpg",
                    Description = "Pekarsko pecivo napravljeno od finog brašna, kvasca i maslaca. Ima laganu, pahuljastu teksturu i blagi, bogat okus. Savršeno je za užinu ili kao prateći proizvod uz topli napitak."
                },
                new Product {
                    Name = "Kolač",
                    Price = 2.5,
                    ImageUrl = "kolac.jpg",
                    Description = "Sočan kolač pripremljen od jaja, brašna, šećera, mlijeka i maslaca. Sadrži bogat okus vanilije i laganu teksturu koja topi u ustima. Savršen je za desert ili posebne prigode."
                },
                new Product {
                    Name = "Pizza",
                    Price = 2.0,
                    ImageUrl = "pizza.jpg",
                    Description = "Tanka korica pizze s bogatim slojem rajčice, sira i raznih začina. Po želji se mogu dodati razni nadjevi poput šunke, gljiva, paprike i maslina. Pečena do zlatne boje, pruža savršen balans okusa i teksture."
                },
                new Product {
                    Name = "Čokoladni kolač",
                    Price = 2.0,
                    ImageUrl = "cokoladni_kolac.jpg",
                    Description = "Kolač bogat čokoladom, pripremljen od tamne čokolade, jaja, šećera i brašna. Ispod bogate čokoladne kore krije se sočan, gust unutarnji dio. Idealno je za ljubitelje čokolade i savršeno kao desert ili uz kavu."
                },
                new Product {
                    Name = "Baget",
                    Price = 1.3,
                    ImageUrl = "baget.jpg",
                    Description = "Dugi, tanki kruh s hrskavom koricom i mekanim unutrašnjim dijelom. Baget je klasičan francuski kruh napravljen od jednostavnih sastojaka – brašna, vode, kvasca i soli. Savršen je za sendviče ili kao prilog uz obrok."
                },
                new Product {
                    Name = "Pita sa sirom",
                    Price = 3.0,
                    ImageUrl = "pita_sa_sirom.jpg",
                    Description = "Tradicionalna pita sa sirom koja se priprema od svježeg lisnatog tijesta, napunjenog kremastim sirom. Lagana i hrskava, pita sa sirom savršen je izbor za užinu ili brzinski obrok."
                }
            };

            productCollectionView.ItemsSource = products;
        }

        private async void OnDetailsClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var product = button?.CommandParameter as Product;

            if (product != null)
            {
                await Navigation.PushAsync(new ProductDetailPage(product));
            }
        }
    }
}
