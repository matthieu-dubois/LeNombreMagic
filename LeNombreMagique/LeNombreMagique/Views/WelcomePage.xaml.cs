using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nombremagique.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            InfiniteScale(playButton, 1000);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        private async Task InfiniteScale(View view, uint length)
        {
            bool always = true;
            while (always)
            {
                await view.ScaleTo(1.1, length);
                await view.ScaleTo(1.0, length);
            }
        }

        void PlayButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }
    }
}
