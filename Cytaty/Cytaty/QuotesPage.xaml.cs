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
        public string[] Cytaty =
        {
            "Nie przejmuj się porażkami. Rację musisz mieć tylko raz.",
            "Twoją marką jest to, co ludzie mówią o tobie, kiedy wyjdziesz z pokoju.",
            "Najbardziej niezadowoleni klienci to twoje najlepsze źródło nauki."
        };

        public int Cytat = 0;

        public QuotesPage()
        {
            InitializeComponent();
            cytat.Text = Cytaty[Cytat];

            if (Device.OS == TargetPlatform.Android) Padding = new Thickness(20, 30, 20, 20);
            if (Device.OS == TargetPlatform.WinPhone) Padding = new Thickness(20, 40, 20, 20);

            Device.OnPlatform(
                iOS: new Thickness(20, 20, 20, 20),
                Android: new Thickness(20, 30, 20, 20),
                WinPhone: new Thickness(20, 40, 20, 20)
            );
        }

        public void ZmienCytat(object sender, EventArgs e)
        {

            Cytat++;
            if (Cytat > Cytaty.Length - 1)
            {
                Cytat = 0;
            }
            cytat.Text = Cytaty[Cytat];

        }
    }
}
