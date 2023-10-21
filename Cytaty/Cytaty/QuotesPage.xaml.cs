using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cytaty
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
            BindingContext = this;

            if (Device.OS == TargetPlatform.Android) Padding = new Thickness(20, 30, 20, 20);
            if (Device.OS == TargetPlatform.WinPhone) Padding = new Thickness(20, 40, 20, 20);

            Device.OnPlatform(
                iOS: new Thickness(20, 20, 20, 20),
                Android: new Thickness(20, 30, 20, 20),
                WinPhone: new Thickness(20, 40, 20, 20)
            );

        }

        public string[] Cytaty { get; set; } = {
            "Twoją marką jest to, co ludzie mówią o tobie, kiedy wyjdziesz z pokoju.",
            "Najbardziej niezadowoleni klienci to twoje najlepsze źródło nauki."
        };
    }
}
