using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nombremagique.Views
{
    public partial class WinPage : ContentPage
    {
        public WinPage() : this(5) {


        }

        public WinPage(int nombreMagique)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            mainLayout.Scale = 0.7;
            mainLayout.ScaleTo(1.0, 1500, Easing.BounceIn);

            magicNumberLabel.Text = "Le nombre magique était: " + nombreMagique;

            NavigateBackToWelcomePage();
        }

        private async Task NavigateBackToWelcomePage() {
            await Task.Delay(3000);
            await Navigation.PopToRootAsync();
        }
    }
}
