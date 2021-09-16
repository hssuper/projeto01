using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina02 : ContentPage
    {
        public Pagina02()
        {
            InitializeComponent();

            StackLayout stk = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };
            Label lb1 = new Label()
            {
                Text = "Curso Xamarin",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                BackgroundColor = Color.Black,
                Padding = new Thickness(10),
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            stk.Children.Add(lb1);

            Label lb2 = new Label()
            {
                Text = "Banco De Dados ",
                FontSize = 20,
                TextColor = Color.DarkBlue,  
               
            };
            Label lb3 = new Label()
            {
                Text = "Java Web(EE)",
                FontSize = 20,
                TextColor = Color.DarkRed,
            };
            StackLayout stk2 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.Center,
            };
            stk2.Children.Add(lb2);
            stk2.Children.Add(lb3);
            stk.Children.Add(stk2);
            Image img = new Image()
            {
                Source = "img/img2.png",
            };
            Button bt1 = new Button()
            {
                Text = "Enviar",
                Padding = new Thickness(15),
                HeightRequest = 45,
                WidthRequest = 200,
                BackgroundColor = Color.DarkGreen,
                TextColor = Color.White,
                FontSize = 15,
                Margin = new Thickness(20),
                 
            };

            stk.Children.Add(bt1);

            stk.Children.Add(img);
            Content = stk;
        }
    }
}